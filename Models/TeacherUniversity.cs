using System.ComponentModel.DataAnnotations;

namespace MyTeachers.Models
{
    public class TeacherUniversity
    {
        public int TeacherUniversityId { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int UniversityId { get; set; }
        public University University { get; set; }
    }
}
