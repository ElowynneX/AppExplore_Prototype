using AppExplore_API_Prototype.Data;
using AppExplore_API_Prototype.Model;
using Microsoft.EntityFrameworkCore;

namespace AppExplore_API_Prototype.Repository
{
    public class AppRepository : IAppRepository
    {
        private readonly AppDbContext _appDbContext;

        public AppRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<AppModel>> GetAllApps()
        {
            return await _appDbContext.Apps.ToListAsync();
        }

        public async Task<AppModel> GetAppById(int id)
        {
            return await _appDbContext.Apps.FindAsync(id);
        }

        public async Task<List<AppModel>> GetFilteredApps(FilterDto filters)
        {
            IQueryable<AppModel> query = _appDbContext.Apps;

            // Filter by Category
            if (!string.IsNullOrWhiteSpace(filters.SearchCategory))
            {
                query = query.Where(a => a.Category == filters.SearchCategory);
            }

            // Filter by Type (List<string>)
            if (filters.SearchType != null && filters.SearchType.Any())
            {
                query = query.Where(a =>
                    a.Type.Any(t => filters.SearchType.Contains(t))
                );
            }

            // Filter by Tags (List<string>)
            if (filters.SearchTags != null && filters.SearchTags.Any())
            {
                query = query.Where(a =>
                    a.Tags.Any(tag => filters.SearchTags.Contains(tag))
                );
            }

            return await query.ToListAsync();
        }

        public async Task<List<AppModel>> GetKeywordApps(string keyword)
        {
            keyword = keyword.Trim().ToLower();

            return await _appDbContext.Apps
                .Where(app =>
                    app.Title.ToLower().Contains(keyword) ||
                    app.Description.ToLower().Contains(keyword) ||
                    app.Developer.ToLower().Contains(keyword) ||
                    app.Category.ToLower().Contains(keyword) ||
                    app.Tags.Any(t => t.ToLower().Contains(keyword)) ||
                    app.Type.Any(t => t.ToLower().Contains(keyword))
                )
                .ToListAsync();
        }
    }
}
