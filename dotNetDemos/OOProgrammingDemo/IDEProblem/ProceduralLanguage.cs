using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.IDEProblem
{
    public abstract class ProceduralLanguage : ILanguage
    {
        abstract public string GetName();

        public string GetParadigm()
        {
            return "Procedural";
        }

        public string GetUnit()
        {
            return "Function";
        }
    }
}
