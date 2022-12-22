using Parsing_JSON.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_JSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            var path = Path.Combine(Environment.CurrentDirectory, "JSON.txt");
            var json = File.ReadAllText(path);

            Root settings = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(json);

            format(settings.formated());

            var jsonSerialize = Newtonsoft.Json.JsonConvert.SerializeObject(settings);
            var pathSerialize = Path.Combine(Environment.CurrentDirectory, "JsonSerialize.txt");
            File.WriteAllText(pathSerialize, jsonSerialize);

            Console.WriteLine();
            Console.ReadLine();
        }
        private static void format(string format)
        {
            Console.WriteLine(format);
        }
    }
}
