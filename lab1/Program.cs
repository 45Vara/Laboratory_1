using System;
using System.Collections.Generic;
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

            Console.WriteLine("Введите темы работ.");
            Console.WriteLine("Формат: \"Имя\" \"Тема\" ГГГГ.ММ.ДД");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                    break;

                string[] parts = input.Split('"');

                if (parts.Length >= 5)
                {
                    string name = parts[1];

                    string topic = parts[3];

                    string dateStr = parts[4].Trim();

                    DateTime date = DateTime.ParseExact(dateStr, "yyyy.MM.dd", null);

                    StudentTopic t = new StudentTopic(name, topic, date);
                    topics.Add(t);
                }
                else
                {
                    Console.WriteLine("Ошибка! Неправильный формат.");
                }
            }
            Console.WriteLine("Сохранено " + topics.Count + " записей в файл ");
        }
    }
}
