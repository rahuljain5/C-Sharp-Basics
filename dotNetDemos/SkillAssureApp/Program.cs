using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillAssureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MCQuestion m1 = new MCQuestion { Marks = 5};
            MCQuestion m2 = new MCQuestion { Marks = 4};
            MCQuestion m3 = new MCQuestion { Marks = 6};

            HandsOnQuestion h1 = new HandsOnQuestion { Marks = 10 };
            HandsOnQuestion h2 = new HandsOnQuestion { Marks = 12 };
            HandsOnQuestion h3 = new HandsOnQuestion { Marks = 15 };

            Assessment a1 = new Assessment();
            a1.Questions.Add(m1);
            a1.Questions.Add(m2);
            Assessment a2 = new Assessment();
            a2.Questions.Add(m3);
            a2.Questions.Add(h1);
            Assessment a3 = new Assessment();
            a3.Questions.Add(h2);
            a3.Questions.Add(h3);
            Assessment a4 = new Assessment();
            a4.Questions.Add(h3);


            Iteration i1 = new Iteration();
            Iteration i2 = new Iteration();
            Iteration i3 = new Iteration();

            i1.Assessments.Add(a4);
            //i2.Assessments.Add(a2);

            Course course1 = new Course();
            Course course2 = new Course();
            Course course3 = new Course();

            course1.Assessments.Add(a1);
            course2.Assessments.Add(a2);
            course3.Assessments.Add(a3);

            i1.Course = course1;
            i2.Course = course2;
            i3.Course = course3;

            SkillAssureTrainingModel skillAssure = new SkillAssureTrainingModel();
            skillAssure.Iterations[0] = i1; 
            skillAssure.Iterations[1] = i2; 
            skillAssure.Iterations[2] = i3;

            Console.WriteLine("Total Num Assessments: "+skillAssure.GetTotalAssessmentsInTraining());
            Console.WriteLine("Total Score Assessments: " + skillAssure.GetTotalScoreOfAssessments());
            Console.WriteLine("Total Num HandsOn: " + skillAssure.GetNumHandsOnBasedAssessment());
            Console.WriteLine("Total Num MCQ: " + skillAssure.GetNumMCQBasedAssessment());




        }
    }
}
