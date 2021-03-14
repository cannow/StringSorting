using System;
using System.Threading.Tasks;

namespace StringOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alright so first let's have you type in a sentence, then I'll reverse the letters but not the word order...\n");
            string pangram = Console.ReadLine();
            LetterReversal(pangram);
            
            Console.WriteLine("\n\nAin't that neat?\nOk this here's a two parter, first type in a list of things seperated by a comma...\n");
            string orderStream = Console.ReadLine();
            string[] orders = orderStream.Split(',');
            OrderFinder(orders);

            Console.WriteLine("Fun stuff huh? Okay this is the last one, and it's another two parter.\nFirst let's have you write two expressions, then I'll:\n\t1) Add them together\n\t2) Sort it alphabetically\n\t3) Get rid of any duplicate characters you've typed!\nFirst expression...");
            string alphA = Console.ReadLine();
            Console.WriteLine("Now second...");
            string alphB = Console.ReadLine();
            Alphabatizer(alphA, alphB);

            Console.WriteLine("Okay it's over, press enter to exit");
            Console.ReadLine();
        }

        public static string LetterReversal(string sentence)
        {
            string[] words = sentence.Split();
            string output = "";

            foreach(var word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                output += letters;

                Console.Write(letters);
                Console.Write(" ");
            }

            return output;
        }

        public static string OrderFinder(string[] orders)
        {
            string output = "";

            Console.WriteLine("\nAwesome now type in what you'd like to search for in that list you just typed:\n");
            string searchItem = Console.ReadLine();
            byte foundCount = 0;

            foreach(var order in orders)
            {
                if(order.Contains(searchItem))
                {
                    output += $"Found : {order}\n";
                    foundCount++;
                }
            }
            
            Console.WriteLine(foundCount == 0  || searchItem == "" ? "\nWow we found nothing!\n" : $"\n{output.Trim(' ')}\n");
            return output;
        }

        public static string Alphabatizer(string s1, string s2)
        {
            char[] letters = (string.Concat(s2, s1)).ToCharArray();
            Array.Sort(letters);
            string output = "";

            foreach (var letter in letters)
            {
                if (!output.Contains(letter))
                {
                    output += letter;
                }
            }

            Console.WriteLine($"\n{output.Trim(' ')}");
            return output;
        }

    }
}
