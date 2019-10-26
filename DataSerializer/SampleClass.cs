using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSerializer
{
    /// <summary>
    /// enum型テスト用
    /// </summary>
    public enum SampleCoor
    {
        Red = 0,
        Blue = 1,
        Green = 2,
        Orange = 4,
        Yellow = 8,
        Purple = 16,
        Black = 32,
        White = 64,
        usubeni = 128,
        TurquoiseBlue = 256,
        PianoBlack = 512,
        CarbonBlack = 512,
        shikkoku = 512,
        nureba = 512,
        karasu = 512,
    }

    /// <summary>
    /// 内部クラステスト用
    /// </summary>
    public class InnerClass
    {
        public string Name { get; set; }
        public int Length { get; set; }

        public InnerClass() { }
    }

    public class SampleClass
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double DoubleCount { get; set; }
        public string[] MultiStrings { get; set; }
        public List<string> StringList { get; set; }
        public DateTime Today { get; set; }
        public SerializableDictionary<string, string> KeyVal { get; set; }
        public SampleCoor Color { get; set; }
        public InnerClass Inner { get; set; }

        public SampleClass() { }

        public static SampleClass CreateClass()
        {
            return new SampleClass()
            {
                Name = "サンプル",
                Count = 100,
                DoubleCount = 6553565535,
                MultiStrings = new string[] { "aaaa", "bbbb", "cccc" },
                StringList = new List<string> { "dddd", "eeee", "ffff" },
                Today = DateTime.Now,
                KeyVal = new SerializableDictionary<string, string>() { { "Key1", "Value1" }, { "Key2", "Value2" }, { "Key3", "Value3" } },
                Color = SampleCoor.Black,
                Inner = new InnerClass() { Name = "内部クラス", Length = 50 }
            };
        }

        public static SampleClass[] CreateClasses()
        {
            return new SampleClass[]
            {
                new SampleClass()
                {
                    Name = "サンプル1",
                    Count = 201,
                    DoubleCount = 6550000001,
                    MultiStrings = new string[] { "aaaa", "bbbb", "cccc" },
                    StringList = new List<string> { "dddd", "eeee", "ffff" },
                    Today = DateTime.Now,
                    KeyVal = new SerializableDictionary<string, string>() { { "Key1", "Value1" }, { "Key2", "Value2" }, { "Key3", "Value3" } },
                    Color = SampleCoor.White,
                    Inner = new InnerClass() { Name = "内部クラス", Length = 50 }
                },
                new SampleClass()
                {
                    Name = "サンプル2",
                    Count = 202,
                    DoubleCount = 6550000002,
                    MultiStrings = new string[] { "aaaa", "bbbb", "cccc" },
                    StringList = new List<string> { "dddd", "eeee", "ffff" },
                    Today = DateTime.Now,
                    KeyVal = new SerializableDictionary<string, string>() { { "Key1", "Value1" }, { "Key2", "Value2" }, { "Key3", "Value3" } },
                    Color = SampleCoor.Black,
                    Inner = new InnerClass() { Name = "内部クラス", Length = 50 }
                },
                new SampleClass()
                {
                    Name = "サンプル3",
                    Count = 203,
                    DoubleCount = 6550000003,
                    MultiStrings = new string[] { "aaaa", "bbbb", "cccc" },
                    StringList = new List<string> { "dddd", "eeee", "ffff" },
                    Today = DateTime.Now,
                    KeyVal = new SerializableDictionary<string, string>() { { "Key1", "Value1" }, { "Key2", "Value2" }, { "Key3", "Value3" } },
                    Color = SampleCoor.PianoBlack,
                    Inner = new InnerClass() { Name = "内部クラス", Length = 50 }
                },
                new SampleClass()
                {
                    Name = "サンプル4",
                    Count = 204,
                    DoubleCount = 6550000004,
                    MultiStrings = new string[] { "aaaa", "bbbb", "cccc" },
                    StringList = new List<string> { "dddd", "eeee", "ffff" },
                    Today = DateTime.Today,
                    KeyVal = new SerializableDictionary<string, string>() { { "Key1", "Value1" }, { "Key2", "Value2" }, { "Key3", "Value3" } },
                    Color = SampleCoor.shikkoku,
                    Inner = new InnerClass() { Name = "内部クラス", Length = 50 }
                }
            };
        }
    }
}
