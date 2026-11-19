using System;

namespace lab1
{
    /// <summary>
    /// Класс темы с дополнительным полем оценки.
    /// Наследуется от <see cref="StudentTopic"/>.
    /// </summary>
    public class StudentTopicGrade : StudentTopic
    {
        /// <summary>
        /// Оценка за работу (от 2 до 5).
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// Конструктор темы с оценкой.
        /// </summary>
        /// <param name="nameStudent">Имя студента.</param>
        /// <param name="studentsTopic">Название темы.</param>
        /// <param name="date">Дата выдачи.</param>
        /// <param name="grade">Оценка (целое число).</param>
        public StudentTopicGrade(string nameStudent, string studentsTopic, DateTime date, int grade)
            : base(nameStudent, studentsTopic, date)
        {
            Grade = grade;
        }
    }
}
