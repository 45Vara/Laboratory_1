using System;

namespace lab1
{
    /// <summary>
    /// Класс темы с дополнительным полем группы.
    /// Наследуется от <see cref="StudentTopic"/>.
    /// </summary>
    public class StudentTopicGroup : StudentTopic
    {
        /// <summary>
        /// Название группы (например, "КИ-21").
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Конструктор темы с группой.
        /// </summary>
        /// <param name="nameStudent">Имя студента.</param>
        /// <param name="studentsTopic">Название темы.</param>
        /// <param name="date">Дата выдачи.</param>
        /// <param name="group">Название группы.</param>
        public StudentTopicGroup(string nameStudent, string studentsTopic, DateTime date, string group)
            : base(nameStudent, studentsTopic, date)
        {
            Group = group;
        }
    }
}
