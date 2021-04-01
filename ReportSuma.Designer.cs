
namespace Bank
{
    partial class ReportSuma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.кліентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rep1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDDataSet1 = new Bank.BDDataSet();
            this.sumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumTableAdapter1 = new Bank.BDDataSetTableAdapters.SumTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кліентиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // кліентиToolStripMenuItem
            // 
            this.кліентиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кліентиToolStripMenuItem.Name = "кліентиToolStripMenuItem";
            this.кліентиToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.кліентиToolStripMenuItem.Text = "Кліенти";
            this.кліентиToolStripMenuItem.Click += new System.EventHandler(this.кліентиToolStripMenuItem_Click);
            // 
            // Rep1
            // 
            this.Rep1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SumaReport";
            reportDataSource1.Value = this.sumBindingSource;
            this.Rep1.LocalReport.DataSources.Add(reportDataSource1);
            this.Rep1.LocalReport.ReportEmbeddedResource = "Bank.ReportsSuma.rdlc";
            this.Rep1.Location = new System.Drawing.Point(0, 29);
            this.Rep1.Name = "Rep1";
            this.Rep1.ServerReport.BearerToken = null;
            this.Rep1.Size = new System.Drawing.Size(817, 450);
            this.Rep1.TabIndex = 1;
            // 
            // bDDataSet1
            // 
            this.bDDataSet1.DataSetName = "BDDataSet";
            this.bDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sumBindingSource
            // 
            this.sumBindingSource.DataMember = "Sum";
            this.sumBindingSource.DataSource = this.bDDataSet1;
            // 
            // sumTableAdapter1
            // 
            this.sumTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(817, 479);
            this.Controls.Add(this.Rep1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(833, 518);
            this.Name = "ReportSuma";
            this.Text = "Заіт доходи кіентів";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem кліентиToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer Rep1;
        private BDDataSet bDDataSet1;
        private System.Windows.Forms.BindingSource sumBindingSource;
        private BDDataSetTableAdapters.SumTableAdapter sumTableAdapter1;
    }
}