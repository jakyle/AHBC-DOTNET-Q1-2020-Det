using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootstrap.Models
{
    public class BooksViewModel
    {
        public IEnumerable<BookModel> Books { get; set; }
    }

    public class BookModel

    {
        public string Name { get; set; }
        public IEnumerable<string> Authors { get; set; }
        public IEnumerable<string> Characters { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime Released { get; set; }
    }
}
