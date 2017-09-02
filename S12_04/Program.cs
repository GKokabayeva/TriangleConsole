using System;
using System.Threading;

namespace S12_04
{
    class IncorrectTriangleSideValueException : Exception
    {
        public IncorrectTriangleSideValueException(string message)
            : base(message)
        {
        }
    }
    class SomethingBadHappenedException : Exception
    {
        public void WriteException()
        {
            Console.WriteLine("\nYou must be a drunk user!");
            Thread.Sleep(3000);
            Console.WriteLine("\nGood bye!");
            Thread.Sleep(2200);
            Environment.Exit(0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThis program calculates an area and a perimeter of a triangle in centimeters");
            Console.ForegroundColor = ConsoleColor.Gray;

            bool flag = true;

            while (flag)
            {
                Triangle triangle = new Triangle();
                triangle.CheckForTriangularity();

                Console.Write("\nDo you want to try again? (Press 'y' for yes) ");

                string key = Console.ReadLine();

                switch (key)
                {
                    case "y":
                    case "Y":
                        continue;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }

            Console.Read();
            }
        }
    }
