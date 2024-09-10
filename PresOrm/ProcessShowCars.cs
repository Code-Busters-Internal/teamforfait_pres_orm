using PresOrm.Data;
using PresOrm.Data.Repositories;

namespace PresOrm
{
    internal class ProcessShowCars : AProcess
    {
        protected override string Message => "Show Cars";
        protected override string EndMessage => "Show Cars End";

        protected override void Process(ContextPresOrm context)
        {
            var repositoryCar = new RepositoryCar(context);


            foreach (var car in repositoryCar.GetAll())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(car);
            }
        }
    }
}
