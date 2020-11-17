using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparese.Luay
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat;
            if (!int.TryParse(Console.ReadLine(), out resultat))
                Console.WriteLine("Skriv en siffra");



        }

        public static bool TryParse(string s, out int result)
        {
            try
            {
                result = int.Parse(s);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }



        }
    }
}
