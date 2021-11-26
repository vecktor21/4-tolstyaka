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
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            LoginForm logForm = Program.loginForm;
            this.loginLabel.Text = logForm.getLogin();
        }

        private void DirectorStaffForm_Click(object sender, EventArgs e)
        {
            DirectorStaffForm form = new DirectorStaffForm();
            form.Show();
        }

        private void DirectorStaffFormEditOpenButton_Click(object sender, EventArgs e)
        {
            DirectorStaffEditForm form = new DirectorStaffEditForm();
            form.Show();
        }
    }
}
