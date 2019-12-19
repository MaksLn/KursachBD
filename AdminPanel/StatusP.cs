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
    public partial class StatusP : Form
    {
        public StatusP()
        {
            InitializeComponent();
        }

        private void StatusP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "filmBDDataSet5.StatusParticipants". При необходимости она может быть перемещена или удалена.
            this.statusParticipantsTableAdapter.Fill(this.filmBDDataSet5.StatusParticipants);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.statusParticipantsTableAdapter.Update(this.filmBDDataSet5);
        }
    }
}
