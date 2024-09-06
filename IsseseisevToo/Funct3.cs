using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsseseisevToo
{
    public static class Funct3
    {
        public static void JarjekordString()
        {
           
            Console.Write("kirjutage sõnu");
            string input = Console.ReadLine();

           
            char[] symbolid = input.ToCharArray();
            Array.Sort(symbolid);

    
            string sortedString = new string(symbolid);

            Array.Reverse(symbolid);

           
            string reversedString = new string(symbolid);


            Console.WriteLine("Sorteeritud string " + sortedString);
            Console.WriteLine("Uus rida vastupidises järjekorras " + reversedString);
        }
    }
}
