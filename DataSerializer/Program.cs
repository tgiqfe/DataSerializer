using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string testJSON = @"..\..\TestData\test01.json";
            string testXML = @"..\..\TestData\test01.xml";
            string testYML = @"..\..\TestData\test01.yml";
            string testYAML = @"..\..\TestData\test01.yaml";

            SampleClass[] samples = SampleClass.CreateClasses();

            DataSerializer.Serialize<SampleClass[]>(samples, testJSON);
            DataSerializer.Serialize<SampleClass[]>(samples, testXML);
            DataSerializer.Serialize<SampleClass[]>(samples, testYML);
            DataSerializer.Serialize<SampleClass[]>(samples, testYAML);

            Console.ReadLine();
            SampleClass[] instanceJSON = DataSerializer.Deserialize<SampleClass[]>(testJSON);
            Console.WriteLine(DataSerializer.Serialize<SampleClass[]>(instanceJSON, DataType.Json));

            Console.ReadLine();
            SampleClass[] instanceXML = DataSerializer.Deserialize<SampleClass[]>(testXML);
            Console.WriteLine(DataSerializer.Serialize<SampleClass[]>(instanceXML, DataType.Json));

            Console.ReadLine();
            SampleClass[] instanceYML = DataSerializer.Deserialize<SampleClass[]>(testYML);
            Console.WriteLine(DataSerializer.Serialize<SampleClass[]>(instanceYML, DataType.Json));


            Dictionary<string, string> testHash1 = new Dictionary<string, string>();
            testHash1["aaaa"] = "test01";
            testHash1["bbbb"] = "test02";
            testHash1["cccc"] = "test03";
            Console.WriteLine(testHash1.GetOrDefault("dddd", "test04"));

            SerializableDictionary<string, string> testHash2 = new SerializableDictionary<string, string>();
            testHash2["eeee"] = "test05";
            testHash2["ffff"] = "test06";
            testHash2["gggg"] = "test07";
            Console.WriteLine(testHash2.GetOrDefault("hhhh", "test08"));

            Console.ReadLine();
        }
    }
}
