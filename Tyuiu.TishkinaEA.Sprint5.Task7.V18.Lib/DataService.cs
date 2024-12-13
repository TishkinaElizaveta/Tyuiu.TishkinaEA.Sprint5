using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TishkinaEA.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);

            return Regex.Replace(str, @"(?<!н)н(?!н)", "нн");
        }
    }
}
