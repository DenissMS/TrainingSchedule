using System;
using System.Linq;
using System.Windows.Forms;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс формы редактирования упражнения
    /// </summary>
    public partial class ExerciseEditForm : Form
    {
        private readonly Exercise _exercise;
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public ExerciseEditForm()
        {
            InitializeComponent();
            cmbExerciseType.DataSource = EnumExtensions.GetDescriptions(typeof(ExerciseType)).ToList();
            cmbExerciseMuscleGroup.DataSource = EnumExtensions.GetDescriptions(typeof(MuscleGroup)).ToList();
        }
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="exercise">объект упражнения</param>
        public ExerciseEditForm(Exercise exercise)
        {
            InitializeComponent();

            _exercise = exercise;
            tbExerciseName.Text = exercise.Name;
            cmbExerciseType.DataSource = EnumExtensions.GetDescriptions(typeof(ExerciseType)).ToList();
            cmbExerciseType.Text = exercise.Type.GetDescription();
            cmbExerciseMuscleGroup.DataSource = EnumExtensions.GetDescriptions(typeof(MuscleGroup)).ToList();
            cmbExerciseMuscleGroup.Text = exercise.MuscleGroup.GetDescription();
            nudNumberOfRepetitions.Value = exercise.NumberOfRepetitions;
            nudNumberOfApproaches.Value = exercise.NumberOfApproaches;
        }
        /// <summary>
        /// Метод, вызывающийся при нажатии кнопки сохранения. Сохраняет упражнение или создает новое.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var exercise = new Exercise
            {
                Name = tbExerciseName.Text,
                Type = EnumExtensions.GetValue<ExerciseType>(cmbExerciseType.Text),
                MuscleGroup = EnumExtensions.GetValue<MuscleGroup>(cmbExerciseMuscleGroup.Text),
                NumberOfApproaches = (int) nudNumberOfApproaches.Value,
                NumberOfRepetitions = (int) nudNumberOfRepetitions.Value
            };
            if (_exercise == null)
                TrainingScheduleForm.SelectedTraining.Training.Exercises.Add(exercise);
            else
            {
                TrainingScheduleForm.SelectedTraining.Training.Exercises.Remove(TrainingScheduleForm.SelectedExercise);
                TrainingScheduleForm.SelectedTraining.Training.Exercises.Add(exercise);
                TrainingScheduleForm.SelectedExercise = exercise;
            }
            Close();
        }
        /// <summary>
        /// Метод, вызывающийся при нажатии кнопки отмены. Закрывает форму
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
