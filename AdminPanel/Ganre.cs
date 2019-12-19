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
    public partial class Ganre : Form
    {
        public Ganre()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ganre_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet6.Genre". При необходимости она может быть перемещена или удалена.
            this.genreTableAdapter.Fill(this.filmBDDataSet6.Genre);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.genreTableAdapter.Update(this.filmBDDataSet6);
        }
    }
}
