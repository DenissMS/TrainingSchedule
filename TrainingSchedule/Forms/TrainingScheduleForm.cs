using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TrainingSchedule.Forms;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс основной формы программы
    /// </summary>
    public partial class TrainingScheduleForm : Form
    {
        public static User SelectedUser;
        public static ScheduledTraining SelectedTraining;
        public static Exercise SelectedExercise;
        public static DateTime SelectedDate;
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TrainingScheduleForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, который обновляет список упражнений выбранной тренировки
        /// </summary>
        private void UpdateExercisesList()
        {
            lbExercisesList.Items.Clear();

            foreach (var exercise in from user 
                                         in Configuration.Current.Users.UsersCollection 
                                     where user == SelectedUser from training 
                                         in user.ScheduledTrainings 
                                     where training.Date == SelectedDate from exercise 
                                         in training.Training.Exercises select exercise)
            {
                lbExercisesList.Items.Add(exercise);
            }
        }
        /// <summary>
        /// Метод, который обновляет информацию о пользователе на форме.
        /// </summary>
        private void UpdateUserInfo()
        {
            if (SelectedUser == null) return;
            lUserName.Text = SelectedUser.Name;
            lUserHeightValue.Text = SelectedUser.Height.ToString(CultureInfo.InvariantCulture);
            lUserWeightValue.Text = SelectedUser.Weight.ToString(CultureInfo.InvariantCulture);
            btnAddExercise.Enabled = true;
            btnEditExercise.Enabled = true;
            btnCreateTraining.Enabled = true;
            btnRemoveExercise.Enabled = true;
            btnClearAll.Enabled = true;
            lbExercisesList.Enabled = true;
            mcTrainingCalendar.Enabled = true;
            btnStatistics.Enabled = true;
        }
        /// <summary>
        /// Метод, который обновляет информацию о выбранном упражнении и отображает на форме.
        /// </summary>
        /// <param name="exercise">объект упражнения</param>
        private void UpdateExercise(Exercise exercise)
        {
            lExerciseNameValue.Text = exercise.Name;
            lExerciseTypeValue.Text = exercise.Type.GetDescription();
            lExerciseMuscleGroupValue.Text = exercise.MuscleGroup.GetDescription();
            lExerciseNumberOfApproachesValue.Text =
                exercise.NumberOfApproaches.ToString(CultureInfo.InvariantCulture);
            lExerciseNumberOfRepetitionsValue.Text =
                exercise.NumberOfRepetitions.ToString(CultureInfo.InvariantCulture);
        }
        /// <summary>
        /// Метод, который очищает информацию об упражнении
        /// </summary>
        private void ClearExercise()
        {
            const string dash = "--";
            lExerciseNameValue.Text = dash;
            lExerciseTypeValue.Text = dash;
            lExerciseMuscleGroupValue.Text = dash;
            lExerciseNumberOfApproachesValue.Text = dash;
            lExerciseNumberOfRepetitionsValue.Text = dash;
        }
        /// <summary>
        /// Метод для тестирования конфигураций
        /// </summary>
        public void TestConfig()
        {
            var exercise = new Exercise
            {
                MuscleGroup = MuscleGroup.Press,
                Name = "Брюшной пресс",
                NumberOfApproaches = 5,
                NumberOfRepetitions = 3,
                Type = ExerciseType.DynamicStrength,
            };

            var exercise1 = new Exercise
            {
                MuscleGroup = MuscleGroup.Feet,
                Name = "Бег на месте",
                NumberOfApproaches = 5,
                NumberOfRepetitions = 3,
                Type = ExerciseType.Aerobic
            };
            var exercises = new Exercises
            {
                ExercisesCollection = new[]
                {
                    exercise, 
                    exercise1
                }
            };
            exercises.SaveData(Configuration.DEFAULT_EXERCISES_DATA_PATH);
            var training = new Training
            {
                Exercises = new List<Exercise>
                {
                    exercise,
                    exercise1
                },
                Type = TrainingType.Cardio
            };
            var trainings = new Trainings
            {
                TrainingsCollection = new[]
                {
                    training,
                }
            };
            trainings.SaveData(Configuration.DEFAULT_TRAININGS_DATA_PATH);
            var users = new Users
            {
                UsersCollection = new List<User>
                {
                    new User
                    {
                        Name = "Денис Иванов",
                        Height = 183,
                        Weight = 75,
                        ScheduledTrainings = new List<ScheduledTraining>
                        {
                            new ScheduledTraining
                            {
                                Training = training,
                                Date = new DateTime(2014, 02, 12)
                            },
                            new ScheduledTraining
                            {
                                Training = training,
                                Date = new DateTime(2014, 02, 13)
                            }
                        }
                    }
                }
            };
            users.SaveData(Configuration.DEFAULT_USERS_DATA_PATH);
        }
        /// <summary>
        /// Метод, который отрывает форму редактирования профиля. Выполняется при нажатии на кнопку "Изменить".
        /// </summary>
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            var userListForm = new UserListForm();
            userListForm.FormClosing += UserListForm_FormClosing;
            userListForm.Show();
        }
        /// <summary>
        /// Метод, который вызывается при закрытии формы UserListForm.
        /// </summary>
        private void UserListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateUserInfo();
        }
        /// <summary>
        /// Метод, который вызывается при закрытии формы редактирования тренировки.
        /// </summary>
        private void TrainingEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateExercisesList();
            Configuration.Current.Users.SaveData(Configuration.UsersDataPath);
            btnCreateTraining.Enabled = false;
        }
        /// <summary>
        /// Метод, который вызывается при закрытии формы редактирования упражнения. Обновляет список упражнений и сохраняет данные пользователя.
        /// </summary>
        private void ExerciseEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateExercisesList();
            if (SelectedExercise != null)
                UpdateExercise(SelectedExercise);
            Configuration.Current.Users.SaveData();
        }
        /// <summary>
        /// Обновляет информацию о выбранном упражнении
        /// </summary>
        private void lbExercisesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedExercise = (Exercise) lbExercisesList.SelectedItem;
            foreach (var exercise in SelectedTraining.Training.Exercises)
            {
                if (exercise == SelectedExercise)
                {
                    UpdateExercise(exercise);
                }
            }
        }
        /// <summary>
        /// Открывает форму редактирования тренировки
        /// </summary>
        private void btnCreateTraining_Click(object sender, EventArgs e)
        {
            var editForm = new TrainingEditForm();
            editForm.FormClosing += TrainingEditForm_FormClosing;
            editForm.Show();
        }
        /// <summary>
        /// Вызывается при выборе новой даты в календаре.
        /// </summary>
        private void mcTrainingCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = mcTrainingCalendar.SelectionRange.Start;
            lbExercisesList.Items.Clear();
            if (SelectedUser == null) return;
            foreach (var training in SelectedUser.ScheduledTrainings.Where(training => training.Date == SelectedDate))
            {
                SelectedTraining = training;
                btnCreateTraining.Enabled = false;
                UpdateExercisesList();
                return;
            }
            btnCreateTraining.Enabled = true;
        }
        /// <summary>
        /// Открывает форму редактирования упражнения.
        /// </summary>
        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            var editForm = new ExerciseEditForm();
            editForm.FormClosing += ExerciseEditForm_FormClosing;
            editForm.Show();
        }
        /// <summary>
        /// Удаляет выбранное упражнение
        /// </summary>
        private void btnRemoveExercise_Click(object sender, EventArgs e)
        {
            var index = SelectedTraining.Training.Exercises.IndexOf(SelectedExercise);
            SelectedTraining.Training.Exercises.RemoveAt(index>0?index:0);
            UpdateExercisesList();
            if(lbExercisesList.Items.Count > index)
                lbExercisesList.SelectedIndex = index;
            else
            {
                lbExercisesList.SelectedIndex = lbExercisesList.Items.Count - 1;
            }
            
            UpdateExercise(SelectedExercise);
            Configuration.Current.Users.SaveData();
        }
        /// <summary>
        /// Открывает форму редактирования выбранного упражнения.
        /// </summary>
        private void btnEditExercise_Click(object sender, EventArgs e)
        {
            var editForm = new ExerciseEditForm(SelectedExercise);
            editForm.FormClosing += ExerciseEditForm_FormClosing;
            editForm.Show();
        }
        /// <summary>
        /// Полностью удаляет все записи в календаре. Очищает форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            SelectedUser.ScheduledTrainings.Clear();
            lbExercisesList.Items.Clear();
            ClearExercise();
        }
        /// <summary>
        /// Отображает форму статистики веса пользователя.
        /// </summary>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var statisticsForm = new UserWeightStatisticsForm(SelectedUser);
            statisticsForm.Show();
        }
    }
}
