namespace DuoiHinhBatChu
{
    partial class FrmTrue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrue));
            this.picImges = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.btnContinue = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImges)).BeginInit();
            this.SuspendLayout();
            // 
            // picImges
            // 
            this.picImges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImges.FillColor = System.Drawing.Color.Transparent;
            this.picImges.ImageRotate = 0F;
            this.picImges.Location = new System.Drawing.Point(97, 140);
            this.picImges.Name = "picImges";
            this.picImges.Size = new System.Drawing.Size(403, 223);
            this.picImges.TabIndex = 0;
            this.picImges.TabStop = false;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.BackColor = System.Drawing.Color.Transparent;
            this.lblAns.Font = new System.Drawing.Font(".VnArial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAns.Location = new System.Drawing.Point(275, 422);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 37);
            this.lblAns.TabIndex = 1;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.arrow_11_64;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinue.FillColor = System.Drawing.Color.Transparent;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(524, 575);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(53, 57);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // FrmTrue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.Nền_true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 657);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.picImges);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 704);
            this.MinimumSize = new System.Drawing.Size(621, 704);
            this.Name = "FrmTrue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chúc mừng";
            this.Load += new System.EventHandler(this.FrmTrue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picImges;
        private System.Windows.Forms.Label lblAns;
        private Guna.UI2.WinForms.Guna2Button btnContinue;
    }
}