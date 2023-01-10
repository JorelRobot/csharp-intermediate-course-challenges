using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpIntermediateChallenges.ClassesChallenges
{
    public class Stopwatch
    {
        private bool isStopped = true;
        private TimeSpan initialTime;
        private TimeSpan finalTime;

        public void Start()
        {
            if (!isStopped)
            {
                throw new InvalidOperationException("Cannot start the stopwatch again, it's already started");
            }

            initialTime = DateTime.Now.TimeOfDay;
            isStopped = false;

            System.Console.WriteLine("\n");
            System.Console.WriteLine("\t\t -------------------------");
            System.Console.WriteLine("\t\t|    Stopwatch started    |");
            System.Console.WriteLine("\t\t -------------------------");
            System.Console.WriteLine("\n\n");
        }

        public void Stop()
        {
            if (isStopped)
            {
                throw new InvalidOperationException("Cannot stop the stopwatch again, it's already stopped");
            }

            finalTime = DateTime.Now.TimeOfDay;
            isStopped = true;

            System.Console.WriteLine("\n");
            System.Console.WriteLine("\t\t -------------------------");
            System.Console.WriteLine("\t\t|    Stopwatch stopped    |");
            System.Console.WriteLine("\t\t -------------------------");

            Console.WriteLine("\t\t     Time Transcurred");
            Console.WriteLine("\t\t     " + (finalTime - initialTime).ToString());
            System.Console.WriteLine("\n\n");
        }

        public static void RunProgram()
        {
            Stopwatch sw = new Stopwatch();
            int opc = -1;

            System.Console.WriteLine("\n\n\t\t\t .: STOPWATCH :.");
            System.Console.WriteLine();

            do
            {
                System.Console.WriteLine("[1] Start stopwatch");
                System.Console.WriteLine("[2] Stop stopwatch");
                System.Console.WriteLine("[0] Exit");
                System.Console.Write("option > ");
                opc = Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine();
                System.Console.WriteLine();

                switch (opc)
                {
                    case 1:
                        sw.Start();
                        break;
                    case 2:
                        sw.Stop();
                        break;
                    case 0:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\t\t|      See you!!! :D      |");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\n\n");
                        break;
                    default:
                        System.Console.WriteLine("\n");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\t\t|    Invalid Option!!!    |");
                        System.Console.WriteLine("\t\t -------------------------");
                        System.Console.WriteLine("\n\n");
                        break;
                }
            } while (opc != 0);
        }
    }
}