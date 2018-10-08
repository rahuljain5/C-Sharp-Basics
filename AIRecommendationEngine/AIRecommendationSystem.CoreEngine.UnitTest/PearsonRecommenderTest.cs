using System;
using System.Collections.Generic;
using AIRecommendation.CoreEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AIRecommendationSystem.CoreEngine.UnitTest
{
    [TestClass]
    public class PearsonRecommenderTest
    {
        [TestMethod]
        public void GetCorrelation_ForValidInput_GetsValidResult()
        {
            List<int> baseArray = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            List<int> dataArray = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            double actual;
            IRecommender target = new PearsonRecommender();
            actual = target.GetCorrelation(baseArray, dataArray);
            Assert.AreEqual(actual, 1);
        }
        [TestMethod]
        public void GetCorrelation_BaseDataWithZero_GetsValidResult()
        {
            List<int> baseArray = new List<int> { 1, 0, 3, 4, 5, 0, 7, 8, 9, 0 ,1, 2, 1, 1};
            List<int> dataArray = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 1, 1, 1, 1};
            double actual;
            IRecommender target = new PearsonRecommender();
            actual = target.GetCorrelation(baseArray, dataArray);
            Assert.AreEqual(Math.Round(0.830420712, 4), Math.Round(actual, 4));
        }
        [TestMethod]
        public void GetCorrelation_OtherDataWithZero_GetsValidResult()
        {
            List<int> baseArray = new List<int> { 1, 1, 3, 4, 5, 4, 7, 8, 9, 8 ,1,1,1,1};
            List<int> dataArray = new List<int> { 1, 2, 0, 4, 5, 6, 7, 8, 9, 0, 1,1 ,1,1};
            double actual;
            IRecommender target = new PearsonRecommender();
            actual = target.GetCorrelation(baseArray, dataArray);
            Assert.AreEqual(Math.Round(0.7041427105, 4), Math.Round(actual,4));
        }
        [TestMethod]
        public void GetCorrelation_BaseDataIsLargerThanOtherData_GetsValidResult()
        {
            List<int> baseArray = new List<int> { 1, 1, 3, 4, 5, 4, 7, 8, 9, 8, 1, 1, 1, 1, 1};
            List<int> dataArray = new List<int> { 1, 2, 1, 4, 5, 6, 7, 8, 9, 1, 1, 1, 1, 1 };
            double actual;
            IRecommender target = new PearsonRecommender();
            actual = target.GetCorrelation(baseArray, dataArray);
            Assert.AreEqual(Math.Round(0.7751731638, 4), Math.Round(actual,4));
        }

    }
}
