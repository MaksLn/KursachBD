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
    public partial class MPAA : Form
    {
        public MPAA()
        {
            InitializeComponent();
        }

        private void MPAA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet3.MPAA". При необходимости она может быть перемещена или удалена.
            this.mPAATableAdapter.Fill(this.filmBDDataSet3.MPAA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mPAATableAdapter.Update(this.filmBDDataSet3);
        }
    }
}
