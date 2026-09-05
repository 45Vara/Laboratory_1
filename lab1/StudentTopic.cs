using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class StudentTopic
    {
        public string NameStudent { get; set; }
        public string StudentsTopic { get; set; }
        public DateTime Date {  get; set; }

        public StudentTopic(string nameStudent, string stusentTopic, DateTime date)
        {
            NameStudent = nameStudent;
            StudentsTopic = stusentTopic;
            Date = date;
        }
    }
}
