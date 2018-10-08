using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.IDEProblem
{
    abstract class OOLanguage : ILanguage
    {
        abstract public string GetName();

        public string GetParadigm()
        {
            return "Object Oriented";
        }

        public string GetUnit()
        {
            return "Class";
        }
    }
}
