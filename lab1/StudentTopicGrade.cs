using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class StudentTopicGrade : StudentTopic
    {
        public int Grade {  get; set; }

        public StudentTopicGrade(string nameStudent, string stusentTopic, DateTime date, int grade)
            : base(nameStudent, stusentTopic, date)
        {
            Grade = grade;
        }
    }
}
