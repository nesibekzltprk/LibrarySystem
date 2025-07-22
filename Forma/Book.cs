using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    public class Book
    {
        
            public int Id { get; set; }
            public string Title { get; set; }
            public string Branch { get; set; }
            public int Sayfa { get; set; }
            public int Year { get; set; }
            public int AuthorId { get; set; }
            public string AuthorName { get; set; }  // API'den buna göre veri dönerse
            public int PublisherId { get; set; }
            public string PublisherName { get; set; }
        

    }
}
