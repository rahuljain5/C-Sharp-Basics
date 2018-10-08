using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.IDEProblem
{
    class Program
    {
        public static void Main()
        {
            IDE iDE = new IDE();
            iDE.Languages.Add(new LanguageC());
            iDE.Languages.Add(new LanguageCSharp());
            iDE.Languages.Add(new LanguageCPP());
            iDE.ListLanguages();
        }
    }
}
