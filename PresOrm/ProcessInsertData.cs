using PresOrm.Data;
using PresOrm.Data.Repositories;
using PresOrm.Data.Services;

namespace PresOrm
{
    internal class ProcessInsertData : AProcess
    {
        protected override string Message => "Add some data in the db";
        protected override string EndMessage => "Data inserted !";

        protected override void Process(ContextPresOrm context)
        {
            var repositoryCar = new RepositoryCar(context);
            var repositoryBrand = new RepositoryBrand(context);
            var serviceInsert = new ServiceInsert(repositoryCar, repositoryBrand);

            serviceInsert.InsertTestData();
        }
    }
}
