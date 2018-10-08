using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOProgrammingDemo.IDEProblem
{
    public class LanguageCPP : ILanguage
    {
        ProceduralLanguage procedural = new LanguageC();
        OOLanguage objectOriented = new LanguageCSharp();
        public string GetName()
        {
            return "C++";
        }

        public string GetParadigm()
        {
            return procedural.GetParadigm() + ", " + objectOriented.GetParadigm();
        }

        public string GetUnit()
        {
            return procedural.GetUnit() + ", " + objectOriented.GetUnit();
        }
    }
}