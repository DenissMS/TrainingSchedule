using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrainingSchedule
{
    /// <summary>
    /// Модель данных, содержащяя информацию о пользователе, его тренировках и статистике веса.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Класс, описывающий запись в таблице веса.
        /// </summary>
        public class Record
        {
            /// <summary>
            /// Дата записи.
            /// </summary>
            [XmlAttribute]
            public DateTime Date { get; set; }
            /// <summary>
            /// Значение веса.
            /// </summary>
            [XmlAttribute]
            public decimal Weight { get; set; }
            /// <summary>
            /// Беспараметрический конструктор класса.
            /// </summary>
            public Record() { }
            /// <summary>
            /// Конструктор класса.
            /// </summary>
            /// <param name="date"></param>
            /// <param name="weight"></param>
            public Record(DateTime date, decimal weight)
            {
                Date = date;
                Weight = weight;
            }
        }
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        [XmlAttribute]
        public int Id { get; set; }
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Вес пользователя.
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// Высота пользователя.
        /// </summary>
        public decimal Height { get; set; }
        /// <summary>
        /// Коллкция записей о весе пользователя.
        /// </summary>
        public List<Record> WeightStatistics { get; set; }
        /// <summary>
        /// Коллекция тренировок пользователя.
        /// </summary>
        [XmlArray(Global.SCHEDULED_TRAININGS)]
        [XmlArrayItem(Global.TRAINING)]
        public List<ScheduledTraining> ScheduledTrainings;
        /// <summary>
        /// Метод переопределяющий стандартную реализацию метода ToString().
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
