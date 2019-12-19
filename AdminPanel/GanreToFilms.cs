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
    public partial class GanreToFilms : Form
    {
        public GanreToFilms()
        {
            InitializeComponent();
        }

        private void GanreToFilms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet8.FilmsToGenres". При необходимости она может быть перемещена или удалена.
            this.filmsToGenresTableAdapter.Fill(this.filmBDDataSet8.FilmsToGenres);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.filmsToGenresTableAdapter.Update(this.filmBDDataSet8);
        }
    }
}
