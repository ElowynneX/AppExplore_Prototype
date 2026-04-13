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

        /*
        public async Task<List<AppModel>> GetFilteredApps(FilterDto filters)
        {
            var apps = await _appDbContext.Apps.ToListAsync();

            // Category
            if (!string.IsNullOrWhiteSpace(filters.SearchCategory))
            {
                apps = apps
                    .Where(a => a.Category == filters.SearchCategory)
                    .ToList();
            }

            // Type
            if (filters.SearchType?.Any() == true)
            {
                apps = apps
                    //.Where(a => a.Type.All(t => filters.SearchType.Contains(t)))
                    .Where(a => a.Type.Any(t => filters.SearchType.Contains(t)))
                    .ToList();
            }

            // Tags
            if (filters.SearchTags?.Any() == true)
            {
                apps = apps
                    //.Where(a => a.Tags.All(tag => filters.SearchTags.Contains(tag)))
                    .Where(a => a.Tags.Any(tag => filters.SearchTags.Contains(tag)))
                    .ToList();
            }

            return apps;
        }
        */
        public async Task<List<AppModel>> GetFilteredApps(FilterDto filters)
        {
            IQueryable<AppModel> query = _appDbContext.Apps;

            // -------------------------
            // STEP 1: CATEGORY (SQL SAFE)
            // -------------------------
            if (!string.IsNullOrWhiteSpace(filters.SearchCategory))
            {
                query = query.Where(a => a.Category == filters.SearchCategory);
            }

            var apps = await query.ToListAsync(); // 👈 switch to memory here

            // -------------------------
            // STEP 2: STRICT FILTER (memory-safe)
            // -------------------------
            var strict = apps;

            if (filters.SearchType?.Any() == true)
            {
                strict = strict
                    .Where(a => filters.SearchType.All(t => a.Type.Contains(t)))
                    .ToList();
            }

            if (filters.SearchTags?.Any() == true)
            {
                strict = strict
                    .Where(a => filters.SearchTags.All(t => a.Tags.Contains(t)))
                    .ToList();
            }

            if (strict.Any())
                return strict;

            // -------------------------
            // STEP 3: FALLBACK FILTER
            // -------------------------
            var fallback = apps;

            if (filters.SearchType?.Any() == true)
            {
                fallback = fallback
                    .Where(a => a.Type.Any(t => filters.SearchType.Contains(t)))
                    .ToList();
            }

            if (filters.SearchTags?.Any() == true)
            {
                fallback = fallback
                    .Where(a => a.Tags.Any(t => filters.SearchTags.Contains(t)))
                    .ToList();
            }

            return fallback;
        }

        public async Task<List<AppModel>> GetKeywordApps(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return await _appDbContext.Apps.ToListAsync();

            keyword = keyword.ToLower();

            var apps = await _appDbContext.Apps.ToListAsync(); // pull all apps into memory

            return apps.Where(app =>
                (app.Title != null && app.Title.ToLower().Contains(keyword)) ||
                (app.Description != null && app.Description.ToLower().Contains(keyword)) ||
                (app.Developer != null && app.Developer.ToLower().Contains(keyword)) //||
                //(app.Category != null && app.Category.ToLower().Contains(keyword)) ||
                //(app.Tags != null && app.Tags.Any(tag => tag.ToLower().Contains(keyword))) ||
                //(app.Type != null && app.Type.Any(t => t.ToLower().Contains(keyword)))
            ).ToList();
        }
    }
}
