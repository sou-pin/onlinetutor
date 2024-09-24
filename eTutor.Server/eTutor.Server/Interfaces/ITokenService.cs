using eTutor.DataService.Models;

namespace eTutor.Server.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
