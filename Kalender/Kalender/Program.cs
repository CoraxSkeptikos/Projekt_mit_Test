using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalenderbibliothek;

namespace Kalender
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (Console.ReadLine().Contains("cal"))
                {
                    Kalenderhintergrund.Starte_Kalender().ForEach(Console.WriteLine);
                }
            }
        }
    }
}
