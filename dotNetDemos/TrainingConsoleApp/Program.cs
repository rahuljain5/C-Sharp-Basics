using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Organization { Name = "Pratian" };
            Trainer trainer = new Trainer();
            trainer.Organization = org;
            Training training = new Training();
            training.TheTrainer = trainer;
            Trainee t1 = new Trainee();
            Trainee t2 = new Trainee();
            Trainee t3 = new Trainee();
            
            training.Trainees.Add(t1);
            training.Trainees.Add(t2);

            Course c1 = new Course();
            training.Course = c1;

            Module m1 = new Module();
            c1.Modules.Add(m1);
            Module m2 = new Module();
            c1.Modules.Add(m2);

            Unit u1 = new Unit { DurationOfHours = 6 };
            Unit u2 = new Unit { DurationOfHours = 2 };
            Unit u3 = new Unit { DurationOfHours = 7 };

            m1.Units.Add(u1);
            m1.Units.Add(u2);
            m2.Units.Add(u3);

            Topic to1 = new Topic();

            u1.Topics.Add(to1);
            u2.Topics.Add(to1);

            Console.WriteLine(training.GetTrainingOrganizationName());
            Console.WriteLine("Trainees Count: " + training.GetNumOfTrainees());
            Console.WriteLine("Total Hours: " + training.GetNumOfHours());
        }
    }
}
