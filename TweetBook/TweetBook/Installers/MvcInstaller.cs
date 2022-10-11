using Microsoft.OpenApi.Models;

namespace TweetBook.Installers;

public class MvcInstaller : IInstaller
{
    public void InstallServices(IServiceCollection service, ConfigurationManager configuration)
    {
        service.AddControllersWithViews();
        service.AddSwaggerGen(opt =>
        {
            opt.SwaggerDoc("v1", new OpenApiInfo {Title = "Tweetbook API", Version = "v1"});
        });
    }
}