using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fallunterscheidungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If Abfragen ermöglichen es einen CodeBlock zu bestimmten Bedingungen auszuführen, das bedeutet Kontrolle

            int age = 12;
            bool withParents = false;

            if (age >= 18)
            {
                Console.WriteLine("Du darfst den Film sehen!");
            }
            else if (withParents == true)
            {
                Console.WriteLine("Du darfst den Film nur sehen, weil deine Eltern dabei sind!");
            }
            else
            {
                Console.WriteLine("Du darfst den Film nicht sehen!");
            }

            Console.ReadKey();  
        }
    }
}
