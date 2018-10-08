using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillAssureApp
{
    public class SkillAssureTrainingModel
    {
        public string ClientName { get; set; }
        public Iteration[] Iterations { get; set; }

        public SkillAssureTrainingModel()
        {
            Iterations = new Iteration[3];
        }
        public int GetTotalAssessmentsInTraining()
        {
            int total = 0;
            foreach (var iteration in Iterations)
            {
                total += iteration.GetNumOfIterationAssessments();
            }
            return total;
        }
        public int GetNumMCQBasedAssessment()
        {
            int total = 0;
            foreach (var iteration in Iterations)
            {
                total += iteration.GetNumOfMcqs();
            }
            return total;
        }
        public int GetNumHandsOnBasedAssessment()
        {
            int total = 0;
            foreach (var iteration in Iterations)
            {
                total += iteration.GetNumOfHandsOn();
            }
            return total;
        }
        public int GetTotalScoreOfAssessments()
        {
            int total = 0;
            foreach (var iteration in Iterations)
            {
                total += iteration.GetTotalMarks();
            }
            return total;
        }
    }
}