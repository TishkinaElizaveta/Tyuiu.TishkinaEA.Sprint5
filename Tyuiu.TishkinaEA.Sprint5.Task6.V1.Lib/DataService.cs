using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TishkinaEA.Sprint5.Task6.V1.Lib
{
    public class DataService : ISprint5Task6V1
    {
        public int LoadFromDataFile(string path)
        {
            int result = File.ReadAllText(path).Count(x => char.IsDigit(x));
            return result;
        }
    }
}
