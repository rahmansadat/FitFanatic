using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseworkApp.Models
{
    public class QuoteModel
    {
        public string Author { get; set; } = null;
        public string Quote { get; set; } = null;

        public QuoteModel()
        {
        }

        public QuoteModel(string author, string quote)
        {
            Author = author;
            Quote = quote;
        }
    }
}
