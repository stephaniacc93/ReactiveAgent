using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ReactiveAgent.Console
{
    class Program
    {
        private static double time = 100;

        static void Main(string[] args)
        {
            System.Console.WriteLine("Contesta las siguientes preguntas:");

            while (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                Operation operation = ReactiveAgent.GetOperation(time);
                System.Console.WriteLine(operation.OperationE);
                stopwatch.Start();
                var response = System.Console.ReadLine();
                stopwatch.Stop();
                if (response == operation.Result)
                    time = stopwatch.Elapsed.Seconds;
                else
                    time = 100;
            }

        }
    }
}
