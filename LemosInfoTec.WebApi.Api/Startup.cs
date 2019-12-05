using LemosInfoTec.WebApi.Api.Contexto;
using LemosInfoTec.WebApi.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LemosInfoTec.WebApi.Api
{
    public class Startup
    {
          public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
             /*var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{configuration}.json", optional: true)
            .AddEnvironmentVariables();
             Configuration = builder.Build();*/
            Configuration = configuration;
        }

      

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {   
            var connection = @"Server=localhost;DataBase=DbWebApiDemo;Uid=root;Pwd=info@1234";
          // var conString = Configuration.GetConnectionString("MySqlConnection");
           // var connection = Configuration["ConnectionString:ConexaoMySql"];
            services.AddDbContext<UsuarioDbContexto>(options =>
            options.UseMySql(connection));
            services.AddTransient<IUsuarioRepository,UsuarioRepository>();
            
            services.AddMvc();
            services.AddRazorPages();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
