using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class fBank : Form
    {
        public fBank()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Відділеня". При необходимости она может быть перемещена или удалена.
            this.відділеняTableAdapter.Fill(this.bDDataSet.Відділеня);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Кліенти". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Працівники". При необходимости она может быть перемещена или удалена.
            this.працівникиTableAdapter.Fill(this.bDDataSet.Працівники);
           
    

        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.MovePrevious();
        }

        private void btAddOtd_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.AddNew();

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.MoveNext();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

            відділеняBindingSource.EndEdit();
            відділеняTableAdapter.Update(bDDataSet.Відділеня);
            MessageBox.Show("ОК");

        }

        private void btDelOtd_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.RemoveCurrent();
        }

        private void btnPrevWork_Click(object sender, EventArgs e)
        {
            працівникиBindingSource.MovePrevious();
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            працівникиBindingSource.AddNew();
        }

        private void btnNextWork_Click(object sender, EventArgs e)
        {
            працівникиBindingSource.MoveNext();
        }

        private void btnUpdateWork_Click(object sender, EventArgs e)
        {
            працівникиBindingSource.EndEdit();
            працівникиTableAdapter.Update(bDDataSet.Працівники);
            MessageBox.Show("ОК");
        }

        private void btnDelWork_Click(object sender, EventArgs e)
        {
            працівникиBindingSource.RemoveCurrent();
        }








        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
          ;
            if (MessageBox.Show("Припинити роботу?", "Банк", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
           
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.відділеняBindingSource.Filter = null;
                this.відділеняTableAdapter.Fill(bDDataSet.Відділеня);
            }
            catch
            {

            }
        }

        private void btnSearchOtd_Click(object sender, EventArgs e)
        {
            відділеняBindingSource.Filter = "Адрес LIKE '" + txbSearchOtd.Text + "%'";
        }

        private void btnSearchWorker_Click(object sender, EventArgs e)
        {
            працівникиBindingSource.Filter = "ПІБ LIKE '" + txbSearchWorker.Text + "%'";
        }

        private void btnRefreshWorker_Click(object sender, EventArgs e)
        {
            try
            {

                this.працівникиBindingSource.Filter = null;
                this.працівникиTableAdapter.Fill(bDDataSet.Працівники);
            }
            catch
            {

            }
        }

        private void кліентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fClients f = new fClients();
            f.Show();
            this.Hide();
        }

      
    }
}