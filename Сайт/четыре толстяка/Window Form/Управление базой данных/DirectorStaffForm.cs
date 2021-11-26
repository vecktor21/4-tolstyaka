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
    public partial class DirectorStaffForm : Form
    {
        public DirectorStaffForm()
        {
            InitializeComponent();
        }

        private void DirectorStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bakeryDBDataSet.staffForDirector". При необходимости она может быть перемещена или удалена.
            this.staffForDirectorTableAdapter.Fill(this.bakeryDBDataSet.staffForDirector);

        }
    }
}
