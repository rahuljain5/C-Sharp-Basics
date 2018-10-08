using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillAssureApp
{
    public class Course
    {
        public string CourseId { get; set; }
        public string Name { get; set; }
        public List<Assessment> Assessments { get; set; }

        public Course()
        {
            Assessments = new List<Assessment>(1);
        }
        public int GetNumOfCourseAssessments()
        {
            return Assessments.Count;
        }
        public int GetCourseTotalMarks()
        {
            int totalMarks = 0;
            foreach(Assessment assessment in Assessments)
            {
                totalMarks += assessment.GetTotalMarks();
            }
            return totalMarks;
        }
        public int GetTotalCourseMCQ()
        {
            int total = 0;
            foreach(Assessment assessment in Assessments)
            {
                total += assessment.GetTotalNumMCQInAssessment();
            }
            return total;
        }
        public int GetTotalCourseHandsOn()
        {
            int total = 0;
            foreach(Assessment assessment in Assessments)
            {
                total += assessment.GetTotalNumHandsOnAssessment();
            }
            return total;
        }

    }
}