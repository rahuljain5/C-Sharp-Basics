using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRecommendation.CoreEngine
{
    public class PearsonRecommender : IRecommender
    {
        public double GetCorrelation(List<int> Base, List<int> Data)
        {
            List<int> baseArray = new List<int>(Base);
            List<int> dataArray = new List<int>(Data);
            
            double correlationCoefficent;
            if (baseArray.Count < dataArray.Count)
            {
                dataArray.RemoveRange(baseArray.Count, (dataArray.Count - baseArray.Count));
            }
            else if (dataArray.Count < baseArray.Count)
            {
                for (int i = dataArray.Count; i < baseArray.Count; i++)
                {
                    baseArray[i]++;
                    dataArray.Add(1);
                }
            }
            if (baseArray.Contains(0) || dataArray.Contains(0))
            {
                for (int i = 0; i < baseArray.Count; i++)
                {
                    if ((baseArray[i] == 0) || (dataArray[i] == 0))
                    {
                        baseArray[i] += 1;
                        dataArray[i] += 1;
                    }
                }
            }
            int sumX = baseArray.Sum();
            int sumY = dataArray.Sum();
            int[] xy = new int[baseArray.Count];
            int[] x2 = new int[baseArray.Count];
            int[] y2 = new int[baseArray.Count];
            for (int i = 0; i < baseArray.Count; i++)
            {
                x2[i] = (baseArray[i] * baseArray[i]);
                y2[i] = (dataArray[i] * dataArray[i]);
                xy[i] = baseArray[i] * dataArray[i];
                //Console.WriteLine(baseArray[i] + ", "+ dataArray[i]);
            }

            int sumXY = xy.Sum();
            int sumX2 = x2.Sum();
            int sumy2 = y2.Sum();
            int n = dataArray.Count;
            double r1 = ((n * sumXY) - (sumX * sumY));
            //double r2 = (Math.Sqrt(((n * sumX2) - (sumX * sumX)) * ((n * sumy2) - (sumY * sumY))));
            //Console.WriteLine($"{n}, {sumX}, {sumY}, {sumXY}, {sumX2}, {sumy2}, {r1}, {r2}");
            correlationCoefficent = (r1 / (Math.Sqrt(((n * sumX2) - (sumX * sumX)) * ((n * sumy2) - (sumY * sumY)))));
            if (double.IsNaN(correlationCoefficent)) correlationCoefficent = 1;
            return correlationCoefficent;
        }


        //public double GetCorrelation(List<int> BaseData, List<int> OtherData)
        //{
        //    int x, y;
        //    x = BaseData.Count;
        //    y = OtherData.Count;

        //    if (x > y)
        //    {
        //        while (OtherData.Count != BaseData.Count)
        //        {
        //            OtherData.Add(1);
        //        }
        //        //int count = 0;

        //        for (int i = y; i < BaseData.Count; i++)
        //        {
        //            BaseData[i] += 1;
        //        }
        //    }
        //    else if (x < y)
        //    {
        //        OtherData.RemoveRange(x, y - x);
        //    }

        //    foreach (var i in OtherData)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    foreach (var i in BaseData)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    double r = 0, sumx = 0, sumy = 0, sumx2 = 0, sumy2 = 0, tsumx2 = 0, tsumy2 = 0, sum = 0;
        //    int N = BaseData.Count;
        //    for (int i = 0; i < BaseData.Count; i++)
        //    {
        //        sumx += BaseData[i];
        //        sumy += OtherData[i];
        //        sum += BaseData[i] * OtherData[i];
        //        sumx2 += BaseData[i] * BaseData[i];
        //        sumy2 += OtherData[i] * OtherData[i];
        //    }
        //    tsumx2 = sumx * sumx;
        //    tsumy2 = sumy * sumy;
        //    r = (N * sum - sumx * sumy) / Math.Sqrt((N * sumx2 - tsumx2) * (N * sumy2 - tsumy2));
        //    return r;
        //}

    }
}
