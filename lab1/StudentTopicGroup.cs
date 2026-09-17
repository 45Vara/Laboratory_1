using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class StudentTopicGroup : StudentTopic
    {
        public string Group {  get; set; }

        public StudentTopicGroup(string nameStudent, string stusentTopic, DateTime date, string group)
            :base(nameStudent, stusentTopic, date)
        {
            Group = group;
        }
    }
}
