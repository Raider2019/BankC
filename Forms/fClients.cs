using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class fClients : Form
    {
        public fClients()
        {
            InitializeComponent();
        }



        private void fClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Вклади". При необходимости она может быть перемещена или удалена.
            this.вкладиTableAdapter.Fill(this.bDDataSet.Вклади);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Кліенти". При необходимости она может быть перемещена или удалена.
            this.кліентиTableAdapter.Fill(this.bDDataSet.Кліенти);

        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            кліентиBindingSource.MovePrevious();
        }

        private void btAddCli_Click(object sender, EventArgs e)
        {
            кліентиBindingSource.AddNew();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            кліентиBindingSource.MoveNext();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            кліентиBindingSource.EndEdit();
            кліентиTableAdapter.Update(bDDataSet.Кліенти);
            MessageBox.Show("ОК");
        }

        private void btCli_Click(object sender, EventArgs e)
        {
            кліентиBindingSource.RemoveCurrent();
        }

        private void btPrevVkl_Click(object sender, EventArgs e)
        {
            вкладиBindingSource.MovePrevious();
        }

        private void btAddVkl_Click(object sender, EventArgs e)
        {
            вкладиBindingSource.AddNew();
        }

        private void btNextVkl_Click(object sender, EventArgs e)
        {
            вкладиBindingSource.MoveNext();
        }

        private void btUpdateVkl_Click(object sender, EventArgs e)
        {
            вкладиBindingSource.EndEdit();
            вкладиTableAdapter.Update(bDDataSet.Вклади);
            MessageBox.Show("ОК");
        }

        private void btDelVkl_Click(object sender, EventArgs e)
        {
            вкладиBindingSource.RemoveCurrent();
        }

        private void RefreshCli_Click(object sender, EventArgs e)
        {
            try
            {
                кліентиBindingSource.Filter = null;
                кліентиTableAdapter.Fill(bDDataSet.Кліенти);
            }
            catch
            {

            }
        }

        private void btRefreshVkl_Click(object sender, EventArgs e)
        {
            try
            {
                вкладиBindingSource.Filter = null;
                вкладиTableAdapter.Fill(bDDataSet.Вклади);
            }
            catch
            {

            }
        }

        private void btnSearhCli_Click(object sender, EventArgs e)
        {
            кліентиBindingSource.Filter = "ПІБ LIKE '" + txSearchCli.Text + "%'";
        }

        private void btSearchVkl_Click(object sender, EventArgs e)
        {
            вкладиBindingSource.Filter = "[Термін вкладу місяці] LIKE '" + txSearhVkl.Text + "%'";
        }

        private void банкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBank f = new fBank();
            f.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void звітиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGeneral f = new fGeneral();
            f.Show();
            this.Hide();

        }

        private void доходиКліентівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportSuma f = new ReportSuma();
            f.Show();
            this.Hide();
        }
    }


}


