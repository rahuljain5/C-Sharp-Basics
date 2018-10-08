using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp
{
    class Course
    {
        public List<Module> Modules = new List<Module>();
        public List<Training> Trainings { get; set ; }
    }
}
