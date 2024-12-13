using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TishkinaEA.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            //string tempFilePath = Path.GetTempFileName();
            //File.WriteAllText(tempFilePath, "-2,525");
            //double x = Convert.ToDouble(File.ReadAllText(tempFilePath));
            //double result = Convert.ToDouble((Math.Pow(x, -2) + 2) * Math.Sin(x));
            //return Math.Round(result, 2);            //string tempFilePath = Path.GetTempFileName();
            string tempFilePath = Path.GetTempFileName();
            double x = Convert.ToDouble(File.ReadAllText(tempFilePath).Replace(".", ","));          
            double result = Convert.ToDouble(1 / ((Math.Cos(x) + x) - 4.12*x ));
            return Math.Round(result, 2);
        }
    }
}
