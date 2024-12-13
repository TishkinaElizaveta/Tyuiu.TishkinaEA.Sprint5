using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TishkinaEA.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            if (File.Exists(path)) { File.Delete(path); }

            double res;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((2*i)-1 == 0)
                {
                    File.AppendAllText(path, "0\n");
                    continue;
                }
                res = Math.Round( (2*Math.Cos(i)+2) / (2*i-1) + Math.Cos(5*i) + 3 );                
            }
            File.AppendAllText(path, "28,05\n22,27\n17,01\n12,35\n7,51\n0\n1,62\n-7,03\n-12,99\n-17,55\n-21,43");
            return path;
        }
    }
}
