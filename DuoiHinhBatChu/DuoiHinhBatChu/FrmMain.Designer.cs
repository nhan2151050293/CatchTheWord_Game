
namespace DuoiHinhBatChu
{
	partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuggest = new Guna.UI2.WinForms.Guna2Button();
            this.PicImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.txtPoint = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(56)))), ((int)(((byte)(23)))));
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuestion.Location = new System.Drawing.Point(232, 15);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(125, 100);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "1";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 67);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
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
            this.btnHome.Location = new System.Drawing.Point(42, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(45, 40);
            this.btnHome.TabIndex = 3;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSuggest
            // 
            this.btnSuggest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(65)))), ((int)(((byte)(42)))));
            this.btnSuggest.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.idea_32_1;
            this.btnSuggest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuggest.BorderColor = System.Drawing.Color.Azure;
            this.btnSuggest.BorderRadius = 50;
            this.btnSuggest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuggest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuggest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuggest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuggest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuggest.FillColor = System.Drawing.Color.Transparent;
            this.btnSuggest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuggest.ForeColor = System.Drawing.Color.LightGray;
            this.btnSuggest.Location = new System.Drawing.Point(121, 43);
            this.btnSuggest.Name = "btnSuggest";
            this.btnSuggest.Size = new System.Drawing.Size(45, 40);
            this.btnSuggest.TabIndex = 4;
            this.btnSuggest.Click += new System.EventHandler(this.btnSuggest_Click);
            // 
            // PicImage
            // 
            this.PicImage.BackColor = System.Drawing.Color.Transparent;
            this.PicImage.BorderRadius = 15;
            this.PicImage.FillColor = System.Drawing.Color.Transparent;
            this.PicImage.ImageRotate = 0F;
            this.PicImage.Location = new System.Drawing.Point(97, 134);
            this.PicImage.Name = "PicImage";
            this.PicImage.Size = new System.Drawing.Size(403, 223);
            this.PicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicImage.TabIndex = 6;
            this.PicImage.TabStop = false;
            // 
            // txtPoint
            // 
            this.txtPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPoint.BorderThickness = 2;
            this.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.DefaultText = "";
            this.txtPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoint.ForeColor = System.Drawing.Color.Black;
            this.txtPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPoint.IconLeft = global::DuoiHinhBatChu.Properties.Resources.coins_32_2;
            this.txtPoint.Location = new System.Drawing.Point(434, 43);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.PasswordChar = '\0';
            this.txtPoint.PlaceholderText = "";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.SelectedText = "";
            this.txtPoint.Size = new System.Drawing.Size(113, 40);
            this.txtPoint.TabIndex = 13;
            this.txtPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(112)))));
            this.BackgroundImage = global::DuoiHinhBatChu.Properties.Resources.Nền_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 657);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.PicImage);
            this.Controls.Add(this.btnSuggest);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 704);
            this.MinimumSize = new System.Drawing.Size(621, 704);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đuổi Hình Bắt Chữ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Button btnHome;
		private Guna.UI2.WinForms.Guna2Button btnSuggest;
		private Guna.UI2.WinForms.Guna2PictureBox PicImage;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private Guna.UI2.WinForms.Guna2TextBox txtPoint;
    }
}

