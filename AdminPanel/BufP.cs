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
    public partial class BufP : Form
    {
        public BufP()
        {
            InitializeComponent();
        }

        private void BufP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet7.ParticipantsBuffer". При необходимости она может быть перемещена или удалена.
            this.participantsBufferTableAdapter.Fill(this.filmBDDataSet7.ParticipantsBuffer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.participantsBufferTableAdapter.Update(this.filmBDDataSet7);
        }
    }
}
