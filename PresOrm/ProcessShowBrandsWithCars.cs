using PresOrm.Data;
using PresOrm.Data.Repositories;

namespace PresOrm
{
    internal class ProcessShowBrandsWithCars : AProcess
    {
        protected override string Message => "ProcessShowBrandsWithCars";
        protected override string EndMessage => "ProcessShowBrandsWithCars End";

        protected override void Process(ContextPresOrm context)
        {
            var repositoryBrand = new RepositoryBrand(context);

            var listBrand = repositoryBrand.GetAll().ToList();
            foreach (var brand in listBrand)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(brand);
                foreach (var car in brand.Cars)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(car);
                }
            }
        }
    }
}
