using System;
using System.IO;
using System.Xml.Serialization;

namespace TrainingSchedule
{
    /// <summary>
    /// Базовая модель данных
    /// </summary>
    public class DataModel
    {
        /// <summary>
        /// Сохраняет данные по заданному пути
        /// </summary>
        /// <param name="path">Путь сохранения</param>
        public void SaveData(string path)
        {
            var serializer = new XmlSerializer(GetType());
            using (var fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, this);
            }
        }
        /// <summary>
        /// Загружает и десериализует данные в объектную форму по заданному пути
        /// </summary>
        /// <param name="type">Тип данных</param>
        /// <param name="path">Путь к файлу данных</param>
        /// <returns>Возвращает объект динамического типа</returns>
        public static dynamic LoadData(Type type, string path)
        {
            var serializer = new XmlSerializer(type);
            using (var fs = new FileStream(path, FileMode.Open))
            {
                return serializer.Deserialize(fs);
            }
        }
    }
}
