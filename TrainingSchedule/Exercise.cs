using System.Xml.Serialization;

namespace TrainingSchedule
{
    /// <summary>
    /// Модель данных упражнений
    /// </summary>
    public class Exercise
    {
        /// <summary>
        /// Название упражнения.
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }
        /// <summary>
        /// Тип упражнения.
        /// </summary>
        [XmlAttribute]
        public ExerciseType Type { get; set; }
        /// <summary>
        /// Группа мышц.
        /// </summary>
        public MuscleGroup MuscleGroup { get; set; }
        /// <summary>
        /// Количество повторов.
        /// </summary>
        public int NumberOfRepetitions { get; set; }
        /// <summary>.
        /// Количество подходов
        /// </summary>
        public int NumberOfApproaches { get; set; }
        /// <summary>
        /// Метод, переопределяющий стандартную реализацию метода ToString().
        /// </summary>
        /// <returns>Возвращает строку.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
