namespace InfernitasSE.Projects.OpenIssueTracker.Backend
{
    using log4net.Repository.Hierarchy;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.PlatformAbstractions;
    using System;
    using System.IO;
    using System.Reflection;

    /// <summary>
    /// Startup Class.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration) => this.Configuration = configuration;

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Startup));

        /// <summary>
        /// XML Configuration File Path.
        /// </summary>
        private static string XmlCommentsFilePath
        {
            get
            {
                try
                {
                    var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                    var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                    Log.InfoFormat("XML Documentation File found: {0}", Path.Combine(basePath, fileName));
                    return Path.Combine(basePath, fileName);
                }
                catch (FileNotFoundException)
                {
                    Log.Warn("Could not find XML Documentation File!");
                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message);
                }
                return "";
            }
        }

        /// <summary>
        /// Configuration from appsettings.*
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configure Services.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddCors(options => options.AddDefaultPolicy(policy =>
            {
                /* Policy Settings */
                policy.AllowCredentials();
                policy.AllowAnyHeader();
                policy.AllowAnyMethod();
                policy.WithOrigins(new string[] { "localhost:4200" });
                policy.SetIsOriginAllowed(_ => true);
                policy.SetIsOriginAllowedToAllowWildcardSubdomains();
                /* Build Policy */
                policy.Build();
            }));
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1.0.0",
                    Title = "Infernitas SE: OpenIssueTracker",
                    Description = "Backend API from Infernitas SE's OpenIssueTracker",
                });
                config.IncludeXmlComments(XmlCommentsFilePath);
            });
        }

        /// <summary>
        /// Configure App.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory">Logger Factory for log4net</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(config => config.SwaggerEndpoint("/swagger/v1/swagger.json", "OpenIssueTracker"));
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            Log.Info("Startup...");
        }
    }
}
