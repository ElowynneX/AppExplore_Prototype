namespace AppExplore_Prototype_Front.Services
{
    public class AppApiService
    {
        private readonly HttpClient _httpClient;

        public AppApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AppModel>> FilterAppsAsync(FilterDto filters)
        {
            filters.SearchType ??= new List<string>();
            filters.SearchTags ??= new List<string>();

            var response = await _httpClient.PostAsJsonAsync(
                "https://localhost:7157/api/App/filter",
                filters
            );

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"API Error: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<AppModel>>();
        }

        public async Task<AppModel> GetAppByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<AppModel>(
                $"https://localhost:7157/api/App/{id}"
            );
        }
    }
}
