using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using SentenceBackend.Models;

namespace SentenceBackend
{
    public class Helpers
    {
        public static List<string> GetWords(string fileName)
        {
            string filePath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            List<string> words = new List<string>();
            string line;

            StreamReader reader = new StreamReader($@"{filePath}\\App_Data\\InitialData\\{fileName}");
            while ((line = reader.ReadLine()) != null)
            {
                words.Add(line);
            }

            return words;
        }

        public static List<WordList> CompileListForInsert(List<string> words, WordTypes type)
        {
            List<WordList> wordlist = new List<WordList>();
            foreach (var word in words)
            {
                wordlist.Add(new WordList()
                {
                    Word = word,
                    WordType = Enum.GetName(typeof(WordTypes), type)
                });
            }

            return wordlist;
        }
    }
}