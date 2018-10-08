using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp
{
    class Trainer
    {
        public Organization Organization { get; set; }
        //public Trainee[] Trainees = new Trainee[19];
        public List<Trainee> Trainees = new List<Trainee>(); 
        public Trainer()
        {
            Organization = new Organization();
        }
    }
}
