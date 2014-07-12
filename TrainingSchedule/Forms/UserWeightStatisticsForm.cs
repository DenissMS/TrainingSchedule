using System.Windows.Forms;

namespace TrainingSchedule.Forms
{
    public partial class UserWeightStatisticsForm : Form
    {
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="user"></param>
        public UserWeightStatisticsForm(User user)
        {
            InitializeComponent();
            foreach (var item in user.WeightStatistics)
            {
                dgvUserStatistics.Rows.Add(item.Date.ToString("dd.MM.yy"), item.Weight);
            }
        }
        /// <summary>
        /// Закрывает форму.
        /// </summary>
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
