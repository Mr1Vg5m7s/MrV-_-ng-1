using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFlame.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }

    }

    [Table("Admins")]
    public class Admin : User
    {
        public string? Role { get; set; }
    }

    [Table("Guests")]
    public class Guest : User
    {
        public DateTime VisitDate { get; set; }
    }
}
