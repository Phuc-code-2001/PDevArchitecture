using Microsoft.EntityFrameworkCore;
using PDevArchitecture.Application.Interceptors;
using PDevArchitecture.EntityFramework;
using PDevArchitecture.EntityFramework.DataAccess;

namespace PDevArchitecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            // Add services to the container.
            builder.Services.AddAutoMapper(assemblies);
            builder.Services.AddRepositoryCore();
            builder.Services.AddLogging();

            // DB
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // API
            builder.Services.AddControllers()
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = new InvalidModelStateResponseFactoryBehavior().Handler;
                });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Build
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}