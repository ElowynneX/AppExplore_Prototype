
using AppExplore_API_Prototype.Data;
using AppExplore_API_Prototype.Model;
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
            builder.Services.AddControllersWithViews();
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
               //temporary in-memory database seeding 
                if (!context.Apps.Any())
                {
                    context.Apps.AddRange(
                        new AppModel
                        {
                            Id = 1,
                            Title = "Spotify",
                            Description = "Spotify is a digital music service that gives you access to millions of songs, podcasts, and audiobooks.",
                            Developer = "Spotify AB",
                            Rating = 5,
                            Category = "Music",
                            Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium", "Ads" },
                            Tags = new List<string> { "Music", "Streaming", "Podcasts", "Playlists" }
                        },
                        new AppModel
                        {
                            Id = 2,
                            Title = "Instagram",
                            Description = "Instagram allows users to share photos and videos, follow friends and creators, and discover visual content.",
                            Developer = "Meta Platforms, Inc.",
                            Rating = 4,
                            Category = "Social Networking",
                            Type = new List<string> { "Apple", "Android", "Free", "Ads" },
                            Tags = new List<string> { "Photos", "Videos", "Stories", "Social Media" }
                        },
                         new AppModel
                         {
                             Id = 3,
                             Title = "Google Maps",
                             Description = "Google Maps provides real-time GPS navigation, traffic conditions, and location-based discovery.",
                             Developer = "Google LLC",
                             Rating = 5,
                             Category = "Navigation",
                             Type = new List<string> { "Apple", "Android", "Free" },
                             Tags = new List<string> { "Maps", "GPS", "Traffic", "Directions" }
                         },
                        new AppModel
                        {
                             Id = 4,
                             Title = "Netflix",
                     Description = "Netflix is a streaming service offering movies, TV shows, documentaries, and original content.",
                    Developer = "Netflix, Inc.",
                    Rating = 4,
                    Category = "Entertainment",
                    Type = new List<string> { "Apple", "Android", "Free", "Membership" },
                    Tags = new List<string> { "Movies", "TV Shows", "Streaming", "Originals" }
                },
                new AppModel
                {
                    Id = 5,
                    Title = "FitBit",
                    Description = "The best fitness application to keep track of your health.",
                    Developer = "Google",
                    Rating = 5,
                    Category = "Health & Fitness",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Health", "Fitness", "Tracker" }
                },
                new AppModel
                {
                    Id = 6,
                    Title = "WhatsApp",
                    Description = "WhatsApp enables users to send messages, make voice and video calls, and share media securely.",
                    Developer = "WhatsApp LLC",
                    Rating = 4,
                    Category = "Communication",
                    Type = new List<string> { "Apple", "Android", "Free" },
                    Tags = new List<string> { "Messaging", "Calls", "Video", "Encryption" }
                },
                new AppModel
                {
                    Id = 7,
                    Title = "YouTube Music",
                    Description = "YouTube Music is a music streaming service that provides official songs, albums, playlists, remixes, and live performances.",
                    Developer = "Google LLC",
                    Rating = 4,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium", "Ads" },
                    Tags = new List<string> { "Music", "Streaming", "Playlists", "Live Performances", "Podcasts" }
                },
                new AppModel
                {
                    Id = 8,
                    Title = "Apple Music",
                    Description = "Apple Music is a subscription-based music streaming service offering millions of songs, curated playlists, and exclusive artist content.",
                    Developer = "Apple Inc.",
                    Rating = 5,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Free", "Paid-Premium", "Ads" },
                    Tags = new List<string> { "Music", "Streaming", "Playlists", "Radio" }
                },
                new AppModel
                {
                    Id = 9,
                    Title = "Tasker",
                    Description = "Tasker is a powerful Android automation app that allows users to create custom tasks and workflows based on triggers, contexts, and actions.",
                    Developer = "João Dias",
                    Rating = 5,
                    Category = "Productivity",
                    Type = new List<string> { "Android" },
                    Tags = new List<string> { "Automation", "Workflows", "Customization" }
                }
                        );
                   
                  

                    context.SaveChanges();
                
            }
        }

            //Add swagger and swagger UI
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=AppMvc}/{action=Index}/{id?}");
            });
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
