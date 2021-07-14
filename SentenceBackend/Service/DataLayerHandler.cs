using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using SentenceBackend.Models;
using System.IO;

namespace SentenceBackend.Service
{
    public class DataLayerHandler
    {
        #region Initialisation on first run
        public static void InitDbDataInsert()
        {
            List<string> adjectives = Helpers.GetWords("Adjectives.txt");
            List<string> adverbs = Helpers.GetWords("Adverbs.txt");
            List<string> conjunctions = Helpers.GetWords("Conjunctions.txt");
            List<string> determiners = Helpers.GetWords("Determiners.txt");
            List<string> exclamations = Helpers.GetWords("Exclamations.txt");
            List<string> nouns = Helpers.GetWords("Nouns.txt");
            List<string> prepositions = Helpers.GetWords("Prepositions.txt");
            List<string> pronouns = Helpers.GetWords("Pronouns.txt");
            List<string> verbs = Helpers.GetWords("Verbs.txt");

            using (var ctx = new SentenceBuilderContext())
            {
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(adjectives, WordTypes.Adjectives));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(adverbs, WordTypes.Adverbs));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(conjunctions, WordTypes.Conjunctions));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(determiners, WordTypes.Determiners));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(exclamations, WordTypes.Exclamations));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(nouns, WordTypes.Nouns));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(prepositions, WordTypes.Prepositions));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(pronouns, WordTypes.Pronouns));
                ctx.WordLists.AddRange(Helpers.CompileListForInsert(verbs, WordTypes.Verbs));

                ctx.SaveChanges();
            }
        }
        public static bool CheckDataExists()
        {
            using (var ctx = new SentenceBuilderContext())
            {
                var val = ctx.WordLists.FirstOrDefault();
                if (val == null)
                {
                    InitDbDataInsert();
                }
            }
            return true;
        }
        #endregion

        #region Retrieve Data

        public static List<string> GetWordsByType(int type)
        {
            var typeEnum = Enum.GetName(typeof(WordTypes), type);
            List<string> words = new List<string>();

            using (var ctx = new SentenceBuilderContext())
            {
                words = ctx.WordLists.Where(a => a.WordType == typeEnum).Select(b => b.Word).ToList();
            }

            return words;
        }
        #endregion
    }
}