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
            string testINI = @"..\..\TestData\test01.ini";

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


            Dictionary<string, string> testHash1 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            testHash1["AAAA"] = "test01";
            testHash1["bbbb"] = "test02";
            testHash1["cccc"] = "test03";
            Console.WriteLine(testHash1.GetOrDefault("aaaa", "test04"));

            SerializableDictionary<string, string> testHash2 = new SerializableDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            testHash2["EEEE"] = "test05";
            testHash2["ffff"] = "test06";
            testHash2["gggg"] = "test07";
            Console.WriteLine(testHash2.GetOrDefault("eeee", "test08"));

            Dictionary<string, string> testHash3 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            testHash1["AAAA"] = "test01";
            testHash1["bbbb"] = "test02";
            testHash1["cccc"] = "test03";
            Console.WriteLine(testHash1.GetOrDefault("aaaa", "nasi"));
            testHash1.DeleteIfContains("aaaa");
            Console.WriteLine(testHash1.GetOrDefault("aaaa", "nasi"));

            IniFile iniFile = new IniFile();
            IniFile.Section section01 = new IniFile.Section();
            IniFile.Section section02 = new IniFile.Section("AAAA");
            IniFile.Section section03 = new IniFile.Section("BBBB");
            section01.Entries["param1"] = "1";
            section01.Entries["param2"] = "2";
            section01.Entries["param3"] = "3";
            section01.Entries["param4"] = "4";
            section01.Entries["param5"] = "5";
            section02.Entries["AAAA"] = "Sampe Parameter 01";
            section02.Entries["BBBB"] = "Sampe Parameter 02";
            section02.Entries["CCCC"] = "Sampe Parameter 03";
            section03.Entries["1"] = "1234567890";
            section03.Entries["2"] = "abcdefghij";
            iniFile.SectionList.Add(section01);
            iniFile.SectionList.Add(section02);
            iniFile.SectionList.Add(section03);

            iniFile.Save(testINI);

            Console.ReadLine();
        }
    }
}
