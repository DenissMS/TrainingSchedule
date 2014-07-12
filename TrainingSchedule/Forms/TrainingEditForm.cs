using System.Windows.Forms;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс формы добавления тренировки
    /// </summary>
    public partial class TrainingEditForm : Form
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public TrainingEditForm()
        {
            InitializeComponent();
            foreach (var training in Configuration.Current.Trainings.TrainingsCollection)
            {
                lbTrainingsList.Items.Add(training);
            }
        }
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        private void SelectTraining()
        {
            var training = new ScheduledTraining
            {
                Training = (Training) lbTrainingsList.SelectedItem,
                Date = TrainingScheduleForm.SelectedDate
            };
            TrainingScheduleForm.SelectedUser.ScheduledTrainings.Add(training);
            TrainingScheduleForm.SelectedTraining = training;
        }
        /// <summary>
        /// Метод, вызывающийся при нажатии на кнопку "Выбрать". Выбирает тренировку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            SelectTraining();
            Close();
        }
        /// <summary>
        /// Метод, вызывающийся при нажатии кнопки отмены. Закрывает форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Метод, вызывающийся при двойном нажатии на элемент списка тренировок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTrainingsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectTraining();
            Close();
        }
    }
}
