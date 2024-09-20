using Microsoft.EntityFrameworkCore;
using PresOrm.Data.Entities;

namespace PresOrm.Data.Repositories
{
    public class RepositoryBrand : AGenericRepository<EntityBrand>
    {
        public RepositoryBrand(DbContext db) : base(db)
        {
        }

        public EntityBrand? GetByName(string name)
        {
            return DbSet.FirstOrDefault(e => e.Name== name);
        }
    }
}
