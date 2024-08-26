using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuoiHinhBatChu
{
    public partial class FrmTrue : Form
    {
        String[] arrImages;
        String[] arrAnswer;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer playerSinger = new System.Media.SoundPlayer();

        public FrmTrue()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTrue_Load(object sender, EventArgs e)
        {
            String tmp = FrmMain.regime;
            try
            {
                if (tmp == "Singer")
                {
                    arrImages = Directory.GetFiles(Application.StartupPath + @"\Images\Singer\");
                    arrAnswer = File.ReadAllLines("Singer.txt");
                }
                else if (tmp == "Normal")
                {
                    arrImages = Directory.GetFiles(Application.StartupPath + @"\Images\Normal\");
                    arrAnswer = File.ReadAllLines("Normal.txt");
                    player.SoundLocation = @"Music/GoodJob.wav";
                }
                else if (tmp == "Brand")
                {
                    arrImages = Directory.GetFiles(Application.StartupPath + @"\Images\Brand\");
                    arrAnswer = File.ReadAllLines("Brand.txt");
                    player.SoundLocation = @"Music/GoodJob.wav";
                }    
                else
                {
                    player.SoundLocation = @"Music/GoodJob.wav";
                    String[] arrSinger;
                    String[] arrNormal;
                    String[] arrBrand;

                    String[] arrAnsSinger;
                    String[] arrAnsNormal;
                    String[] arrAnsBrand;

                    arrSinger = Directory.GetFiles(Application.StartupPath + @"\Images\Singer\");
                    arrNormal = Directory.GetFiles(Application.StartupPath + @"\Images\Normal\");
                    arrBrand = Directory.GetFiles(Application.StartupPath + @"\Images\Brand\");

                    arrImages = new string[arrSinger.Length + arrNormal.Length + arrBrand.Length];
                    for (int i = 0; i < 25; i++)
                    {
                        arrImages[i] = arrSinger[i];
                    }
                    for (int i = 25; i < 50; i++)
                    {
                        arrImages[i] = arrNormal[i - 25];
                    }

                    for (int i = 50; i < 65; i++)
                    {
                        arrImages[i] = arrBrand[i - 50];
                    }

                    arrAnsSinger = File.ReadAllLines("Singer.txt");
                    arrAnsNormal = File.ReadAllLines("Normal.txt");
                    arrAnsBrand = File.ReadAllLines("Brand.txt");

                    arrAnswer = new string[arrAnsSinger.Length + arrAnsNormal.Length + arrAnsBrand.Length];
                    for (int i = 0; i < 25; i++)
                    {
                        arrAnswer[i] = arrAnsSinger[i];
                    }
                    for (int i = 25; i < 50; i++)
                    {
                        arrAnswer[i] = arrAnsNormal[i - 25];
                    }

                    for (int i = 50; i < 65; i++)
                    {
                        arrAnswer[i] = arrAnsBrand[i - 50];
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Thông báo", "Không tìm thấy thư mục ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            picImges.BackgroundImage = Image.FromFile(arrImages[FrmMain.index]);
            lblAns.Text = arrAnswer[FrmMain.index];
            if (tmp == "Singer")
            {
                string path = @"Music/MusicSinger/" + (FrmMain.index + 1).ToString() + ".wav";
                playerSinger.SoundLocation = path;
                playerSinger.Play();
            }   
            else
            {
                player.Play();
            }
        }

    }
}
