using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Test
{
    public class ProgramTests
    {
        [Fact]
        public void FullCycle_SaveAndLoad_Works()
        {
            string filePath = "test_full.txt";
            List<StudentTopic> original = new List<StudentTopic>
            {
                new StudentTopic("Иванов", "Алгоритмы", new DateTime(2026, 9, 3)),
                new StudentTopicGroup("Сидоров", "Машинное", new DateTime(2026, 9, 5), "КИ-21"),
                new StudentTopicGrade("Козлов", "Веб", new DateTime(2026, 9, 10), 5)
            };

            FileService.Save(original, filePath);

            List<StudentTopic> loaded = new List<StudentTopic>();
            var errors = FileService.Load("base", loaded, filePath);

            Assert.True(File.Exists(filePath));

            File.Delete(filePath);
        }
    }
}
