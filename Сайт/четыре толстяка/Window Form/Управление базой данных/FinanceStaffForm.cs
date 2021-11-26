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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            LoginForm logForm = Program.loginForm;
            this.loginLabel.Text = logForm.getLogin();
        }

        private void StaffFormOpenButton_Click(object sender, EventArgs e)
        {
            DirectorStaffForm directorStaffForm = new DirectorStaffForm();
            directorStaffForm.Show();
        }
    }
}
