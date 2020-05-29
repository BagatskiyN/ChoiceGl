using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ChoiceGlob.Models.ChoiceContext;

namespace ChoiceGlob.Models
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Group { set; get; }

        public List<DisciplineStudent> DisciplineStudents { get; set; }

        public Student()
        {

        }
    }
}
