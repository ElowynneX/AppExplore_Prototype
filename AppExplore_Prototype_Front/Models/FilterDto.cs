namespace AppExplore_API_Prototype.Model
{
    public class FilterDto
    {
        public string SearchCategory { get; set; }
        public List<string> SearchType { get; set; }
        public List<string> SearchTags { get; set; }
    }
}
