using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSoftfinc.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ApiSoftfinc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IFileProvider>(
             new PhysicalFileProvider(
                 Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));



            //Configuration.GetConnectionString("DefaultConnection")
            string conectionstr = "Data Source=srvmonitor;Initial Catalog=DbSoftfinc001;Integrated Security=False;User Id=sa;Password=231154;MultipleActiveResultSets=True";
            //recojo la coneccion string
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(conectionstr));


          //services.AddDbContext<ApplicationDbContext>(options =>
        //options.UseInMemoryDatabase("dbdemo"));


                // services.AddIdentity<ApplicationUser, IdentityRole>()
               // .AddEntityFrameworkStores<ApplicationDbContext>()
               //.AddDefaultTokenProviders();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidateIssuerSigningKey = true,
                     ValidIssuer = "yourdomain.com",
                     ValidAudience = "yourdomain.com",
                     IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(Configuration["Llave_super_secreta"])),
                     ClockSkew = TimeSpan.Zero
                 });

            services.AddMvc().AddJsonOptions(ConfigureJson);
        }


        private void ConfigureJson(MvcJsonOptions obj)
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseAuthentication();

          
            app.UseMvc();
        }
    }
}
