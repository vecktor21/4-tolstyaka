using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Управление_базой_данных
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoginForm logForm = Program.loginForm;
            loginLabel.Text = logForm.getLogin();
        }

        private void openUsersTableFormButton_Click(object sender, EventArgs e)
        {
            UsersTableForm form = new UsersTableForm();
            form.Show();
        }

        private void editUsersButton_Click(object sender, EventArgs e)
        {
            UsersEditForm form = new UsersEditForm();
            form.Show();
        }
    }
}
