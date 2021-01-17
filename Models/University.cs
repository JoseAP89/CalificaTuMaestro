
using System.Collections.Generic;

namespace MyTeachers.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public State State { get; set; }

        public List<TeacherUniversity> TeacherUniversities { get; set; }

    }
}
