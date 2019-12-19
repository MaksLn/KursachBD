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
    public partial class CountryToFilms : Form
    {
        public CountryToFilms()
        {
            InitializeComponent();
        }

        private void CountryToFilms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet10.FilmsToCountrys". При необходимости она может быть перемещена или удалена.
            this.filmsToCountrysTableAdapter.Fill(this.filmBDDataSet10.FilmsToCountrys);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.filmsToCountrysTableAdapter.Update(this.filmBDDataSet10);
        }
    }
}
