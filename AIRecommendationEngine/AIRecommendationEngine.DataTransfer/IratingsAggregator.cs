using AIRecommendationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationEngine.DataTransferObject
{
    public interface IRatingsAggregator
    {
        Dictionary<string, List<int>> Aggregate(BookDetail bookDetail, Preference preference);
    }
}
