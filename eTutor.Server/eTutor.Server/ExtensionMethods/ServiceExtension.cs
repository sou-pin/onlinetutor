using eTutor.DataService.Data;
using eTutor.DataService.Interrfaces;
using eTutor.Server.Helpers;
using eTutor.Server.Interfaces;
using eTutor.Server.Services;
using Microsoft.EntityFrameworkCore;

namespace eTutor.Server.ExtensionMethods
{
    public static class ServiceExtension
    {
        public static IServiceCollection ApplicationService(this WebApplicationBuilder webApplicationBuilder)
        {
            webApplicationBuilder.Services.AddEntityFrameworkNpgsql().AddDbContext<eTutorDbContext>(options =>
                options.UseNpgsql(webApplicationBuilder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("eTutor.Server"))
            );
            webApplicationBuilder.Services.AddScoped<IMasterData, MasterData>();
            webApplicationBuilder.Services.AddScoped<ITokenService, TokenService>();
            webApplicationBuilder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            return webApplicationBuilder.Services;
        }
    }
}
