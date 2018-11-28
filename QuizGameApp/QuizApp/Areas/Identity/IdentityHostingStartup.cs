using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(QuizApp.Areas.Identity.IdentityHostingStartup))]
namespace QuizApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}