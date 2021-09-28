using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Text;
using br.com.paype.Data;
using br.com.paype.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace br.com.paype
{
    public class Startup
    {
        public static IConfiguration StaticConfig { get; private set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            StaticConfig = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string conString = Configuration.GetConnectionString("value");
            services.AddDbContext<DataContextDB>(
                options => options.UseSqlServer(conString)
            );

            services.AddScoped<DataContextDB, DataContextDB>();            

            services.AddCors();
            string chaveSecreta = Configuration.GetSection("API").GetSection("chave").Value;
            var hashSHA256 = TokenService.GenerateHashSHA256(chaveSecreta);
            var key = Encoding.ASCII.GetBytes(hashSHA256);

            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(jwt =>
            {
                jwt.RequireHttpsMetadata = false;
                jwt.SaveToken = true;
                jwt.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

            });

            services.AddSingleton<IAuthorizationHandler, AgeRequirementHandler>();
            services.AddAuthorization(options =>
            {
                //options.AddPolicy("PROG_PESSOA.CADASTRO", authBuilder => authBuilder.RequireClaim("policies"));
                options.AddPolicy("PROG_PESSOA.CADASTRO", authBuilder => {

                    authBuilder.RequireRole("PROG_PESSOA");

                    authBuilder.RequireClaim("policies");


                });

                options.AddPolicy("age_policy", authBuilder => authBuilder.AddRequirements(new AgeRequirement(18)));
            });

            services.AddControllers().AddNewtonsoftJson(
                options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            );

            //services.AddSingleton<IAuthorizationMiddlewareResultHandler, MyAuthorizationMiddlewareResultHandler>();

            services.AddSwaggerGen(swg =>
            {
                swg.SwaggerDoc("v1", new OpenApiInfo() { Title = "Paype", Version = "1.0" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseCors(cors =>
            {
                cors.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
            });

            app.UseAuthMiddleware();

            app.UseSwagger();

            app.UseSwaggerUI(swg =>
            {
                swg.RoutePrefix = "/swagger/mapeamento/rotas";
                swg.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            //app.Use(async (context, next) => { 
            //    await context.Response.WriteAsync("Taoo midleware");
            //    await next();
            //});

            //app.Run(async (context) => await context.Response.WriteAsync("acabou"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
