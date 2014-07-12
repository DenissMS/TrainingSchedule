using System.Xml.Serialization;

namespace TrainingSchedule
{
    /// <summary>
    /// Модель данных тренировок
    /// </summary>
    [XmlRoot(Global.TRAININGS_DATABASE, Namespace = Global.XML_NAMESPACE, IsNullable = false)]
    public class Trainings : DataModel
    {
        /// <summary>
        /// Коллекция объектов, содержащих информацию о тренировках.
        /// </summary>
        [XmlArray(Global.TRAININGS)]
        public Training[] TrainingsCollection;
        /// <summary>
        /// Сохраняет данных тренировок.
        /// </summary>
        public void SaveData()
        {
            SaveData(Configuration.TrainingsDataPath);
        }
        /// <summary>
        /// Выполняет загрузку данных тренировок.
        /// </summary>
        /// <param name="path">Путь к файлу данных</param>
        /// <returns>Возвращает объект данных динамического типа</returns>
        public static dynamic LoadData(string path)
        {
            return LoadData(typeof(Trainings), path);
        }
    }
}
