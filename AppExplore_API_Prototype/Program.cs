
using AppExplore_API_Prototype.Data;
using AppExplore_API_Prototype.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace AppExplore_API_Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Use In-Memory Database because it's easier to deploy on Azure Devops
            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("AppExplore_Prototype"));

            //Add line to access DB & repositories
            builder.Services.AddScoped<IAppRepository, AppRepository>();

            var app = builder.Build();


            //---------------Due to using in-memory database, this will ensure that the database is created---------------//
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
            }

            //Add swagger and swagger UI
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
