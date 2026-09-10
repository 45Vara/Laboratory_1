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

            StreamReader reader = new StreamReader("topic.txt");

            while (true)
            {
                if (reader.EndOfStream == true)
                {
                    break;
                }

                string line = reader.ReadLine();

                string[] parts = line.Split('"');

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
                    Console.WriteLine("Неправильный формат.");
                }
            }
        }
        
        static StudentTopic Parse(string line){

            string[] parts = line.Split('"');

            string name = parts[1];

            string topic = parts[3];

            string dateStr = parts[4].Trim();

            DateTime date = DateTime.ParseExact(dateStr, "yyyy.MM.dd", null);

            return new StudentTopic(name, topic, date);
        }

        static int F(List<int> numders)
        {
            int max = 0;
            for (int i = 0;  i < numders.Count; i++)
            {
                int num = numders[i];
                int num1 = numders[i+1];
                int num2 = numders[i+2];

                int sum = num + num1 + num2;

                if(sum > max)
                {
                    max = sum;
                }

            }
            return max;
        }

    }
}
