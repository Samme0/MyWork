using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Assignment6WebApp.ViewFunctions.Home
{
    public class HomeViewFunctions
    {
        public static List<string> LoadSentences (string filePath)
        {
            if (File.Exists(filePath))
            {
                return new List<string>(File.ReadAllLines(filePath));
            }
            return new List<string>();
        }
        public static List<String> SortSentencesAscending(List<string> sentences)
        {
            return sentences.OrderBy(s => s).ToList();
        }
        public static List<string> SortSentencesDescending(List<string> Sentences)
        {
            return Sentences.OrderByDescending(s => s).ToList();
        }
    }
}
