using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyTeachers.Models
{
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(70)]
        public string Email { get; set; }
        [MaxLength(70)]
        public string UserName { get; set; }
        [MaxLength(70)]
        public string FirstName { get; set; }
        [MaxLength(70)]
        public string FirstLastName { get; set; }
        [MaxLength(70)]
        public string SecondLastName { get; set; }

        public List<Grade> Grades { get; set; }
    }
}
