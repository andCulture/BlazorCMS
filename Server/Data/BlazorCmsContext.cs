using Microsoft.EntityFrameworkCore;
using BlazorCMS.Server.Data.Models;

namespace BlazorCMS.Server.Data
{
    public class BlazorCmsContext : DbContext
    {
        #region Constructor

        public BlazorCmsContext(DbContextOptions<BlazorCmsContext> options) : base(options)
        {
        }

        #endregion Constructor

        #region Entities

        public DbSet<Article> Articles { get; set; }
        public DbSet<Section> Sections { get; set; }

        #endregion Entities

        #region Helper Methods

        public void Delete<T>(T entity) where T : class
        {
            var set = base.Set<T>();
            set.Remove(entity);
        }

        #endregion Helper Methods
    }
}
