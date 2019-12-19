using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPanel
{
    public partial class Reiting : Form
    {
        public Reiting()
        {
            InitializeComponent();
        }

        private void Reiting_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet2.Reting". При необходимости она может быть перемещена или удалена.
            this.retingTableAdapter.Fill(this.filmBDDataSet2.Reting);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.retingTableAdapter.Update(this.filmBDDataSet2);
        }
    }
}
