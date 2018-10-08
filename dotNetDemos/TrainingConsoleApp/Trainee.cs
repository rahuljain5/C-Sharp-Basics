using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp
{
    class Trainee
    {
        public Trainer TheTrainer { get; set; }
        public List<Training> Trainings = new List<Training>();
    }
}
