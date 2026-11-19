using System;

namespace lab1
{
    /// <summary>
    /// Базовый класс, представляющий тему работы студента.
    /// Содержит информацию об авторе, названии темы и дате выдачи.
    /// </summary>
    public class StudentTopic
    {
        /// <summary>
        /// Имя студента (ФИО).
        /// </summary>
        public string NameStudent { get; set; }

        /// <summary>
        /// Название темы работы.
        /// </summary>
        public string StudentsTopic { get; set; }

        /// <summary>
        /// Дата выдачи задания.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Конструктор для создания новой темы.
        /// </summary>
        /// <param name="nameStudent">Имя студента (строка).</param>
        /// <param name="studentsTopic">Название темы (строка).</param>
        /// <param name="date">Дата выдачи (объект DateTime).</param>
        public StudentTopic(string nameStudent, string studentsTopic, DateTime date)
        {
            NameStudent = nameStudent;
            StudentsTopic = studentsTopic;
            Date = date;
        }
    }
}
