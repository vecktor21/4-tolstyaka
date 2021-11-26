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
    public partial class CakeRedactorForm : Form
    {
        public CakeRedactorForm()
        {
            InitializeComponent();
        }

        private void cakesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cakesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bakeryDBDataSet);

        }

        private void CakeRedactorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bakeryDBDataSet.Cakes". При необходимости она может быть перемещена или удалена.
            this.cakesTableAdapter.Fill(this.bakeryDBDataSet.Cakes);

        }
    }
}
