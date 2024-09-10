using PresOrm.Data;
using PresOrm.Data.Repositories;

namespace PresOrm
{
    internal class ProcessShowBrands : AProcess
    {
        protected override string Message => "Show Brands";
        protected override string EndMessage => "Show Brands End";

        protected override void Process(ContextPresOrm context)
        {
            var repositoryBrand = new RepositoryBrand(context);

            foreach (var brand in repositoryBrand.GetAll())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(brand);
            }
        }
    }
}
