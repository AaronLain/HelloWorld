using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        private static int SyllableCount(string word)
        {
            word = word.ToLower().Trim();
            bool lastWasVowel = false;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            int count = 0;

            //a string is an IEnumerable<char>; convenient.
            foreach (var c in word)
            {
                if (vowels.Contains(c))
                {
                    if (!lastWasVowel)
                        count++;
                    lastWasVowel = true;
                }
                else
                    lastWasVowel = false;
            }

            if ((word.EndsWith("e") || (word.EndsWith("es") || word.EndsWith("ed")))
                  && !word.EndsWith("le"))
                count--;

            return count;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo response;
            Console.WriteLine("Howdy Y'all!!");
            Console.WriteLine("Pick a new Greeting:");
            Console.WriteLine("1 = Millenial");
            Console.WriteLine("2 = Boomer");
            Console.WriteLine("3 = Southern");
            response = Console.ReadKey();
            
            if (response.KeyChar == '1')
            {
                Console.WriteLine("Suh Dude");
            }
            else if (response.KeyChar == '2')
            {
                Console.WriteLine("Hey there Chuck, you old so-and-so, how's the wife and kids");
            }
            else if (response.KeyChar == '3')
            {
                Console.WriteLine("Howdy Y'all!");
            }

            Console.WriteLine("Now here are some animals with 3 or more syllables in their name!");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Lioness", "Penguin", "Anteater" };
            

            foreach (var animal in animals)
            {
                var syllableCount = SyllableCount(animal);
                if (syllableCount >= 3)
                {
                    Console.WriteLine(animal);
                }
                
            }
        }
    }
}
