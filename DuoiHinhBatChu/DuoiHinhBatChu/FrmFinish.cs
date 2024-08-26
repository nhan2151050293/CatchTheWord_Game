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
    public partial class FrmFinish : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public FrmFinish()
        {
            InitializeComponent();
        }

        private void FrmFinish_Load(object sender, EventArgs e)
        {
            player.SoundLocation = @"Music/Finish.wav";
            player.Play();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FrmStart f = new FrmStart();
            //f.ShowDialog();
            this.Close();
        }

        private void FrmFinish_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FrmStart f = new FrmStart();
            f.ShowDialog();
            this.Close();
        }
    }
}
