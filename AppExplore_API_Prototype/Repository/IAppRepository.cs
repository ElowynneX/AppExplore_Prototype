using AppExplore_API_Prototype.Model;

namespace AppExplore_API_Prototype.Repository
{
    public interface IAppRepository
    {
        Task<List<AppModel>> GetAllApps();

        Task<List<AppModel>> GetFilteredApps(FilterDto filters);

        Task<List<AppModel>> GetKeywordApps(string keyword);

        Task<AppModel> GetAppById(int id);
    }
}
