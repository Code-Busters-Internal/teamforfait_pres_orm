//
// Nicolas Anderlini
// 10 septembre 2024
//
// Projet: Presentation des ORM
// Team Forfait Codebusters
//

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using PresOrm;
using PresOrm.Data;
using PresOrm.Data.Repositories;
using PresOrm.Data.Services;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("EF with QDBIW Quick And Dirty But It Works");

var context = new FactoryDatabaseContext().CreateDbContext(null);
var contextLazy = new FactoryDatabaseContext().CreateDbContext(new string[0]);

bool stop = false;
while (!stop)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Options:");
    Console.WriteLine("R - Reset DB");
    Console.WriteLine("I - Insert Data");
    Console.WriteLine("C - Clear contexts");
    Console.WriteLine("X - Show Cars");
    Console.WriteLine("B - Show Brands");
    Console.WriteLine("N - Show Brands with cars");
    Console.WriteLine("V - Show Cars specialised");
    Console.Write("Enter option: ");

    var key = Console.ReadKey();
    Console.Clear();
    try
    {
        switch (key.Key)
        {
            case ConsoleKey.R:
                new ProcessResetDb().Start(contextLazy);
                break;

            case ConsoleKey.C:
                context.ChangeTracker.Clear();
                contextLazy.ChangeTracker.Clear();
                break;

            case ConsoleKey.I:
                new ProcessInsertData().Start(contextLazy);
                break;

            case ConsoleKey.B:
                new ProcessShowBrands().Start(contextLazy);
                break;

            case ConsoleKey.X:
                new ProcessShowCars().Start(contextLazy);
                break;

            case ConsoleKey.N:
                new ProcessShowBrandsWithCars().Start(contextLazy);
                break;

            case ConsoleKey.V:
                new ProcessShowCarsSpecializedRequest().Start(context);
                break;

            case ConsoleKey.Escape:
                stop = true;
                break;
        }
    }
    catch (Exception ex) { Console.WriteLine(ex.ToString()); }
}



