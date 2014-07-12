using System;
using System.Windows.Forms;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс для редактирования информации пользователя.
    /// </summary>
    public partial class UserListForm : Form
    {
        private ProfileEditForm _editForm;
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public UserListForm()
        {
            InitializeComponent();
            UpdateUserList();
        }
        /// <summary>
        /// Обновляет список пользователей.
        /// </summary>
        private void UpdateUserList()
        {
            lbUserList.Items.Clear();
            foreach (var user in Configuration.Current.Users.UsersCollection)
            {
                lbUserList.Items.Add(user);
            }
        }
        /// <summary>
        /// Выбирает активного пользователя.
        /// </summary>
        private void SelectUser()
        {
            TrainingScheduleForm.SelectedUser = (User)lbUserList.SelectedItem;
        }
        /// <summary>
        /// Открывает форму редактирования профиля пользователя.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _editForm  = new ProfileEditForm();
            _editForm.FormClosing += ProfileEditForm_FormClosing;
            _editForm.Show();
        }
        /// <summary>
        /// Открывает форму редактирования профиля пользователя и загружает редактируемые данные.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbUserList.SelectedItem != null)
            {
                _editForm = new ProfileEditForm((User) lbUserList.SelectedItem);
                _editForm.FormClosing += ProfileEditForm_FormClosing;
                _editForm.Show();
            }
        }
        /// <summary>
        /// Обновляет список пользователей. Вызывается при закрытии формы ProfileEditForm.
        /// </summary>
        private void ProfileEditForm_FormClosing(object sender, EventArgs e)
        {
            UpdateUserList();
        }
        /// <summary>
        /// Удаляет выбранного пользователя из базы данных.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Configuration.Current.Users.UsersCollection.Remove((User) lbUserList.SelectedItem);
            UpdateUserList();
        }
        /// <summary>
        /// Выбирает текущего пользователя и закрывает форму.
        /// </summary>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectUser();
            Close();
        }
        /// <summary>
        /// Выбирает текущего пользователя и закрывает форму.
        /// </summary>
        private void lbUserList_DoubleClick(object sender, EventArgs e)
        {
            SelectUser();
            Close();
        }
    }
}
