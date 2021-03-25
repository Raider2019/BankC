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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BDDataSet.Sum". При необходимости она может быть перемещена или удалена.
            this.SumTableAdapter.Fill(this.BDDataSet.Sum);


            this.reportViewer1.RefreshReport();
        }

        private void кліентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fClients f = new fClients();
            f.Show();
            this.Hide();
        }
    }
}
