namespace AppExplore_API_Prototype.Model
{
    public class AppModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public int Rating { get; set; }
        public string Category { get; set; }
        public List<string> Type { get; set; }
        public List<string> Tags { get; set; }

        public string ImageUrl { get; set; }

        //Constructors
        public AppModel() { }

        public AppModel(string _title, string _description, string _developer, int _rating, string _category, List<string> _type, List<string> _tags)
        {
            Title = _title;
            Description = _description;
            Developer = _developer;
            Rating = _rating;
            Category = _category;
            Type = _type;
            Tags = _tags;
        }
    }
}
