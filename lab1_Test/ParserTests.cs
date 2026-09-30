using lab1;

namespace lab1_Test
{
    public class ParserTests
    {
        [Fact]
        public void Parse_ValidBase_ReturnsStudentTopic()
        {
            string line = "\"Иванов Иван\" \"Алгоритмы\" 2026.09.03";

            var result = Parser.Parse(line, "base");

            Assert.NotNull(result);
            Assert.IsType<StudentTopic>(result);
            Assert.Equal("Иванов Иван", result.NameStudent);
            Assert.Equal("Алгоритмы", result.StudentsTopic);
            Assert.Equal(new DateTime(2026, 9, 3), result.Date);
        }

        [Fact]
        public void Parse_ValidGroup_ReturnsStudentTopicGroup()
        {
            string line = "\"Сидоров\" \"Машинное\" 2026.09.05 \"КИ-21\"";

            var result = Parser.Parse(line, "group");

            Assert.IsType<StudentTopicGroup>(result);
            var group = (StudentTopicGroup)result;
            Assert.Equal("КИ-21", group.Group);
        }
    }
}
