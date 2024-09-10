using PresOrm.Data.Entities;
using PresOrm.Data.Repositories;

namespace PresOrm.Data.Services
{
    public class ServiceInsert
    {
        private readonly RepositoryCar _repositoryCar;
        private readonly RepositoryBrand _repositoryBrand;

        public ServiceInsert(RepositoryCar repositoryCar, RepositoryBrand repositoryBrand)
        {
            _repositoryCar = repositoryCar;
            _repositoryBrand = repositoryBrand;
        }

        public void InsertTestData()
        {
            EntityBrand b1 = new EntityBrand { Name = "Mercedas" };
            EntityBrand b2 = new EntityBrand { Name = "Rezeau" };
            EntityBrand b3 = new EntityBrand { Name = "Peugit" };

            _repositoryBrand.Create(b1);
            _repositoryBrand.Create(b2);
            _repositoryBrand.Create(b3);

            EntityCar b1c1 = new EntityCar { Name = "M15", ModelYear = new DateOnly(1975, 5, 6), Brand = b1 };
            EntityCar b1c2 = new EntityCar { Name = "M16", ModelYear = new DateOnly(1985, 7, 6), Brand = b1 };
            EntityCar b1c3 = new EntityCar { Name = "M17", ModelYear = new DateOnly(1995, 8, 6), Brand = b1 };

            _repositoryCar.Create(b1c1);
            _repositoryCar.Create(b1c2);
            _repositoryCar.Create(b1c3);

            EntityCar b2c1 = new EntityCar { Name = "Clia", ModelYear = new DateOnly(1976, 5, 1), Brand = b2 };
            EntityCar b2c2 = new EntityCar { Name = "Megana", ModelYear = new DateOnly(1986, 3, 16), Brand = b2 };
            EntityCar b2c3 = new EntityCar { Name = "Mariana", ModelYear = new DateOnly(1996, 7, 2), Brand = b2 };
            EntityCar b2c4 = new EntityCar { Name = "Lisa", ModelYear = new DateOnly(2006, 12, 3), Brand = b2 };
            EntityCar b2c5 = new EntityCar { Name = "Aria", ModelYear = new DateOnly(2016, 8, 26), Brand = b2 };

            _repositoryCar.Create(b2c1);
            _repositoryCar.Create(b2c2);
            _repositoryCar.Create(b2c3);
            _repositoryCar.Create(b2c4);
            _repositoryCar.Create(b2c5);

            EntityCar b3c1 = new EntityCar { Name = "C1", ModelYear = new DateOnly(1981, 3, 26), Brand = b3 };
            EntityCar b3c2 = new EntityCar { Name = "C2", ModelYear = new DateOnly(1991, 5, 16), Brand = b3 };
            EntityCar b3c3 = new EntityCar { Name = "C3", ModelYear = new DateOnly(2001, 2, 15), Brand = b3 };
            EntityCar b3c4 = new EntityCar { Name = "C4", ModelYear = new DateOnly(2011, 11, 23), Brand = b3 };

            _repositoryCar.Create(b3c1);
            _repositoryCar.Create(b3c2);
            _repositoryCar.Create(b3c3);
            _repositoryCar.Create(b3c4);
        }
    }
}
