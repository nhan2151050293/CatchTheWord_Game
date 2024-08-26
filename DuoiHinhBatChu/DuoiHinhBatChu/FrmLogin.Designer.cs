namespace DuoiHinhBatChu
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContinue = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdAvt1 = new System.Windows.Forms.RadioButton();
            this.rdAvt2 = new System.Windows.Forms.RadioButton();
            this.rdAvt3 = new System.Windows.Forms.RadioButton();
            this.rdAvt4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // btnContinue
            // 
            this.btnContinue.BorderRadius = 10;
            this.btnContinue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnContinue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnContinue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnContinue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(56)))), ((int)(((byte)(23)))));
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.btnContinue.Location = new System.Drawing.Point(180, 268);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(172, 39);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Tiếp Tục";
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(122, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 41);
            this.txtName.TabIndex = 0;
            // 
            // rdAvt1
            // 
            this.rdAvt1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdAvt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.rdAvt1.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.A;
            this.rdAvt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdAvt1.Checked = true;
            this.rdAvt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAvt1.Location = new System.Drawing.Point(44, 174);
            this.rdAvt1.Name = "rdAvt1";
            this.rdAvt1.Size = new System.Drawing.Size(75, 70);
            this.rdAvt1.TabIndex = 6;
            this.rdAvt1.TabStop = true;
            this.rdAvt1.UseVisualStyleBackColor = false;
            // 
            // rdAvt2
            // 
            this.rdAvt2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdAvt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.rdAvt2.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.B;
            this.rdAvt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdAvt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAvt2.Location = new System.Drawing.Point(166, 174);
            this.rdAvt2.Name = "rdAvt2";
            this.rdAvt2.Size = new System.Drawing.Size(75, 70);
            this.rdAvt2.TabIndex = 6;
            this.rdAvt2.TabStop = true;
            this.rdAvt2.UseVisualStyleBackColor = false;
            // 
            // rdAvt3
            // 
            this.rdAvt3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdAvt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.rdAvt3.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.C;
            this.rdAvt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdAvt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAvt3.Location = new System.Drawing.Point(288, 174);
            this.rdAvt3.Name = "rdAvt3";
            this.rdAvt3.Size = new System.Drawing.Size(75, 70);
            this.rdAvt3.TabIndex = 6;
            this.rdAvt3.TabStop = true;
            this.rdAvt3.UseVisualStyleBackColor = false;
            // 
            // rdAvt4
            // 
            this.rdAvt4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdAvt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.rdAvt4.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.D;
            this.rdAvt4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdAvt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAvt4.Location = new System.Drawing.Point(410, 174);
            this.rdAvt4.Name = "rdAvt4";
            this.rdAvt4.Size = new System.Drawing.Size(75, 70);
            this.rdAvt4.TabIndex = 6;
            this.rdAvt4.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.Nền;
            this.ClientSize = new System.Drawing.Size(532, 328);
            this.Controls.Add(this.rdAvt4);
            this.Controls.Add(this.rdAvt3);
            this.Controls.Add(this.rdAvt2);
            this.Controls.Add(this.rdAvt1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 375);
            this.MinimumSize = new System.Drawing.Size(550, 375);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnContinue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdAvt1;
        private System.Windows.Forms.RadioButton rdAvt2;
        private System.Windows.Forms.RadioButton rdAvt3;
        private System.Windows.Forms.RadioButton rdAvt4;
    }
}