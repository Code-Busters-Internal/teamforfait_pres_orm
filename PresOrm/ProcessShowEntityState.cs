using PresOrm.Data;

namespace PresOrm
{
    internal class ProcessShowEntityState : AProcess
    {
        protected override string Message => "ShowEntityState State";
        protected override string EndMessage => "ShowEntityState State End";

        protected override void Process(ContextPresOrm context)
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
