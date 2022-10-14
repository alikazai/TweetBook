using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TweetBook.Data;
using TweetBook.Services;

namespace TweetBook.Installers;

public class DbInstaller : IInstaller
{
    public void InstallServices(IServiceCollection service, ConfigurationManager configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        service.AddDbContext<DataContext>(options =>
            options.UseSqlite(connectionString));
        service.AddDatabaseDeveloperPageExceptionFilter();

        service.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<DataContext>();

        service.AddSingleton<IPostService, PostService>();
    }
}