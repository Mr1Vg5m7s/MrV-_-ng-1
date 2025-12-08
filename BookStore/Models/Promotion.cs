using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    internal class Promotion
    {
        public int Id { get; set; }

        public decimal Discription { get; set; }
        /*
        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }
        */
        public List<Book> Books { get; set; }
    }
}
