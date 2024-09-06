using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsseseisevToo
{
    public static class Funct1
    {
        public static void Palidroom()
        {
            Console.WriteLine("kirjutage sõnu");
            string input = Console.ReadLine();

            // teisendan string väiketähtedeks ja eemaldan kõik märgid, välja arvatud tähed ja numbrid
            string cleanedInput = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());

            // puhastatud stringi võrdlemine selle ümberpööratud versiooniga
            bool isPalindrome = cleanedInput.SequenceEqual(cleanedInput.Reverse());

           
            if (isPalindrome)
            {
                Console.WriteLine("string on palindroom");
            }
            else
            {
                Console.WriteLine("String ei ole palindroom");
            }
        

        }
    }
}
