using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JSON_XML
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var jsonData = new Person { Name = "John", Age = 30 };
            File.WriteAllText("data.json", JsonConvert.SerializeObject(jsonData));

            var jsonString = File.ReadAllText("data.json");
            var jsonPerson = JsonConvert.DeserializeObject<Person>(jsonString);
            Console.WriteLine($"JSON Data: Name={jsonPerson.Name}, Age={jsonPerson.Age}");

            var xmlData = new Person { Name = "Jane", Age = 25 };
            var xmlSerializer = new XmlSerializer(xmlData.GetType());

            using (var write = new StreamWriter("data.xml"))
            {
                xmlSerializer.Serialize(write, xmlData);
            }

            using (var reader = new StreamReader("data.xml"))
            {
                var xmlObj = xmlSerializer.Deserialize(reader) as Person;
                Console.WriteLine($"XML Data: Name={xmlObj.Name}, Age={xmlObj.Age}");
            }
        }
    }
}
