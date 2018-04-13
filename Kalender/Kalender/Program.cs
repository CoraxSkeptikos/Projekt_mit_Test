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
                    Schreibe_Kalender();
                }
            }
        }
        internal static void Schreibe_Kalender()
        {
            foreach (var item in Kalenderhintergrund.Starte_Kalender())
            {
                Console.WriteLine(item);
            }
        }
    }
}
