using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс формы редактирования профилей
    /// </summary>
    public partial class ProfileEditForm : Form
    {
        private readonly User _user;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public ProfileEditForm()
        {
            InitializeComponent();
            _user = new User
            {
                WeightStatistics = new List<User.Record>()
            };
            Configuration.Current.Users.UsersCollection.Add(_user);
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="user"></param>
        public ProfileEditForm(User user)
        {
            InitializeComponent();
            _user = user;
            tbName.Text = user.Name;
            nudHeight.Value = user.Height;
            nudWeight.Value = user.Weight;
        }
        /// <summary>
        /// Метод, вызывающийся при нажатии кнопки сохранения
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.Name = tbName.Text;
            _user.Height = nudHeight.Value;
            if (_user.Weight != nudHeight.Value)
            {
                _user.WeightStatistics.Add(new User.Record(DateTime.Now, nudWeight.Value));
            }
            _user.Weight = nudWeight.Value;
            Configuration.Current.Users.SaveData(Configuration.UsersDataPath);
            Close();
        }
        /// <summary>
        /// Метод, вызывающийся при нажатии кноки отмены
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
