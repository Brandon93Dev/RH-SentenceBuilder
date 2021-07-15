using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SentenceBackend.Models
{
    public class Sentence
    {
        [Key]
        public int SentenceId { get; set; }
        public string SentenceContent { get; set; }
    }
}