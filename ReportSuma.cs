using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class ReportSuma : Form
    {
        public ReportSuma()
        {
            InitializeComponent();
        }


        private void ReportSuma_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Sum". При необходимости она может быть перемещена или удалена.
            this.sumTableAdapter.Fill(this.bDDataSet.Sum);

        }
        private void кліентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fClients f = new fClients();
            f.Show();
            this.Hide();
        }

       
    }
}
