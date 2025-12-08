using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_MrV.Models
{
    internal class Sales
    {
        public int Id { get; set; }

        public DateOnly SaleDate { get; set; }
                 
        public int BookId { get; set; }
 
        public Book? Books { get; set; }
    }
}
