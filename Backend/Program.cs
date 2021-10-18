namespace InfernitasSE.Projects.OpenIssueTracker.Backend
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
    using System.Net;

    /// <summary>
    /// Main Program Class.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Main Method.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        /// <summary>
        /// Create HostBuilder-Object.,
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel(options => options.Listen(IPAddress.Loopback, 5080));
                    webBuilder.UseStartup<Startup>();
                });
    }
}
