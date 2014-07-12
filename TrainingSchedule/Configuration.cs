using System.Configuration;

namespace TrainingSchedule
{
    public class Configuration
    {
        /// <summary>
        /// Путь к файлу данных пользователей по умолчанию.
        /// </summary>
        public const string DEFAULT_USERS_DATA_PATH = "Users.xml";
        /// <summary>
        /// Путь к файлу данных тренировок по умолчанию.
        /// </summary>
        public const string DEFAULT_TRAININGS_DATA_PATH = "Trainings.xml";
        /// <summary>
        /// Путь к файлу данных упражнений по умолчанию.
        /// </summary>
        public const string DEFAULT_EXERCISES_DATA_PATH = "Exercises.xml";
        /// <summary>
        /// Путь к файлу данных пользователей.
        /// </summary>
        public static string UsersDataPath = DEFAULT_USERS_DATA_PATH;
        /// <summary>
        /// Путь к файлу данных тренировок.
        /// </summary>
        public static string TrainingsDataPath = DEFAULT_TRAININGS_DATA_PATH;
        /// <summary>
        /// Путь к файлу данных упражнений.
        /// </summary>
        public static string ExercisesDataPath = DEFAULT_EXERCISES_DATA_PATH;

        public Users Users;
        public Trainings Trainings;
        public Exercises Exercises;
        /// <summary>
        /// Статический объект, хранящиий конфигурацию приложения.
        /// </summary>
        private static Configuration _currentConfiguration;

        public static Configuration Current
        {
            get { return _currentConfiguration ?? (_currentConfiguration = LoadConfiguration()); }
        }
        /// <summary>
        /// Загружает конфигурацию, состоящую из трех файлов данных.
        /// </summary>
        /// <returns>Возвращает объект конфигурации.</returns>
        private static Configuration LoadConfiguration()
        {
            ExercisesDataPath = ConfigurationManager.AppSettings[Global.EXERCISES_DATA_PATH];
            TrainingsDataPath = ConfigurationManager.AppSettings[Global.TRAININGS_DATA_PATH];
            UsersDataPath = ConfigurationManager.AppSettings[Global.USERS_DATA_PATH];

            var configuration = new Configuration
            {
                Users = Users.LoadData(UsersDataPath),
                Trainings = Trainings.LoadData(TrainingsDataPath),
                Exercises = Exercises.LoadData(ExercisesDataPath)
            };
            return configuration;
        }
    }
}
