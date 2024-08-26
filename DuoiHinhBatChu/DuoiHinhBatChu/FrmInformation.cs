using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace DuoiHinhBatChu
{
    public partial class FrmInformation : Form
    {
        //public static int sumPlayer;
        public static string path = @"../../Data.xml";
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
    
        public FrmInformation()
        {
            InitializeComponent();
        }

        private void Load_XML()
        {
            try
            {
                XDocument xDocument = XDocument.Load(path);
                
                var data = xDocument.Descendants("Player").Where(t => int.Parse(t.Attribute("Id").Value) > 0).
                    Select(o => new
                    {
                        id = o.Attribute("Id").Value,
                        name = o.Element("Name").Value,
                        tmark = o.Element("TotalMarks").Value
                    }).ToList();

                for (int a = 0; a < data.Count; a++)
                {
                    for (int b = 0; b < data.Count; b++)
                    {
                        if (int.Parse(data[a].tmark) > int.Parse(data[b].tmark))
                        {
                            var tmp = data[a];
                            data[a] = data[b];
                            data[b] = tmp;
                        }    
                    }
                }

                int i = 0;
                foreach (var item in data)
                {
                    listRank.Items.Add(item.id);
                    listRank.Items[i].SubItems.Add(item.name);
                    listRank.Items[i].SubItems.Add(item.tmark);
                    i++;
                }

                for (int j = 0; j < data.Count; j++)
                {
                    if (FrmMain.name == data[j].name)
                    {
                        lblScore.Text = data[j].tmark;
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Inser_XML(int id, string name, int mark, int idx)
        {
            try
            {
                XDocument xDocument = XDocument.Load(path);

                XElement newPlayer = new XElement("Player",
                    new XElement("Name", name),
                    new XElement("TotalMarks", mark));

                var lastPlayer = xDocument.Descendants("Player").Last();

                var data = xDocument.Descendants("Player").Where(t => int.Parse(t.Attribute("Id").Value) > 0);

                newPlayer.SetAttributeValue("Id", id);

                xDocument.Element("Players").Add(newPlayer);
                xDocument.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_XML(string name, int mark)
        {
            try
            {
                XDocument xDocument = XDocument.Load(path);

                XElement cStudent = xDocument.Descendants("Player").FirstOrDefault(c => c.Element("Name").Value == name);
                cStudent.Element("TotalMarks").Value = mark.ToString();
                xDocument.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        private void FrmInformation_Load(object sender, EventArgs e)
        {
            lblNameIn4.Text = FrmMain.name;

            picAvt.BackgroundImage = System.Drawing.Image.FromFile(FrmLogin.path);
            
            Load_XML();

            player.SoundLocation = @"Music/In4.wav";
            player.Play();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Hide();
            FrmStart f = new FrmStart();
            f.ShowDialog();
            this.Close();
        }

        private void listRank_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = listRank.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                listRank.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                //Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                //Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            listRank.Sort();
        }
    }
}
