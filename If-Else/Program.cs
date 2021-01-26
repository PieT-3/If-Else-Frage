using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        /*
         * Programmname: If-Else
         * Autor: Tabea Pieper
         * 
         * Frage: Was ist der Unterschied zwischen if-else und nur if?
         * 
         */
        static void Main(string[] args)
        {
            // Variable zahl deklarieren und initialisieren
            int zahl = -1;

            //if-else-Konstrukt, wo beide Abfragen gleich sind.
            if (zahl <= 0)
            {
                Console.WriteLine("if_1");
            }
            else if (zahl <= 0)
            {
                Console.WriteLine("else if_1");
            }
            else Console.WriteLine("Error");


            // Zwei If-Statements, wo beide Abfragen gleich sind.
            if (zahl <= 0)
            {
                Console.WriteLine("if_2.1");
            }
            if (zahl <= 0)
            {
                Console.WriteLine("if_2.2");
            }

            // Ausgabe:
            // if_1
            // if_2.1
            // if_2.2

            /* Antwort: Bei mehreren If-Anweisungen nacheinander, wird jede If-Anweisung ausgewertet
             * und ggf. der Ausführungsblock ausgeführt.
             * Bei einem If-Else-Konstrukt wird der erste wahre Ausdruck ausgeführt und dann der "Block"
             * verlassen. Alle nachstehenden Zweige werden NICHT durchlaufen!
             */


        }
    }
}
