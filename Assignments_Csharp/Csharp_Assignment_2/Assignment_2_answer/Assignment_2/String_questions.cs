using System;

namespace Assignment_2
{
    internal class String_questions
    {
        public static void Run()
        {
            //1.Length of word
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length = " + word.Length);

            //2.Reverse the word
            string reverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse = reverse + word[i];
            }

            Console.WriteLine("Reverse = " + reverse);

            //3.Compare two words
            Console.Write("\nEnter first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
            {
                Console.WriteLine("Both words are same");
            }
            else
            {
                Console.WriteLine("Words are different");
            }
        }
    }
}