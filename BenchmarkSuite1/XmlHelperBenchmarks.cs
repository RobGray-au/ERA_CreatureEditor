using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using CreatureXmlEditor.Models;
using CreatureXmlEditor.Utilities;

namespace CreatureXmlEditor.Benchmarks
{
    [MemoryDiagnoser]
    public class XmlHelperBenchmarks
    {
        private string tempFile;
        private Creature creature;

        [GlobalSetup]
        public void Setup()
        {
            tempFile = Path.Combine(Path.GetTempPath(), "xmlhelper_benchmark.xml");
            creature = new Creature
            {
                Name = "Benchmark",
                Category = "Test"
            };
        }

        [Benchmark]
        public void SaveToFile_Benchmark()
        {
            XmlHelper.SaveToFile(creature, tempFile);
        }

        [Benchmark]
        public Creature LoadFromFile_Benchmark()
        {
            if (!File.Exists(tempFile))
                XmlHelper.SaveToFile(creature, tempFile);
            return XmlHelper.LoadFromFile(tempFile);
        }

        [GlobalCleanup]
        public void Cleanup()
        {
            try
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
            catch
            {
            }
        }
    }
}
