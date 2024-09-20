using Microsoft.EntityFrameworkCore;
using PresOrm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PresOrm.Data.Repositories
{
    public class RepositoryCar : AGenericRepository<EntityCar>
    {
        public RepositoryCar(DbContext db) : base(db)
        {
        }


        public List<EntityCar> GetCarsWithBrand()
        {
            return DbSet
                .AsNoTracking()
                .Include(e => e.Brand)
                .ToList();
        }



        public List<EntityCar> ExampleComplexe()
        {
            return DbSet
                .AsNoTracking()
                .Where(e => e.Brand.Name.StartsWith("M"))
                .OrderBy(e => e.Brand.Name)
                .ThenByDescending(e => e.ModelYear)
                .ToList();
        }
    }
}
