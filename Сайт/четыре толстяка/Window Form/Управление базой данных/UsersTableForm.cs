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
    public partial class UsersTableForm : Form
    {
        public UsersTableForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersPredBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bakeryDBDataSet);

        }

        private void UsersTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bakeryDBDataSet.usersPred". При необходимости она может быть перемещена или удалена.
            this.usersPredTableAdapter.Fill(this.bakeryDBDataSet.usersPred);

        }
    }
}
