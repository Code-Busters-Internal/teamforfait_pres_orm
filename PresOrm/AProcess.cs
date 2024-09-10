using Microsoft.EntityFrameworkCore;
using PresOrm.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresOrm
{

    internal abstract class AProcess
    {
        protected AProcess()
        {
        }

        protected abstract void Process(ContextPresOrm context);

        protected abstract string Message { get; }
        protected abstract string EndMessage { get; }

        public void Start(ContextPresOrm context)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Message);
            Process(context);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(EndMessage);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
