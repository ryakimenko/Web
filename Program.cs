using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web
{

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {

            IWebHostBuilder host = WebHost.CreateDefaultBuilder(args);
            return host.UseStartup<Startup>();
        }
    }
}
