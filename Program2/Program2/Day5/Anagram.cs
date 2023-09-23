using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Day5
{

class AnagramFinder
    {
        static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int[] charCount = new int[128]; // Assuming only lowercase alphabetical characters

            for (int i = 0; i < str1.Length; i++)
            {
                charCount[str1[i]]++;
                charCount[str2[i]]--;
            }

            foreach (int count in charCount)
            {
                if (count != 0)
                    return false;
            }

            return true;
        }

        public static void run()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<List<string>> anagramGroups = new List<List<string>>();

            foreach (string word in words)
            {
                bool addedToGroup = false;

                foreach (List<string> group in anagramGroups)
                {
                    if (group.All(w => AreAnagrams(w, word)))
                    {
                        group.Add(word);
                        addedToGroup = true;
                        break;
                    }
                }

                if (!addedToGroup)
                {
                    anagramGroups.Add(new List<string> { word });
                }
            }

            Console.WriteLine("Anagrams found:");
            foreach (List<string> group in anagramGroups)
            {
                if (group.Count > 1)
                {
                    Console.WriteLine(string.Join(", ", group));
                }
            }
        }
    }

}

