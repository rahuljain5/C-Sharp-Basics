using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.IDEProblem
{
    class IDE
    {
        public List<ILanguage> Languages = new List<ILanguage>();
        public void ListLanguages()
        {
            foreach(var lang in Languages)
            {
                Console.WriteLine($"Name: {lang.GetName()}, Paradigm: {lang.GetParadigm()}, Unit: {lang.GetUnit()}");
            }
        }

    }
}
