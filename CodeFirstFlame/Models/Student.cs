using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFlame.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDay { get; set; }
        public decimal Scholarship { get; set; }

        public override string ToString()
        {
            return $"StudentId: {StudentId}, Name: {Name}, Surname: {Surname}, BirthDay: {BirthDay}, Stepyha: {Scholarship}";
        }


    }
}
