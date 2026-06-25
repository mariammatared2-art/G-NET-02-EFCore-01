using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishingYear { get; set; }
        public bool IsInStock { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
    }
}
