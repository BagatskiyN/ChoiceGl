using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ChoiceGlob.Models.ChoiceContext;

namespace ChoiceGlob.Models
{
    public class Discipline
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Annotation { set; get; }
        //
        public int? TeacherId { get; set; }
        public Teacher Teacher { set; get; }

        public List<DisciplineStudent> DisciplineStudents { get; set; }
        public Discipline()
        {

        }

    }
}
