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
    public partial class Films : Form
    {
        public Form1 Form1 { get; set; }
        public Films()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Cut"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }

        private void Films_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet.Films". При необходимости она может быть перемещена или удалена.
            this.filmsTableAdapter.Fill(this.filmBDDataSet.Films);
            this.dataGridView1.Size = new Size(this.Width - 30, this.Height-100);
            this.SizeChanged += (r, x) => { this.dataGridView1.Size = new Size(this.Width - 30, this.Height - 100); };
            this.FormClosed += (r, x) => { this.Form1.Close(); };
            this.dataGridView1.MouseClick += dataGridView1_MouseClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.filmsTableAdapter.Update(this.filmBDDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var part = new Part();
            part.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var part = new Reiting();
            part.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var part = new MPAA();
            part.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var part = new Year();
            part.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var part = new StatusP();
            part.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var part = new Ganre();
            part.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var part = new BufP();
            part.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var part = new GanreToFilms();
            part.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var part = new Country();
            part.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var part = new CountryToFilms();
            part.ShowDialog();
        }
    }
}
