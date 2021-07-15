using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SentenceBackend.Models;

namespace SentenceBackend
{
    public class SentenceBuilderContext : DbContext
    {
        public SentenceBuilderContext() : base("name=SentenceDB")
        {
            Database.SetInitializer<SentenceBuilderContext>(new CreateDatabaseIfNotExists<SentenceBuilderContext>());
        }

        public DbSet<WordList> WordLists { get; set; }
        public DbSet<Sentence> Sentences { get; set; }
    }
}