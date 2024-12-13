using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TishkinaEA.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            double[] arr = File.ReadAllText(path).Split().Select(el => double.Parse(el, CultureInfo.InvariantCulture)).ToArray();
            double min = arr[0];
            foreach (double num in arr)
            {
                if (num%5 != 0)
                {
                    continue;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            return Math.Round(min, 3);
        }
    }
}
