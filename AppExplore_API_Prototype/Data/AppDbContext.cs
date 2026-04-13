using AppExplore_API_Prototype.Model;
using Microsoft.EntityFrameworkCore;

namespace AppExplore_API_Prototype.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<AppModel> Apps { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppModel>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AppModel>().HasData(
                new AppModel
                {
                    Id = 1,
                    Title = "Spotify",
                    Description = "Spotify is a digital music service that gives you access to millions of songs, podcasts, and audiobooks.",
                    Developer = "Spotify AB",
                    Rating = 5,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium", "Adds" },
                    Tags = new List<string> { "Music", "Streaming", "Podcasts", "Playlists", "Podcasts" },
                    ImageUrl = "/images/apps/Spotify_Logo.png"
                },
                new AppModel
                {
                    Id = 2,
                    Title = "Instagram",
                    Description = "Instagram allows users to share photos and videos, follow friends and creators, and discover visual content.",
                    Developer = "Meta Platforms, Inc.",
                    Rating = 4,
                    Category = "Social Networking",
                    Type = new List<string> { "Apple", "Android", "Free", "Adds" },
                    Tags = new List<string> { "Photos", "Videos", "Stories", "Social Media" },
                    ImageUrl = "/images/apps/Instagram_Logo.jpg"
                },
                new AppModel
                {
                    Id = 3,
                    Title = "Google Maps",
                    Description = "Google Maps provides real-time GPS navigation, traffic conditions, and location-based discovery.",
                    Developer = "Google LLC",
                    Rating = 5,
                    Category = "Navigation",
                    Type = new List<string> { "Apple", "Android", "Free"},
                    Tags = new List<string> { "Maps", "GPS", "Traffic", "Directions" },
                    ImageUrl = "/images/apps/GoogleMaps_Logo.jpg"
                },
                new AppModel
                {
                    Id = 4,
                    Title = "Netflix",
                    Description = "Netflix is a streaming service offering movies, TV shows, documentaries, and original content.",
                    Developer = "Netflix, Inc.",
                    Rating = 4,
                    Category = "Entertainment",
                    Type = new List<string> { "Apple", "Android", "Free", "Membership"},
                    Tags = new List<string> { "Movies", "TV Shows", "Streaming", "Originals" },
                    ImageUrl = "/images/apps/Netflix_Logo.png"
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
                    Tags = new List<string> { "Health", "Fitness", "Tracker" },
                    ImageUrl = "/images/apps/Fitbit_Logo.png"
                },
                new AppModel
                {
                    Id = 6,
                    Title = "WhatsApp",
                    Description = "WhatsApp enables users to send messages, make voice and video calls, and share media securely.",
                    Developer = "WhatsApp LLC",
                    Rating = 4,
                    Category = "Communication",
                    Type = new List<string> { "Apple", "Android", "Free"},
                    Tags = new List<string> { "Messaging", "Calls", "Video", "Encryption" },
                    ImageUrl = "/images/apps/WhatsApp_Logo.png"
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
                    Tags = new List<string> { "Music", "Streaming", "Playlists", "Live Performances", "Podcasts" },
                    ImageUrl = "/images/apps/YouTubeMusic_Logo.png"
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
                    Tags = new List<string> { "Music", "Streaming", "Playlists", "Radio" },
                    ImageUrl = "/images/apps/AppleMusic_Logo.png"
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
                    Tags = new List<string> { "Automation", "Workflows", "Customization" },
                    ImageUrl = "/images/apps/Tasker_Logo.png"
                },

                new AppModel
                {
                    Id = 10,
                    Title = "Deezer",
                    Description = "Deezer is a music streaming service that provides access to millions of songs, playlists, and podcasts with personalized recommendations.",
                    Developer = "Deezer S.A.",
                    Rating = 4,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium", "Ads" },
                    Tags = new List<string> { "Music", "Streaming", "Playlists", "Podcasts", "Personalized" },
                    ImageUrl = "/images/apps/Deezer_Logo.png"
                },

                new AppModel
                {
                    Id = 11,
                    Title = "SoundCloud",
                    Description = "SoundCloud is a music streaming platform that allows users to discover, stream, and share independent music and podcasts.",
                    Developer = "SoundCloud Ltd.",
                    Rating = 4,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium", "Ads" },
                    Tags = new List<string> { "Music", "Streaming", "Indie", "Creators", "Podcasts" },
                    ImageUrl = "/images/apps/SoundCloud_Logo.jpg"
                },

                new AppModel
                {
                    Id = 12,
                    Title = "Google Play Music",
                    Description = "Google Play Music was a music streaming service offering access to songs, albums, and playlists, along with music uploads.",
                    Developer = "Google LLC",
                    Rating = 3,
                    Category = "Music",
                    Type = new List<string> { "Android", "Web", "Paid-Premium" },
                    Tags = new List<string> { "Music", "Streaming", "Library", "Uploads", "Playlists" },
                    ImageUrl = "/images/apps/GooglePlayMusic_Logo.png"
                },

                new AppModel
                {
                    Id = 13,
                    Title = "TIDAL",
                    Description = "TIDAL is a music streaming service known for high-fidelity sound quality, exclusive content, and artist-owned initiatives.",
                    Developer = "TIDAL (Block, Inc.)",
                    Rating = 4,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Android", "Paid-Premium" },
                    Tags = new List<string> { "Music", "Streaming", "HiFi", "Exclusive", "Artists", "Podcasts" },
                    ImageUrl = "/images/apps/Tidal_Logo.png"
                },

                new AppModel
                {
                    Id = 14,
                    Title = "Amazon Music",
                    Description = "Amazon Music is a streaming service offering a large catalog of songs, playlists, and integration with Amazon devices like Alexa.",
                    Developer = "Amazon.com, Inc.",
                    Rating = 4,
                    Category = "Music",
                    Type = new List<string> { "Apple", "Android", "Web", "Paid-Premium", "Free" },
                    Tags = new List<string> { "Music", "Streaming", "Alexa", "Playlists", "Library", "Podcasts" },
                    ImageUrl = "/images/apps/AmazonMusic_Logo.png"
                },

                new AppModel
                {
                    Id = 15,
                    Title = "Clash of Clans",
                    Description = "Build your village, train troops, and battle players worldwide in this strategy game.",
                    Developer = "Supercell",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp", "Ads" },
                    Tags = new List<string> { "Strategy", "Multiplayer", "Base Building", "War" },
                    ImageUrl = "/images/apps/CoC_Logo.jpg"
                },

                new AppModel
                {
                    Id = 16,
                    Title = "Clash Royale",
                    Description = "Real-time multiplayer battle game featuring Clash characters and strategic card-based combat.",
                    Developer = "Supercell",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Strategy", "Cards", "Multiplayer", "PvP" },
                    ImageUrl = "/images/apps/ClashRoyale_Logo.png"
                },

                new AppModel
                {
                    Id = 17,
                    Title = "Candy Crush Saga",
                    Description = "Match candies in this popular puzzle game with thousands of levels.",
                    Developer = "King",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Puzzle", "Casual", "Match-3", "Levels" },
                    ImageUrl = "/images/apps/CandyCrush_Logo.png"
                },

                new AppModel
                {
                    Id = 18,
                    Title = "Call of Duty: Mobile",
                    Description = "First-person shooter featuring multiplayer modes, battle royale, and iconic maps.",
                    Developer = "Activision Publishing, Inc.",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Shooter", "FPS", "Multiplayer", "Battle Royale" },
                    ImageUrl = "/images/apps/CoD_Logo.png"
                },

                new AppModel
                {
                    Id = 19,
                    Title = "PUBG Mobile",
                    Description = "Battle royale shooter where players fight to be the last one standing.",
                    Developer = "Tencent Games",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Shooter", "Battle Royale", "Survival", "Multiplayer" },
                    ImageUrl = "/images/apps/PubG_Logo.png"
                },

                new AppModel
                {
                    Id = 20,
                    Title = "Among Us",
                    Description = "Multiplayer social deduction game where players identify impostors among the crew.",
                    Developer = "Innersloth",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Paid", "Free" },
                    Tags = new List<string> { "Multiplayer", "Party", "Social", "Deduction" },
                    ImageUrl = "/images/apps/AmongUs_Logo.jpg"
                },

                new AppModel
                {
                    Id = 21,
                    Title = "Subway Surfers",
                    Description = "Endless runner game where you dodge trains and collect coins.",
                    Developer = "SYBO Games",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Runner", "Endless", "Arcade", "Casual" },
                    ImageUrl = "/images/apps/SubwaySurfers_Logo.png"
                },

                new AppModel
                {
                    Id = 22,
                    Title = "Temple Run 2",
                    Description = "Run, jump, and escape from danger in this endless runner adventure.",
                    Developer = "Imangi Studios",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Runner", "Endless", "Adventure", "Arcade" },
                    ImageUrl = "/images/apps/TempleRun2_Logo.png"
                },

                new AppModel
                {
                    Id = 23,
                    Title = "Roblox",
                    Description = "A platform where users can create and play millions of user-generated games.",
                    Developer = "Roblox Corporation",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Sandbox", "Multiplayer", "User-Generated", "Social" },
                    ImageUrl = "/images/apps/Roblox_Logo.png"
                },

                new AppModel
                {
                    Id = 24,
                    Title = "Minecraft",
                    Description = "Sandbox game where players can build, explore, and survive in blocky worlds.",
                    Developer = "Mojang",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Paid" },
                    Tags = new List<string> { "Sandbox", "Building", "Survival", "Creative" },
                    ImageUrl = "/images/apps/Minecraft_Logo.jpg"
                },

                new AppModel
                {
                    Id = 25,
                    Title = "Genshin Impact",
                    Description = "Open-world action RPG with anime-style graphics and elemental combat.",
                    Developer = "miHoYo",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "RPG", "Open World", "Adventure", "Anime" },
                    ImageUrl = "/images/apps/Genshin_Logo.png"
                },

                new AppModel
                {
                    Id = 26,
                    Title = "Fortnite",
                    Description = "Battle royale game with building mechanics and frequent live events.",
                    Developer = "Epic Games",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Battle Royale", "Shooter", "Building", "Multiplayer" },
                    ImageUrl = "/images/apps/Fortnite_Logo.png"
                },

                new AppModel
                {
                    Id = 27,
                    Title = "Brawl Stars",
                    Description = "Fast-paced multiplayer brawler with different game modes and characters.",
                    Developer = "Supercell",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Action", "Multiplayer", "Arena", "Competitive" },
                    ImageUrl = "/images/apps/BrawlStars_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 28,
                    Title = "8 Ball Pool",
                    Description = "Online pool game where players compete in matches and tournaments.",
                    Developer = "Miniclip",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Sports", "Pool", "Multiplayer", "Casual" },
                    ImageUrl = "/images/apps/8BallPool_Logo.jpg"
                },

                new AppModel
                {
                    Id = 29,
                    Title = "Hill Climb Racing",
                    Description = "Physics-based driving game with challenging terrain and upgrades.",
                    Developer = "Fingersoft",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Racing", "Physics", "Casual", "Driving" },
                    ImageUrl = "/images/apps/HillClimbRacing_Logo.jpg"
                },

                new AppModel
                {
                    Id = 30,
                    Title = "Jetpack Joyride",
                    Description = "Endless runner featuring jetpacks, gadgets, and missions.",
                    Developer = "Halfbrick Studios",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Runner", "Arcade", "Action", "Endless" },
                    ImageUrl = "/images/apps/JetpackJoyride_Logo.jpg"
                },

                new AppModel
                {
                    Id = 31,
                    Title = "Plants vs. Zombies 2",
                    Description = "Defend your garden from zombies using strategic plant placement.",
                    Developer = "Electronic Arts",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Strategy", "Tower Defense", "Casual", "Zombies" },
                    ImageUrl = "/images/apps/PvZ2_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 32,
                    Title = "Angry Birds 2",
                    Description = "Slingshot birds to defeat pigs in this physics-based puzzle game.",
                    Developer = "Rovio Entertainment",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-InApp" },
                    Tags = new List<string> { "Puzzle", "Physics", "Casual", "Arcade" },
                    ImageUrl = "/images/apps/AngryBirds2_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 33,
                    Title = "Monopoly GO!",
                    Description = "Mobile adaptation of the classic board game with social and online features.",
                    Developer = "Scopely",
                    Rating = 4,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "Board", "Multiplayer", "Casual", "Strategy" },
                    ImageUrl = "/images/apps/MonopolyGo_Logo.png"
                },

                new AppModel
                {
                    Id = 34,
                    Title = "Pokémon GO",
                    Description = "Augmented reality game where players catch Pokémon in the real world.",
                    Developer = "Niantic",
                    Rating = 5,
                    Category = "Games",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-InApp" },
                    Tags = new List<string> { "AR", "Adventure", "Exploration", "Pokemon" },
                    ImageUrl = "/images/apps/PokemonGo_Logo.jpeg"
                },
                new AppModel
                {
                    Id = 35,
                    Title = "TikTok",
                    Description = "TikTok is a short-form video platform where users can create, share, and discover entertaining content.",
                    Developer = "ByteDance Ltd.",
                    Rating = 4,
                    Category = "Social Networking",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads" },
                    Tags = new List<string> { "Videos", "Short-form", "Social", "Entertainment" },
                    ImageUrl = "/images/apps/TikTok_Logo.png"
                },

                new AppModel
                {
                    Id = 36,
                    Title = "Snapchat",
                    Description = "Snapchat lets users share photos and videos that disappear, along with messaging and stories.",
                    Developer = "Snap Inc.",
                    Rating = 4,
                    Category = "Social Networking",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads" },
                    Tags = new List<string> { "Messaging", "Photos", "Stories", "Filters" },
                    ImageUrl = "/images/apps/Snapchat_logo.png"
                },

                new AppModel
                {
                    Id = 37,
                    Title = "Twitter (X)",
                    Description = "X is a social media platform for sharing short messages, news, and engaging in public conversations.",
                    Developer = "X Corp.",
                    Rating = 4,
                    Category = "Social Networking",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads", "Paid-Premium" },
                    Tags = new List<string> { "Social", "News", "Microblogging", "Trends" },
                    ImageUrl = "/images/apps/Twitter_Logo.png"
                },

                new AppModel
                {
                    Id = 38,
                    Title = "Facebook",
                    Description = "Facebook connects people through posts, messaging, groups, and events.",
                    Developer = "Meta Platforms, Inc.",
                    Rating = 4,
                    Category = "Social Networking",
                    Type = new List<string> { "Apple", "Android", "Free", "Ads" },
                    Tags = new List<string> { "Social", "Posts", "Groups", "Events" },
                    ImageUrl = "/images/apps/Facebook_Logo.png"
                },

                new AppModel
                {
                    Id = 39,
                    Title = "Messenger",
                    Description = "Messenger allows users to send messages, make calls, and share media with friends.",
                    Developer = "Meta Platforms, Inc.",
                    Rating = 4,
                    Category = "Communication",
                    Type = new List<string> { "Apple", "Android", "Free" },
                    Tags = new List<string> { "Messaging", "Calls", "Chat", "Social" },
                    ImageUrl = "/images/apps/Messenger_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 40,
                    Title = "Zoom",
                    Description = "Zoom is a video conferencing app used for meetings, webinars, and online collaboration.",
                    Developer = "Zoom Video Communications, Inc.",
                    Rating = 4,
                    Category = "Business",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Meetings", "Video", "Conferencing", "Work" },
                    ImageUrl = "/images/apps/Zoom_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 41,
                    Title = "Microsoft Teams",
                    Description = "Microsoft Teams is a collaboration platform with chat, video meetings, and file sharing.",
                    Developer = "Microsoft Corporation",
                    Rating = 4,
                    Category = "Business",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Work", "Chat", "Meetings", "Collaboration" },
                    ImageUrl = "/images/apps/MicrosoftTeams_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 42,
                    Title = "Slack",
                    Description = "Slack is a team communication tool that organizes conversations into channels.",
                    Developer = "Slack Technologies, Inc.",
                    Rating = 4,
                    Category = "Productivity",
                    Type = new List<string> { "Apple", "Android", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Work", "Chat", "Teams", "Collaboration" },
                    ImageUrl = "/images/apps/Slack_Logo.png"
                },

                new AppModel
                {
                    Id = 43,
                    Title = "Notion",
                    Description = "Notion is an all-in-one workspace for notes, tasks, databases, and collaboration.",
                    Developer = "Notion Labs, Inc.",
                    Rating = 5,
                    Category = "Productivity",
                    Type = new List<string> { "Apple", "Android", "Web", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Notes", "Tasks", "Workspace", "Organization" },
                    ImageUrl = "/images/apps/Notion_Logo.png"
                },

                new AppModel
                {
                    Id = 44,
                    Title = "Evernote",
                    Description = "Evernote helps users capture notes, organize ideas, and manage tasks.",
                    Developer = "Evernote Corporation",
                    Rating = 4,
                    Category = "Productivity",
                    Type = new List<string> { "Apple", "Android", "Web", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Notes", "Organization", "Tasks", "Productivity" },
                    ImageUrl = "/images/apps/Evernote_Logo.png"
                },

                new AppModel
                {
                    Id = 45,
                    Title = "Dropbox",
                    Description = "Dropbox is a cloud storage service for file sharing and collaboration.",
                    Developer = "Dropbox, Inc.",
                    Rating = 4,
                    Category = "Productivity",
                    Type = new List<string> { "Apple", "Android", "Web", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Cloud", "Storage", "Files", "Sharing" },
                    ImageUrl = "/images/apps/Dropbox_Logo.png"
                },

                new AppModel
                {
                    Id = 46,
                    Title = "Google Drive",
                    Description = "Google Drive allows users to store, share, and collaborate on files in the cloud.",
                    Developer = "Google LLC",
                    Rating = 5,
                    Category = "Productivity",
                    Type = new List<string> { "Apple", "Android", "Web", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Cloud", "Storage", "Docs", "Collaboration" },
                    ImageUrl = "/images/apps/GoogleDrive_Logo.png"
                },

                new AppModel
                {
                    Id = 47,
                    Title = "Uber",
                    Description = "Uber connects riders with drivers for convenient transportation services.",
                    Developer = "Uber Technologies, Inc.",
                    Rating = 4,
                    Category = "Travel",
                    Type = new List<string> { "Apple", "Android", "Free" },
                    Tags = new List<string> { "Ride", "Transport", "Travel", "Taxi" },
                    ImageUrl = "/images/apps/Uber_Logo.png"
                },

                new AppModel
                {
                    Id = 48,
                    Title = "Airbnb",
                    Description = "Airbnb allows users to book unique accommodations and experiences around the world.",
                    Developer = "Airbnb, Inc.",
                    Rating = 4,
                    Category = "Travel",
                    Type = new List<string> { "Apple", "Android", "Free" },
                    Tags = new List<string> { "Travel", "Booking", "Stays", "Experiences" },
                    ImageUrl = "/images/apps/Airbnb_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 49,
                    Title = "DoorDash",
                    Description = "DoorDash is a food delivery service connecting users with local restaurants.",
                    Developer = "DoorDash, Inc.",
                    Rating = 4,
                    Category = "Food & Drink",
                    Type = new List<string> { "Apple", "Android", "Free" },
                    Tags = new List<string> { "Food", "Delivery", "Restaurants", "Takeout" },
                    ImageUrl = "/images/apps/DoorDash_Logo.png"
                },

                new AppModel
                {
                    Id = 50,
                    Title = "PayPal",
                    Description = "PayPal is a digital payment platform that allows users to send and receive money securely online.",
                    Developer = "PayPal, Inc.",
                    Rating = 4,
                    Category = "Finance",
                    Type = new List<string> { "Apple", "Android", "Web", "Free" },
                    Tags = new List<string> { "Payments", "Money", "Transfers", "Online" },
                    ImageUrl = "/images/apps/PayPal_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 51,
                    Title = "Cash App",
                    Description = "Cash App enables users to send money, invest in stocks, and buy Bitcoin easily.",
                    Developer = "Block, Inc.",
                    Rating = 4,
                    Category = "Finance",
                    Type = new List<string> { "Apple", "Android", "Free" },
                    Tags = new List<string> { "Payments", "Money", "Investing", "Crypto" },
                    ImageUrl = "/images/apps/CashApp_Logo.png"
                },

                new AppModel
                {
                    Id = 52,
                    Title = "Mint",
                    Description = "Mint helps users track spending, create budgets, and manage personal finances.",
                    Developer = "Intuit Inc.",
                    Rating = 4,
                    Category = "Finance",
                    Type = new List<string> { "Apple", "Android", "Web", "Free" },
                    Tags = new List<string> { "Budgeting", "Finance", "Tracking", "Money" },
                    ImageUrl = "/images/apps/Mint_Logo.jpeg"
                },

                new AppModel
                {
                    Id = 53,
                    Title = "Duolingo",
                    Description = "Duolingo is a language-learning app that uses gamified lessons to teach new languages.",
                    Developer = "Duolingo, Inc.",
                    Rating = 5,
                    Category = "Education",
                    Type = new List<string> { "Apple", "Android", "Web", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Languages", "Learning", "Education", "Practice" },
                    ImageUrl = "/images/apps/Duolingo_Logo.png"
                },

                new AppModel
                {
                    Id = 54,
                    Title = "Khan Academy",
                    Description = "Khan Academy provides free courses and lessons on a wide range of subjects.",
                    Developer = "Khan Academy",
                    Rating = 5,
                    Category = "Education",
                    Type = new List<string> { "Apple", "Android", "Web", "Free" },
                    Tags = new List<string> { "Learning", "Courses", "Education", "Math", "Science" },
                    ImageUrl = "/images/apps/KhanAcademy_Logo.png"
                },

                new AppModel
                {
                    Id = 55,
                    Title = "Coursera",
                    Description = "Coursera offers online courses, certifications, and degrees from top universities and companies.",
                    Developer = "Coursera, Inc.",
                    Rating = 4,
                    Category = "Education",
                    Type = new List<string> { "Apple", "Android", "Web", "Free", "Paid-Premium" },
                    Tags = new List<string> { "Courses", "Online Learning", "Certificates", "Education" },
                    ImageUrl = "/images/apps/Coursera_Logo.jpeg"
                }
                );
        }
    }
}
