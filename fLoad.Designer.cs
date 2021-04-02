
namespace Bank
{
    partial class fLoad
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
            this.pgBarLoad = new System.Windows.Forms.ProgressBar();
            this.lbName = new System.Windows.Forms.Label();
            this.PicLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // pgBarLoad
            // 
            this.pgBarLoad.Location = new System.Drawing.Point(12, 349);
            this.pgBarLoad.MarqueeAnimationSpeed = 50;
            this.pgBarLoad.Name = "pgBarLoad";
            this.pgBarLoad.Size = new System.Drawing.Size(566, 22);
            this.pgBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBarLoad.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(104, 230);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(373, 73);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Access Bank";
            // 
            // PicLoad
            // 
            this.PicLoad.Image = global::Bank.Properties.Resources.pic;
            this.PicLoad.Location = new System.Drawing.Point(176, 27);
            this.PicLoad.Name = "PicLoad";
            this.PicLoad.Size = new System.Drawing.Size(236, 200);
            this.PicLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLoad.TabIndex = 3;
            this.PicLoad.TabStop = false;
            // 
            // fLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(590, 399);
            this.Controls.Add(this.PicLoad);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pgBarLoad);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLoad";
            this.Load += new System.EventHandler(this.fLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgBarLoad;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox PicLoad;
    }
}