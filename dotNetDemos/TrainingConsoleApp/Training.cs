using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp
{
    class Training
    {
        public Trainer TheTrainer { get; set; }
        public List<Trainee> Trainees = new List<Trainee>();
        public Course Course { get; set; }

        public string GetTrainingOrganizationName()
        {
            return TheTrainer.Organization.Name;
        }
        public int GetNumOfTrainees()
        {
            return Trainees.Count;
        }
        public int GetNumOfHours()
        {
            int duration = 0;
            foreach (var module in Course.Modules)
            {
                foreach (var unit in module.Units)
                {
                    duration += unit.DurationOfHours;
                }
            }
            return duration;

        }
        
    }
}
