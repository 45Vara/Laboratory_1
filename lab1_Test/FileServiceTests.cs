using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Test
{
    public class FileServiceTests
    {
        [Fact]
        public void Save_WritesToFile()
        {
            string filePath = "test_save.txt";
            List<StudentTopic> topics = new List<StudentTopic>
            {
                new StudentTopic("Иванов", "Алгоритмы", new DateTime(2026, 9, 3))
            };

            FileService.Save(topics, filePath);

            Assert.True(File.Exists(filePath));
            string content = File.ReadAllText(filePath);
            Assert.Contains("Иванов", content);
            Assert.Contains("Алгоритмы", content);

            File.Delete(filePath);
        }
    }
}
