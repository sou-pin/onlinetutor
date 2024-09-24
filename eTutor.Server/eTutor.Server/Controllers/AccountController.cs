using AutoMapper;
using eTutor.DataService.Data;
using eTutor.DataService.Models;
using eTutor.Server.DTO;
using eTutor.Server.Interfaces;
using eTutor.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace eTutor.Server.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly eTutorDbContext _context;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        public AccountController(eTutorDbContext context, ITokenService tokenService, IMapper mapper)
        {
            _mapper = mapper;
            _tokenService = tokenService;
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] RegisterDto registerdto)
        {
            if (await UserExist(registerdto.EmailId!))
            {
                return BadRequest("EmailId is taken");
            }
            var user = _mapper.Map<User>(registerdto);
            using var hmac = new HMACSHA512();
            user.EmailID = registerdto.EmailId!.ToLower();
            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerdto.Password!));
            user.PasswordSalt = hmac.Key;
            user.UserTypeID = 2;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return new UserDto
            {
                Username = user.EmailID,
                Token = _tokenService.CreateToken(user)
            };
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users
            .SingleOrDefaultAsync(x => x.EmailID == loginDto.Username);

            if (user == null) return Unauthorized("Invalid username");

            using var hmac = new HMACSHA512(user.PasswordSalt!);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash![i])
                    return Unauthorized("Invalid Password");
            }

            return new UserDto
            {
                Username = user.EmailID!,
                Token = _tokenService.CreateToken(user)
            };
        }

        private async Task<bool> UserExist(string username)
        {
            return await _context.Users.AnyAsync(x => x.EmailID == username.ToLower());
        }
    }
}
