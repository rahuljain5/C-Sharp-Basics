using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillAssureApp
{
    public class MCQuestion : Question
    {
        public string QuestionName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string RightOption { get; set; }
    }
}