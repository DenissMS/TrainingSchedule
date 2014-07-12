using System.Xml.Serialization;

namespace TrainingSchedule
{
    [XmlRoot(Global.EXERCISES_DATABASE, Namespace = Global.XML_NAMESPACE, IsNullable = false)]
    public class Exercises : DataModel
    {
        /// <summary>
        /// Массив данных упражнений.
        /// </summary>
        [XmlArray(Global.EXERCISES)] 
        public Exercise[] ExercisesCollection;
        /// <summary>
        /// Сохраняет данных упражнений.
        /// </summary>
        public void SaveData()
        {
            SaveData(Configuration.ExercisesDataPath);
        }
        /// <summary>
        /// Выполняет загрузку данных упражнений.
        /// </summary>
        /// <param name="path">Путь к файлу данных.</param>
        /// <returns>Возвращает объект данных динамического типа.</returns>
        public static dynamic LoadData(string path)
        {
            return LoadData(typeof(Exercises), path);
        }
    }
}
