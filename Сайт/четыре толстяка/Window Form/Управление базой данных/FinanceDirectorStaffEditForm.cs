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
    public partial class ExDirectorStaffEditForm : Form
    {
        public ExDirectorStaffEditForm()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bakeryDBDataSet);

        }

        private void FinanceDirectorStaffEditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bakeryDBDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.bakeryDBDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bakeryDBDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.bakeryDBDataSet.Staff);

        }

        private void staffBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
