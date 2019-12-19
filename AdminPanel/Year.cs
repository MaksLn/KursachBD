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
    public partial class Year : Form
    {
        public Year()
        {
            InitializeComponent();
        }

        private void Year_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet4.CreateYear". При необходимости она может быть перемещена или удалена.
            this.createYearTableAdapter.Fill(this.filmBDDataSet4.CreateYear);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.createYearTableAdapter.Update(this.filmBDDataSet4);
        }
    }
}
