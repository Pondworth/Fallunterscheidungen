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
            //Ende der If-Abfragen

            //Ein Boolescher Ausdruck kann nur die Werte True oder False ausgeben. 
            //bool bedingung1 = (10 > 5);
            //Vergleichsoperatoren
            //      <       (Kleiner als)           (2 < 4)                         true
            //      >       (Größer als)            (3 > 1)                         true
            //      <=      (Kleiner/Gleich als)    (3 <= 3)                        true
            //      >=      (Größer/Gleich als)     (2 >= 1)                        true
            //      ==      (Gleich wie)            (4 == 4)                        true
            //      !=      (Ungleich wie)          (4 != 8)                        true
            //Logische -/ Verknüpfungsoperatoren
            //      &&      Und                     ((20 > 3) && (10 == 10))        true, true = true
            //      ||      Oder                    ((10 > 20) || (2 != 3))         false, true = true
            //      !       Nicht                   ! ((20 > 3) && (10 == 10))      true, true = false

            int alter = 18;
            bool mobil = true;
            bool qualifiziert = true;
            bool test = false;
            bool schüchtern = false;

            //if ((alter >= 18) && (mobil == true) && (qualifiziert == true || test == true) && (schüchtern == false))
            //Folgendes entspricht dem oberen Code
            if ((alter >= 18) && (mobil) && (qualifiziert || test) && (! schüchtern))
            {
                Console.WriteLine("Du bekommst die Aufgabe!");
            }
            else
            {
                Console.WriteLine("Du bekommst die Aufgabe leider nicht!");
            }

            //Switch-Blöcke ermöglichen die Prüfungen einer Variable mit einer Reihe an Werten
            //Jedem Wert wird ein Case zugewiesen, der die Variablen mit dem dazugehörigen Wert ausführt

            Console.Write("Command: ");
            string command = Console.ReadLine();

            switch(command)
            {
                case "SayHello":
                    Console.WriteLine("Hallo!");
                    break;
                case "GoodBye":
                    Console.WriteLine("Auf Wiedersehen!");
                    break;
                case "Smile":
                    Console.WriteLine(":-)");
                    break;
                default:
                    Console.WriteLine("Ungültiger Befehl!");
                    break;
            }
            Console.ReadKey();  
        }
    }
}
