using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class ShowStudent
    {
        public static string Show(List<StudentTopic> topics)
        {
            string result = "\nВсе записи:\n";

            foreach (var t in topics)
            {
                string line = $"  {t.NameStudent} - {t.StudentsTopic} ({t.Date:yyyy.MM.dd})";

                if (t is StudentTopicGroup g)
                    line += $" | Группа: {g.Group}";
                else if (t is StudentTopicGrade gr)
                    line += $" | Оценка: {gr.Grade}";

                result += line + "\n";
            }

            return result;
        }

        public static string ShowCount(int count)
        {
            return $"Загружено: {count}";
        }

        public static string ShowError(string message)
        {
            return $"Ошибка: {message}";
        }

        public static string ShowWarning(string message)
        {
            return $"{message}";
        }
    }
}