using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFlame.Models
{
        [Table("Flame")]
    internal class Student
    {
        
        //[Column("stud_id")]
        public int Id { get; set; }
        [Required] 
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateOnly BirthDay { get; set; }
        public decimal Scholarship { get; set; }

        int code;
        public int GetCode => code;

        /*public override string ToString()
        {
            return $"StudentId: {Id}, Name: {Name}, Surname: {Surname}, BirthDay: {BirthDay}, Stepyha: {Scholarship}";
        }*/


    }
}
