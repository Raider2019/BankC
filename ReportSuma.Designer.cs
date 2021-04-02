
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportSuma));
            this.msReportSuma = new System.Windows.Forms.MenuStrip();
            this.кліентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbReprtSumaGrid = new System.Windows.Forms.GroupBox();
            this.sumDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new Bank.BDDataSet();
            this.gbInfoReportSuma = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lab32 = new System.Windows.Forms.Label();
            this.lab31 = new System.Windows.Forms.Label();
            this.lab30 = new System.Windows.Forms.Label();
            this.lab29 = new System.Windows.Forms.Label();
            this.lab28 = new System.Windows.Forms.Label();
            this.lab27 = new System.Windows.Forms.Label();
            this.lab26 = new System.Windows.Forms.Label();
            this.sumTableAdapter = new Bank.BDDataSetTableAdapters.SumTableAdapter();
            this.tableAdapterManager = new Bank.BDDataSetTableAdapters.TableAdapterManager();
            this.sumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msReportSuma.SuspendLayout();
            this.gbReprtSumaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.gbInfoReportSuma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumBindingNavigator)).BeginInit();
            this.sumBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // msReportSuma
            // 
            this.msReportSuma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кліентиToolStripMenuItem});
            this.msReportSuma.Location = new System.Drawing.Point(0, 0);
            this.msReportSuma.Name = "msReportSuma";
            this.msReportSuma.Size = new System.Drawing.Size(798, 29);
            this.msReportSuma.TabIndex = 0;
            this.msReportSuma.Text = "msReportSuma";
            // 
            // кліентиToolStripMenuItem
            // 
            this.кліентиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кліентиToolStripMenuItem.Name = "кліентиToolStripMenuItem";
            this.кліентиToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.кліентиToolStripMenuItem.Text = "Кліенти";
            this.кліентиToolStripMenuItem.Click += new System.EventHandler(this.кліентиToolStripMenuItem_Click);
            // 
            // gbReprtSumaGrid
            // 
            this.gbReprtSumaGrid.BackColor = System.Drawing.Color.DarkOrange;
            this.gbReprtSumaGrid.Controls.Add(this.sumDataGridView);
            this.gbReprtSumaGrid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbReprtSumaGrid.Location = new System.Drawing.Point(12, 338);
            this.gbReprtSumaGrid.Name = "gbReprtSumaGrid";
            this.gbReprtSumaGrid.Size = new System.Drawing.Size(778, 275);
            this.gbReprtSumaGrid.TabIndex = 2;
            this.gbReprtSumaGrid.TabStop = false;
            this.gbReprtSumaGrid.Text = "Звіт фінасів кліентів";
            // 
            // sumDataGridView
            // 
            this.sumDataGridView.AutoGenerateColumns = false;
            this.sumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sumDataGridView.DataSource = this.sumBindingSource;
            this.sumDataGridView.Location = new System.Drawing.Point(20, 39);
            this.sumDataGridView.Name = "sumDataGridView";
            this.sumDataGridView.Size = new System.Drawing.Size(752, 220);
            this.sumDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ПІБ";
            this.dataGridViewTextBoxColumn1.HeaderText = "ПІБ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Сума_вклада";
            this.dataGridViewTextBoxColumn2.HeaderText = "Сума_вклада";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Термін_вкладу_місяці";
            this.dataGridViewTextBoxColumn3.HeaderText = "Термін_вкладу_місяці";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Термін_вкладу_дні";
            this.dataGridViewTextBoxColumn4.HeaderText = "Термін_вкладу_дні";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Відсоток";
            this.dataGridViewTextBoxColumn5.HeaderText = "Відсоток";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Сума";
            this.dataGridViewTextBoxColumn6.HeaderText = "Сума";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Разом";
            this.dataGridViewTextBoxColumn7.HeaderText = "Разом";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // sumBindingSource
            // 
            this.sumBindingSource.DataMember = "Sum";
            this.sumBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbInfoReportSuma
            // 
            this.gbInfoReportSuma.BackColor = System.Drawing.Color.DarkOrange;
            this.gbInfoReportSuma.Controls.Add(this.textBox7);
            this.gbInfoReportSuma.Controls.Add(this.textBox6);
            this.gbInfoReportSuma.Controls.Add(this.textBox5);
            this.gbInfoReportSuma.Controls.Add(this.textBox4);
            this.gbInfoReportSuma.Controls.Add(this.textBox3);
            this.gbInfoReportSuma.Controls.Add(this.textBox2);
            this.gbInfoReportSuma.Controls.Add(this.textBox1);
            this.gbInfoReportSuma.Controls.Add(this.lab32);
            this.gbInfoReportSuma.Controls.Add(this.lab31);
            this.gbInfoReportSuma.Controls.Add(this.lab30);
            this.gbInfoReportSuma.Controls.Add(this.lab29);
            this.gbInfoReportSuma.Controls.Add(this.lab28);
            this.gbInfoReportSuma.Controls.Add(this.lab27);
            this.gbInfoReportSuma.Controls.Add(this.lab26);
            this.gbInfoReportSuma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInfoReportSuma.Location = new System.Drawing.Point(12, 59);
            this.gbInfoReportSuma.Name = "gbInfoReportSuma";
            this.gbInfoReportSuma.Size = new System.Drawing.Size(642, 273);
            this.gbInfoReportSuma.TabIndex = 3;
            this.gbInfoReportSuma.TabStop = false;
            this.gbInfoReportSuma.Text = "Дані звіту";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "Разом", true));
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(137, 220);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "Сума", true));
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(137, 189);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "Відсоток", true));
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(109, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "Термін_вкладу_дні", true));
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(192, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "Термін_вкладу_місяці", true));
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(193, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "Сума_вклада", true));
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(145, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sumBindingSource, "ПІБ", true));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(137, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 26);
            this.textBox1.TabIndex = 7;
            // 
            // lab32
            // 
            this.lab32.AutoSize = true;
            this.lab32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab32.Location = new System.Drawing.Point(16, 224);
            this.lab32.Name = "lab32";
            this.lab32.Size = new System.Drawing.Size(51, 19);
            this.lab32.TabIndex = 6;
            this.lab32.Text = "Разом";
            // 
            // lab31
            // 
            this.lab31.AutoSize = true;
            this.lab31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab31.Location = new System.Drawing.Point(16, 189);
            this.lab31.Name = "lab31";
            this.lab31.Size = new System.Drawing.Size(47, 19);
            this.lab31.TabIndex = 5;
            this.lab31.Text = "Сума";
            // 
            // lab30
            // 
            this.lab30.AutoSize = true;
            this.lab30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab30.Location = new System.Drawing.Point(16, 157);
            this.lab30.Name = "lab30";
            this.lab30.Size = new System.Drawing.Size(72, 19);
            this.lab30.TabIndex = 4;
            this.lab30.Text = "Відсоток";
            // 
            // lab29
            // 
            this.lab29.AutoSize = true;
            this.lab29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab29.Location = new System.Drawing.Point(16, 125);
            this.lab29.Name = "lab29";
            this.lab29.Size = new System.Drawing.Size(140, 19);
            this.lab29.TabIndex = 3;
            this.lab29.Text = "Термін вкладу. дні";
            // 
            // lab28
            // 
            this.lab28.AutoSize = true;
            this.lab28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab28.Location = new System.Drawing.Point(16, 94);
            this.lab28.Name = "lab28";
            this.lab28.Size = new System.Drawing.Size(141, 19);
            this.lab28.TabIndex = 2;
            this.lab28.Text = "Термін вкладу. міс";
            // 
            // lab27
            // 
            this.lab27.AutoSize = true;
            this.lab27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab27.Location = new System.Drawing.Point(16, 62);
            this.lab27.Name = "lab27";
            this.lab27.Size = new System.Drawing.Size(102, 19);
            this.lab27.TabIndex = 1;
            this.lab27.Text = "Сума вклада";
            // 
            // lab26
            // 
            this.lab26.AutoSize = true;
            this.lab26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab26.Location = new System.Drawing.Point(16, 29);
            this.lab26.Name = "lab26";
            this.lab26.Size = new System.Drawing.Size(38, 19);
            this.lab26.TabIndex = 0;
            this.lab26.Text = "ПІБ";
            // 
            // sumTableAdapter
            // 
            this.sumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Bank.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВідділеняTableAdapter = null;
            this.tableAdapterManager.ВкладиTableAdapter = null;
            this.tableAdapterManager.КліентиTableAdapter = null;
            this.tableAdapterManager.ПрацівникиTableAdapter = null;
            // 
            // sumBindingNavigator
            // 
            this.sumBindingNavigator.AddNewItem = null;
            this.sumBindingNavigator.BindingSource = this.sumBindingSource;
            this.sumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sumBindingNavigator.DeleteItem = null;
            this.sumBindingNavigator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.sumBindingNavigator.Location = new System.Drawing.Point(0, 29);
            this.sumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sumBindingNavigator.Name = "sumBindingNavigator";
            this.sumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sumBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sumBindingNavigator.Size = new System.Drawing.Size(798, 25);
            this.sumBindingNavigator.TabIndex = 4;
            this.sumBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(59, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ReportSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(798, 630);
            this.Controls.Add(this.sumBindingNavigator);
            this.Controls.Add(this.gbInfoReportSuma);
            this.Controls.Add(this.gbReprtSumaGrid);
            this.Controls.Add(this.msReportSuma);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.msReportSuma;
            this.MaximumSize = new System.Drawing.Size(814, 669);
            this.Name = "ReportSuma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заіт доходи кіентів";
            this.Load += new System.EventHandler(this.ReportSuma_Load);
            this.msReportSuma.ResumeLayout(false);
            this.msReportSuma.PerformLayout();
            this.gbReprtSumaGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.gbInfoReportSuma.ResumeLayout(false);
            this.gbInfoReportSuma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumBindingNavigator)).EndInit();
            this.sumBindingNavigator.ResumeLayout(false);
            this.sumBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msReportSuma;
        private System.Windows.Forms.ToolStripMenuItem кліентиToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbReprtSumaGrid;
        private System.Windows.Forms.GroupBox gbInfoReportSuma;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lab32;
        private System.Windows.Forms.Label lab31;
        private System.Windows.Forms.Label lab30;
        private System.Windows.Forms.Label lab29;
        private System.Windows.Forms.Label lab28;
        private System.Windows.Forms.Label lab27;
        private System.Windows.Forms.Label lab26;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource sumBindingSource;
        private BDDataSetTableAdapters.SumTableAdapter sumTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sumBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView sumDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}