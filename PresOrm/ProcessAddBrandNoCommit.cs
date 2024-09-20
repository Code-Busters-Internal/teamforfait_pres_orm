using Castle.Components.DictionaryAdapter.Xml;
using PresOrm.Data;
using PresOrm.Data.Repositories;

namespace PresOrm
{
    internal class ProcessAddBrandNoCommit : AProcess
    {
        protected override string Message => "AddBrandNoCommit State";
        protected override string EndMessage => "AddBrandNoCommit State End";

        protected override void Process(ContextPresOrm context)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Add a brand");

            var repositoryBrand = new RepositoryBrand(context);
            var entity = new Data.Entities.EntityBrand { Name = "Tesloo" };
            repositoryBrand.Add(entity);
            ShowState(context);

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Save context");

            context.SaveChanges();
            ShowState(context);

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("modify entity");

            entity.Name = "Tesluu";
            ShowState(context);


            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("read again: its not a cache");

            var e =   repositoryBrand.GetByName("Tesluu");
            if(e==null)
            Console.WriteLine("entity is null ");
            Console.ReadKey();

        }


        protected   void ShowState(ContextPresOrm context)
        {
            // var repositoryBrand = new RepositoryBrand(context);

            foreach (var entry in context.ChangeTracker.Entries())
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(entry.Entity);
                Console.WriteLine(entry.State);
            }
        }
    }
}
