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
using System.Xml.Linq;
using Guna.UI2.WinForms;

namespace DuoiHinhBatChu
{
    public partial class FrmLogin : Form
    {
        public static string path = "";
        string[] arrAvt;


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    FrmMain.name = txtName.Text;

                    if (rdAvt1.Checked)
                    {
                        path = arrAvt[0];
                    }
                    else if (rdAvt2.Checked)
                    {
                        path = arrAvt[1];
                    }    
                    else if (rdAvt3.Checked)
                    {
                        path = arrAvt[2];
                    }    
                    else if (rdAvt4.Checked)
                    {
                        path = arrAvt[3];
                    }    

                    this.Hide();
                    FrmStart f = new FrmStart();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            arrAvt = Directory.GetFiles("Images\\Avatar");
        }
    }
}
