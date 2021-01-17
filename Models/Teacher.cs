using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyTeachers.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [MaxLength(70)]
        public string FirstName { get; set; }
        [MaxLength(70)]
        public string FirstLastName { get; set; }
        [MaxLength(70)]
        public string SecondLastName { get; set; }
        public Gender Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public Area Area { get; set; }

        public List<TeacherUniversity> TeacherUniversities { get; set; }

    }
}
