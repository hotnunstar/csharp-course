using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        [Serializable]
        class Counter
        {
            public int Value { get; set; }
        }

        static void Main(string[] args)
        {
            Counter counter;

            try
            {
                using (FileStream fs = new FileStream("counter.dat", FileMode.OpenOrCreate))
                {
                    if (fs.Length > 0)
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        counter = (Counter)formatter.Deserialize(fs);
                        Console.WriteLine("Successfully deserialized counter.");
                    }
                    else
                    {
                        counter = new Counter();
                        Console.WriteLine("File is empty. Initializing new counter");
                    }
                }
            }
            catch (SerializationException ex)
            {
                Console.WriteLine($"SerializationException: {ex.Message}");
                counter = new Counter();
            }
            catch (FileNotFoundException)
            {
                counter = new Counter();
                Console.WriteLine("File not found. Initializing new counter.");
            }

            Console.WriteLine($"Current Value: {counter.Value}");
            counter.Value++;

            using (FileStream fs = new FileStream("counter.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, counter);
                Console.WriteLine("Successfully serialized counter");
            }
        }
    }
}
