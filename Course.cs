using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9DatabaseConnection
{
    internal class Course
    {
        // A course class with added annotations that specify column requirements when a its table is created
        [Required]
        [PrimaryKey]
        public int CourseId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Credit { get; set; }

        public Course() { }
        public Course(int id, string name, int credit) 
        {
            CourseId = id;
            Name = name;
            Credit = credit;
        }

        // ToString() method to display the modified details
        public override string ToString()
        {
            return $"Course ID: {CourseId}\t\t" +
                $"Name: {Name}\t\t" +
                $"Credit: {Credit}";
        }

    }
}
