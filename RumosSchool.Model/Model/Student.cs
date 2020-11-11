using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumosSchool.Model.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
        }

        public List<Exam> Exams { get; set; }
    }
}
