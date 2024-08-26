namespace DuoiHinhBatChu
{
    partial class FrmInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameIn4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listRank = new System.Windows.Forms.ListView();
            this.clStt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 5);
            this.label1.TabIndex = 0;
            // 
            // lblNameIn4
            // 
            this.lblNameIn4.AutoSize = true;
            this.lblNameIn4.BackColor = System.Drawing.Color.Transparent;
            this.lblNameIn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameIn4.ForeColor = System.Drawing.Color.White;
            this.lblNameIn4.Location = new System.Drawing.Point(223, 69);
            this.lblNameIn4.Name = "lblNameIn4";
            this.lblNameIn4.Size = new System.Drawing.Size(0, 42);
            this.lblNameIn4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 42);
            this.label4.TabIndex = 3;
            this.label4.Text = "BXH:";
            // 
            // listRank
            // 
            this.listRank.BackColor = System.Drawing.Color.White;
            this.listRank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clStt,
            this.clName,
            this.clPoint});
            this.listRank.Cursor = System.Windows.Forms.Cursors.Default;
            this.listRank.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRank.HideSelection = false;
            this.listRank.Location = new System.Drawing.Point(53, 363);
            this.listRank.Name = "listRank";
            this.listRank.Size = new System.Drawing.Size(500, 247);
            this.listRank.TabIndex = 4;
            this.listRank.UseCompatibleStateImageBehavior = false;
            this.listRank.View = System.Windows.Forms.View.Details;
            this.listRank.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listRank_ColumnClick);
            // 
            // clStt
            // 
            this.clStt.Text = "ID";
            // 
            // clName
            // 
            this.clName.Text = "Tên";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 200;
            // 
            // clPoint
            // 
            this.clPoint.Text = "Điểm";
            this.clPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPoint.Width = 90;
            // 
            // picAvt
            // 
            this.picAvt.BackColor = System.Drawing.Color.Transparent;
            this.picAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvt.Location = new System.Drawing.Point(44, 22);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(129, 113);
            this.picAvt.TabIndex = 5;
            this.picAvt.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(171, 213);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(39, 42);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.house_32_1;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(508, 95);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 40);
            this.btnHome.TabIndex = 8;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FrmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.Nền_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 657);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picAvt);
            this.Controls.Add(this.listRank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNameIn4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 704);
            this.MinimumSize = new System.Drawing.Size(621, 704);
            this.Name = "FrmInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.FrmInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameIn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listRank;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clPoint;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.ColumnHeader clStt;
    }
}