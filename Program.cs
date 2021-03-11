using System;

namespace StringOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick and also brown fox jumped over the lazy bones doggie dog";
            string[] words = pangram.Split();

            foreach(var word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);
                Console.Write(letters);
                Console.Write(" ");
            }

            Console.Write("\n");

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] orders = orderStream.Split(',');

            foreach(var order in orders)
            {
                if(order.Contains("B"))
                {
                    Console.WriteLine(order);
                }
            }

            Longest("aabbccddeeffgghhiijjkkllmmnnoopp", "qqrrssttuuvvwwxxyyzzakfs");
        }
        public static string Longest(string s1, string s2)
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

            Console.WriteLine(output);
            return output;
        }
    }
}
