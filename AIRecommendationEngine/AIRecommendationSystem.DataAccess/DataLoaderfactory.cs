using AIRecommendationSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendationEngine.Recommender
{
    public class DataLoaderFactory
    {
        private static readonly DataLoaderFactory instance = new DataLoaderFactory();
        DataLoaderFactory() { }
        public static DataLoaderFactory getInstance()
        {
            return instance;
        }
        public IDataLoader GetLoader()
        {
            if (Config.dataLoader == 1) return new CSVDataLoader();
            else return new ParallelCSVDataLoader();
        }
    }
}
