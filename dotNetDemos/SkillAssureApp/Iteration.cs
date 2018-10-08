using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillAssureApp
{
    public class Iteration
    {
        public int IterationNo { get; set; }
        public string Goal { get; set; }
        public Course Course { get; set; }
        public List<Assessment> Assessments { get; set; }
        
        public Iteration()
        {
            
            Assessments = new List<Assessment>(0);
        }

        public int GetNumOfIterationAssessments()
        {
            return Assessments.Count + Course.GetNumOfCourseAssessments();
        }

        public int GetNumOfMcqs()
        {
            int count = 0;
            foreach(Assessment assessment in Assessments)
            {
                count += assessment.GetTotalNumMCQInAssessment();
            }
            count += Course.GetTotalCourseMCQ();
            return count;
        }
        public int GetNumOfHandsOn()
        {
            int count = 0;
            foreach(Assessment assessment in Assessments)
            {
                count += assessment.GetTotalNumHandsOnAssessment();
            }
            count += Course.GetTotalCourseHandsOn();
            return count;
        }
        public int GetTotalMarks()
        {
            int count = 0;
            foreach (Assessment assessment in Assessments)
            {
                count += assessment.GetTotalNumHandsOnAssessment();
            }
            count += Course.GetCourseTotalMarks();
            return count;
        }
    }
}