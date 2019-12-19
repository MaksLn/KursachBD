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
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }

        private void Country_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet9.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.filmBDDataSet9.Country);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.Update(this.filmBDDataSet9);
        }
    }
}
