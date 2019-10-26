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

            Console.ReadLine();
        }
    }
}
