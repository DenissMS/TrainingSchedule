using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrainingSchedule
{
    /// <summary>
    /// Модель данных информации о пользователях.
    /// </summary>
    [XmlRoot(Global.USERS_DATABASE, Namespace = Global.XML_NAMESPACE, IsNullable = false)]
    public class Users : DataModel
    {
        /// <summary>
        /// Выполняет загрузку и дезериализацию данных типа Users.
        /// </summary>
        /// <param name="path">Путь к файлу данных.</param>
        /// <returns>Возвращает объект данных динамического типа.</returns>
        [XmlArray(Global.USERS)] [XmlArrayItem(Global.USER)] public List<User> UsersCollection;
        /// <summary>
        /// Сохраняет данных упражнений
        /// </summary>
        public void SaveData()
        {
            SaveData(Configuration.UsersDataPath);
        }
        /// <summary>
        /// Выполняет загрузку данных пользователей.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static dynamic LoadData(string path)
        {
            return LoadData(typeof(Users), path);
        }
    }
}
