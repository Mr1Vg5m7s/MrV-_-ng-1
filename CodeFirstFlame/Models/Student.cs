using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFlame.Models
{
       //[Table("Flame")]
    internal class Student
    {
        
        //[Column("stud_id")]
        public int Id { get; set; }
       // [Required] 
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Scholarship { get; set; }
        public int? GroupId { get; set; }

        public Group? Group { get; set; }
        public int? StudInfoId { get; set; }
        public StudInfo? StudInfo { get; set; }

        public List<Subject> Subjects { get; set; }
        public List<StudentSubject>? StudentSubjects { get; set; }


        public override string ToString()
        {
            return $"{Id}: {Name} {Surname}, born on {BirthDay.ToShortDateString()}, Group: {Group?.Name}, Login: {StudInfo?.Login}, HashPassword: {StudInfo?.HashPassword}";
        }


    }
}
