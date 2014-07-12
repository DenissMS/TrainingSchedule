using System.Collections.Generic;

namespace TrainingSchedule
{
    /// <summary>
    /// Модель данных, описывающая тренировки.
    /// </summary>
    public class Training
    {
        /// <summary>
        /// Свойство, описывающее количество упражнений.
        /// </summary>
        public int NumberOfExercises
        {
            get { return Exercises.Count; }
        }
        /// <summary>
        /// Тип тренировок.
        /// </summary>
        public TrainingType Type { get; set; }
        /// <summary>
        /// Коллекция упражнений.
        /// </summary>
        public List<Exercise> Exercises { get; set; }
        /// <summary>
        /// Метод, переопределяющий стандартную реализацию метода ToString().
        /// </summary>
        /// <returns>Возвращает строку.</returns>
        public override string ToString()
        {
            return string.Format("{0}. {1} упр.", Type.GetDescription(), NumberOfExercises);
        }
    }
}
