using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stopwatch;
namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = true;
            while (exit)
            {

             Console.WriteLine("---------------------");
             Console.WriteLine("Pres 1 to start stopwatch");
             Console.WriteLine("Pres 2 to end stopwatch");
             Console.WriteLine("Pres 3 to Exit");
             Console.WriteLine("--------------------");
                var pickOption = int.Parse(Console.ReadLine());
               
             Stopwatch timer = new Stopwatch();

                if (pickOption == 1)
                {


                    timer.Start();

                }
                else if (pickOption == 2)
                {
                    timer.Stop();
                    //timer.DurationOfTime();
                }
                else exit = false;
         
            }

        }
    }
}
