using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendation.CoreEngine
{
    public interface IRecommender
    {
        double GetCorrelation(List<int> baseArray, List<int> Otherdata);
    }
}
