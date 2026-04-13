namespace AppExplore_Prototype_Front.Models
{
    public static class AppTagDictionary
    {
        public static readonly Dictionary<string, List<string>> CategoryTags = new()
        {
            ["Music"] = new List<string>
        {
            "Music", "Streaming", "Podcasts", "Playlists", "Live Performances",
            "Radio", "Indie", "Creators", "HiFi", "Exclusive", "Artists",
            "Personalized", "Alexa", "Library", "Uploads"
        },

            ["Social Networking"] = new List<string>
        {
            "Photos", "Videos", "Stories", "Social Media",
            "Messaging", "Calls", "Video", "Encryption",
            "Chat", "Social", "Posts", "Groups", "Events",
            "News", "Trends", "Microblogging", "Filters"
        },

            ["Navigation"] = new List<string>
        {
            "Maps", "GPS", "Traffic", "Directions"
        },

            ["Entertainment"] = new List<string>
        {
            "Movies", "TV Shows", "Streaming", "Originals"
        },

            ["Health and Fitness"] = new List<string>
        {
            "Health", "Fitness", "Tracker"
        },

            ["Communication"] = new List<string>
        {
            "Messaging", "Calls", "Video", "Chat", "Social"
        },

            ["Productivity"] = new List<string>
        {
            "Automation", "Workflows", "Customization",
            "Work", "Teams", "Collaboration",
            "Notes", "Tasks", "Workspace", "Organization",
            "Cloud", "Storage", "Files", "Sharing", "Docs"
        },

            ["Games"] = new List<string>
        {
            "Strategy", "Multiplayer", "Base Building", "War",
            "Cards", "PvP", "Puzzle", "Casual", "Match-3",
            "Levels", "Shooter", "FPS", "Battle Royale",
            "Survival", "Runner", "Endless", "Arcade",
            "Adventure", "Sandbox", "User-Generated",
            "Building", "Open World", "Anime", "Action",
            "Arena", "Competitive", "Sports", "Pool",
            "Racing", "Physics", "Driving", "Tower Defense",
            "Zombies", "Board", "AR", "Exploration",
            "Pokemon", "Party", "Deduction"
        },

            ["Business"] = new List<string>
        {
            "Work", "Meetings", "Video", "Conferencing", "Collaboration"
        },

            ["Travel"] = new List<string>
        {
            "Ride", "Transport", "Travel", "Taxi",
            "Booking", "Stays", "Experiences"
        },

            ["Food and Drink"] = new List<string>
        {
            "Food", "Delivery", "Restaurants", "Takeout"
        },

            ["Finance"] = new List<string>
        {
            "Payments", "Money", "Transfers", "Online",
            "Investing", "Crypto", "Budgeting", "Tracking"
        },

            ["Education"] = new List<string>
        {
            "Languages", "Learning", "Education", "Practice",
            "Courses", "Online Learning", "Certificates",
            "Math", "Science"
        }
        };
    }
}
