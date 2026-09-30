using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class Parser
    {
        public static StudentTopic Parse(string line, string type)
        {
            if (string.IsNullOrWhiteSpace(line))
                throw new ArgumentException("Строка пустая");

            string[] p = line.Split('"');

            if (p.Length < 5)
                throw new FormatException("Неверный формат строки");

            string name = p[1];
            string topic = p[3];

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя студента пустое");

            if (string.IsNullOrWhiteSpace(topic))
                throw new ArgumentException("Название темы пустое");

            if (type == "group")
            {
                if (p.Length < 6)
                    throw new FormatException("Не найдена группа");

                DateTime dateG = DateTime.ParseExact(p[4].Trim(), "yyyy.MM.dd", null);
                string group = p[5].Trim();

                return new StudentTopicGroup(name, topic, dateG, group);
            }

            if (type == "grade")
            {
                int grade;
                DateTime dateGr;

                if (p.Length >= 6 && !string.IsNullOrWhiteSpace(p[5]))
                {
                    dateGr = DateTime.ParseExact(p[4].Trim(), "yyyy.MM.dd", null);
                    grade = int.Parse(p[5].Trim());
                }
                else
                {
                    string[] parts4 = p[4].Trim().Split(' ');

                    if (parts4.Length < 2)
                        throw new FormatException("Не найдена оценка");

                    dateGr = DateTime.ParseExact(parts4[0], "yyyy.MM.dd", null);
                    grade = int.Parse(parts4[1]);
                }

                if (grade < 2 || grade > 5)
                    throw new ArgumentException("Оценка должна быть 2-5: " + grade);

                return new StudentTopicGrade(name, topic, dateGr, grade);
            }

            DateTime date;
            try
            {
                date = DateTime.ParseExact(p[4].Trim(), "yyyy.MM.dd", null);
            }
            catch
            {
                throw new FormatException("Неверный формат даты: " + p[4].Trim());
            }

            return new StudentTopic(name, topic, date);
        }
    }
}