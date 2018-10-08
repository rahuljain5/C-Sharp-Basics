using AIRecommendationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationSystem.DataAccess
{
    public interface IDataLoader
    {
        BookDetail Load(); 
    }
}
