using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TishkinaEA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double res = Math.Round(6.1*Math.Pow(x,3) + 0.23*Math.Pow(x,2) + 1.04*x, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(res);
            }

            return path;
        }
    }
}
