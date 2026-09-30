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
        private static string basePath = @"C:\Users\STUDENT 2025\Desktop\Lab1";
        private static string topicFile = basePath + @"\topic.txt";
        private static string groupFile = basePath + @"\group.txt";
        private static string gradeFile = basePath + @"\grade.txt";
        private static string saveFile = basePath + @"\saved.txt";

        static void Main()
        {

            try
            {
                List<StudentTopic> topics = new List<StudentTopic>();

                while (true)
                {
                    ShowMenu(topics.Count);
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1) LoadAll(topics);
                    else if (choice == 2) SaveAll(topics);
                    else if (choice == 3) ShowAll(topics);
                    else if (choice == 4) AddNew(topics);
                    else if (choice == 0) break;
                    else Console.WriteLine("Неверный выбор");

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ShowStudent.ShowError(ex.Message));
            }

            Console.ReadKey();
        }

        static void ShowMenu(int count)
        {
            Console.WriteLine("Записей: " + count);
            Console.WriteLine("1. Считать с файлов");
            Console.WriteLine("2. Сохранить в файл");
            Console.WriteLine("3. Показать все записи");
            Console.WriteLine("4. Добавить новую строку");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите: ");
        }

        static void LoadAll(List<StudentTopic> topics)
        {
            topics.Clear();

            List<string> allErrors = new List<string>();

            allErrors.AddRange(FileService.Load("base", topics, topicFile));
            allErrors.AddRange(FileService.Load("group", topics, groupFile));
            allErrors.AddRange(FileService.Load("grade", topics, gradeFile));

            foreach (var error in allErrors)
                Console.WriteLine(error);

            Console.WriteLine(ShowStudent.ShowCount(topics.Count));
        }

        static void SaveAll(List<StudentTopic> topics)
        {
            FileService.Save(topics, saveFile);
            Console.WriteLine("Сохранено в: " + saveFile);
        }

        static void ShowAll(List<StudentTopic> topics)
        {
            Console.WriteLine(ShowStudent.Show(topics));
        }

        static void AddNew(List<StudentTopic> topics)
        {
            Console.WriteLine("Выберите тип записи:");
            Console.WriteLine("1. Обычная тема");
            Console.WriteLine("2. С группой");
            Console.WriteLine("3. С оценкой");
            Console.Write("Выберите: ");

            int typeChoice = int.Parse(Console.ReadLine());

            if (typeChoice == 1) AddTopic(topics);
            else if (typeChoice == 2) AddGroup(topics);
            else if (typeChoice == 3) AddGrade(topics);
            else Console.WriteLine("Неверный выбор");
        }

        static void AddTopic(List<StudentTopic> topics)
        {
            Console.WriteLine("Формат: \"Имя\" \"Тема\" ГГГГ.ММ.ДД");
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            AddLine(topics, line, "base", topicFile);
        }

        static void AddGroup(List<StudentTopic> topics)
        {
            Console.WriteLine("Формат: \"Имя\" \"Тема\" ГГГГ.ММ.ДД \"Группа\"");
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            AddLine(topics, line, "group", groupFile);
        }

        static void AddGrade(List<StudentTopic> topics)
        {
            Console.WriteLine("Формат: \"Имя\" \"Тема\" ГГГГ.ММ.ДД Оценка");
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            AddLine(topics, line, "grade", gradeFile);
        }

        static void AddLine(List<StudentTopic> topics, string line, string type, string filePath)
        {
            try
            {
                var topic = Parser.Parse(line, type);
                topics.Add(topic);
                FileService.Append(topic, filePath);
                Console.WriteLine("Добавлено в " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}