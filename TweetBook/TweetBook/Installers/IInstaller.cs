namespace TweetBook.Installers;

public interface IInstaller
{
    void InstallServices(IServiceCollection service, ConfigurationManager configuration);
}