using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoiHinhBatChu
{
	public partial class FrmStart : Form
	{
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        public FrmStart()
		{
            InitializeComponent();
		}

        private void btnSinger_Click(object sender, EventArgs e)
        {
            FrmMain.regime = btnSinger.Text;

            this.Hide();
            FrmMain f = new FrmMain();
            f.ShowDialog();
            this.Close();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            FrmMain.regime = btnNormal.Text;
            this.Hide();
            FrmMain f = new FrmMain();
            f.ShowDialog();
            this.Close();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            FrmMain.regime = btnBrand.Text;

            this.Hide();
            FrmMain f = new FrmMain();
            f.ShowDialog();
            this.Close();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            FrmMain.regime = btnRandom.Text;

            this.Hide();
            FrmMain f = new FrmMain();
            f.ShowDialog();
            this.Close();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInformation f = new FrmInformation();
            f.ShowDialog();
            this.Close();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"Music/Star.wav";
            player.Play();
        }
    }
}
