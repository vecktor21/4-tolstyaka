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
    public partial class TechnologForm : Form
    {
        public TechnologForm()
        {
            InitializeComponent();
        }

        private void TechnologForm_Load(object sender, EventArgs e)
        {
            LoginForm logForm = Program.loginForm;
            this.loginLabel.Text = logForm.getLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExDirectorStaffEditForm financeDirectorStaffEditForm = new ExDirectorStaffEditForm();
            financeDirectorStaffEditForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectorStaffForm directorStaffForm = new DirectorStaffForm();
            directorStaffForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CakeRedactorForm cakeRedactorForm = new CakeRedactorForm();
            cakeRedactorForm.Show();
        }
    }
}
