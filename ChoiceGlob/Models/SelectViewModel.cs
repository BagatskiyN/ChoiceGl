using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoiceGlob.Models
{
    public class SelectViewModel
    {

        public  Student Student { get; set; }

        public List<CheckedModel> SelectedDiscipline { get; set; }

        public SelectViewModel()
        {

        }

        public SelectViewModel(Student student, List<CheckedModel> checkedModels)
        {
            Student = student;
            SelectedDiscipline = checkedModels;
            

        }
      

    }
}
