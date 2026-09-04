using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        public List<StudentTopic> L = new List<StudentTopic>();
        static void Main(string[] args)
        {
        }
        public void SortbyName(string name, List<StudentTopic> L)
        {
            foreach (var i in L)
            {
                if (i.NameStudent == name)
                {
                    Console.WriteLine(i.StusentsTopic);
                }
            }
        }
    }
}
