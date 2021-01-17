using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyTeachers.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        [MaxLength(300)]
        public string Comment { get; set; }
        public int Quality { get; set; }
        public int Ease { get; set; }
        public int Help { get; set; }
        public int Interest { get; set; }
        public int Comfort { get; set; }
        public int Agree { get; set; }  = 0; 
        public int Disagree { get; set; } = 0;
        public bool Recommended { get; set; } = false;
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public List<Teacher> Teachers { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
