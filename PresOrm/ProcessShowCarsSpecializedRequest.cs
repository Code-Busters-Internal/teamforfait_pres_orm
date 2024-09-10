using PresOrm.Data;
using PresOrm.Data.Repositories;

namespace PresOrm
{
    internal class ProcessShowCarsSpecializedRequest : AProcess
    {
        protected override string Message => "ShowCarsSpecializedRequest";
        protected override string EndMessage => "ShowCarsSpecializedRequest End";

        protected override void Process(ContextPresOrm context)
        {
            var repositoryCar = new RepositoryCar(context);


            foreach (var car in repositoryCar.GetCarsWithBrand())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(car);
            }

        }
    }
}
