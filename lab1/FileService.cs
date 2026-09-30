using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class FileService
    {
        public static List<string> Load(string type, List<StudentTopic> list, string filePath)
        {
            List<string> errors = new List<string>();

            if (!File.Exists(filePath))
            {
                errors.Add("Файл не найден: " + filePath);
                return errors;
            }

            StreamReader reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line != "")
                {
                    try
                    {
                        list.Add(Parser.Parse(line, type));
                    }
                    catch (Exception ex)
                    {
                        errors.Add("Ошибка в строке: " + line);
                        errors.Add("   " + ex.Message);
                    }
                }
            }

            reader.Close();
            return errors;
        }

        public static void Save(List<StudentTopic> topics, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);

            foreach (var t in topics)
            {
                string line = "\"" + t.NameStudent + "\" \"" + t.StudentsTopic + "\" " + t.Date.ToString("yyyy.MM.dd");

                if (t is StudentTopicGroup g)
                    line += " \"" + g.Group + "\"";
                else if (t is StudentTopicGrade gr)
                    line += " " + gr.Grade;

                writer.WriteLine(line);
            }

            writer.Close();
        }

        public static void Append(StudentTopic topic, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath, true);

            string line = "\"" + topic.NameStudent + "\" \"" + topic.StudentsTopic + "\" " + topic.Date.ToString("yyyy.MM.dd");

            if (topic is StudentTopicGroup g)
                line += " \"" + g.Group + "\"";
            else if (topic is StudentTopicGrade gr)
                line += " " + gr.Grade;

            writer.WriteLine(line);
            writer.Close();
        }
    }
}