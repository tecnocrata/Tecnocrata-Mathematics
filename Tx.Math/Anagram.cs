using System.Collections.Generic;

namespace Tx.Math.Combinatory
{
    public static class Anagram
    {
        private static List<string> Evaluate(string word)
        {
            List<string> result = new List<string>();
            result = MakeAnagrams(word);
            return result;
        }

        public static List<string> MakeAnagrams(string word)
        {
            List<string> result = new List<string>();
            if (word.Length==1)
            {
                result.Add(word);
                return result;
            }

            for (int i = 0; i < word.Length; i++)
            {
                List<string> anagrams = MakeAnagrams(word.Remove(i, 1));
                for (int j = 0; j < anagrams.Count; j++)
                {
                    anagrams[j] = word.Substring(i, 1) + anagrams[j];
                }
                result.AddRange(anagrams);
            }

            return result;
        }

        private static string ExtractCharacterFrom(string word, int i)
        {
            return word.Remove(i, 1);
        }
    }
}