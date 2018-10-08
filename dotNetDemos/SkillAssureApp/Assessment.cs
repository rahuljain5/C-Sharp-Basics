using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillAssureApp
{
    public class Assessment
    {
        public int AssessmentId { get; set; }
        public string Desc { get; set; }
        public int NoOfQuestions { get; set; }
        public DateTime DateOfAssessment { get; set; }
        public List<Question> Questions { get; set; }

        public Assessment()
        {
            Questions = new List<Question>();
        }
        public int GetTotalMarks()
        {
            return Questions.Sum(marks => marks.Marks);
        }
        public int GetTotalScoreOfAssessment()
        {
            return Questions.Sum(q => q.Marks);
        }
        public int GetTotalNumMCQInAssessment()
        {
            int count;
            count = Questions.Count(question => (question is MCQuestion));
            return count;
        }
        public int GetTotalNumHandsOnAssessment()
        {
            int count;
            count = Questions.Count(question => (question is HandsOnQuestion));
            return count;
        }

    }
}