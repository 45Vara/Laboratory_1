using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<StudentTopic> topics = new List<StudentTopic>();

            Load(topics, "topic.txt", "hello");
            Load(topics, "group.txt", "group");
            Load(topics, "grade.txt", "grade");

            Save(topics, "all_saved.txt");
            Show(topics);
        }

        static StudentTopic Parse(string line, string type)
        {
            string[] p = line.Split('"');
            string name = p[1];
            string topic = p[3];
            DateTime date = DateTime.ParseExact(p[4].Trim(), "yyyy.MM.dd", null);

            if (type == "group")
                return new StudentTopicGroup(name, topic, date, p[5].Trim());
            if (type == "grade")
                return new StudentTopicGrade(name, topic, date, int.Parse(p[5].Trim()));
            return new StudentTopic(name, topic, date);
        }

        static void Load(List<StudentTopic> list, string filePath, string type)
        {
            if (!File.Exists(filePath))
                return;

            StreamReader reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != "")
                    list.Add(Parse(line, type));
            }
            reader.Close();
        }

        static void Save(List<StudentTopic> topics, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);

            foreach (var t in topics)
            {
                string line = t.NameStudent + "|" + t.StudentsTopic + "|" + t.Date.ToString("yyyy.MM.dd");

                if (t is StudentTopicGroup g)
                    line += "|" + g.Group;
                else if (t is StudentTopicGrade gr)
                    line += "|" + gr.Grade;

                writer.WriteLine(line);
            }

            writer.Close();
        }
        static void Show(List<StudentTopic> topics)
        {
            Console.WriteLine("Все записи:");

            foreach (var t in topics)
            {
                string line = $"  {t.NameStudent} - {t.StudentsTopic} ({t.Date:yyyy.MM.dd})";

                if (t is StudentTopicGroup g)
                    line += $" | Группа: {g.Group}";
                else if (t is StudentTopicGrade gr)
                    line += $" | Оценка: {gr.Grade}";

                Console.WriteLine(line);
            }
        }
        static int F(List<int> numders)
        {
            int max = 0;
            for (int i = 0; i < numders.Count; i++)
            {
                int num = numders[i];
                int num1 = numders[i + 1];
                int num2 = numders[i + 2];

                int sum = num + num1 + num2;

                if (sum > max)
                {
                    max = sum;
                }

            }
            return max;
        }
    }
}
