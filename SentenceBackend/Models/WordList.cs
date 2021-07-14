using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SentenceBackend.Models
{
    public class WordList
    {
        [Key]
        public int WordId { get; set; }
        public string WordType { get; set; }
        public string Word { get; set; }
    }
   
}