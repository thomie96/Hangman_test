using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hangman_test.Models
{
    public class Word
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }


    public class HangmanDBContext : DbContext
    {
        public DbSet<Word> Words { get; set; }
    }
}