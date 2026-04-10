using System;
using System.Collections.Generic;

namespace CSharp_Assignment_7
{
    internal class start_end_word
    {
        public static void word_check()
        {
            List<string> words = new List<string>();

            Console.Write("Enter number of words: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                words.Add(Console.ReadLine());
            }

            Console.WriteLine("\nWords starting with 'a' and ending with 'm':");
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    char firstChar = word[0];
                    char lastChar = word[word.Length - 1];

                    if (firstChar == 'a' && lastChar == 'm')
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}