
using BusinessLogicLayer.MappingConfig;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.IServices;
using DataAccessLayer.Entities;
using DataAccessLayer.IRepos;
using DataAccessLayer.Repos;
using DataAccessLayer.UnitOfWorks;
using Microsoft.EntityFrameworkCore;


namespace PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<NitcotekContext>( op => op.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddAutoMapper(config => config.AddProfile<MappingProfile>());

            builder.Services.AddCors( op =>
            {
                op.AddPolicy(txt,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    }
                );
            });


            #region General Services Registration:

            builder.Services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));

            #endregion

            #region Unit Of Work Registration:

             builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion

            #region Business Services Registration:

            builder.Services.AddScoped<IAccountService, AccountService>();


            #endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI( op => op.SwaggerEndpoint("/openapi/v1.json" , "v1"));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(txt);

            app.MapControllers();

            app.Run();
        }
    }
}
