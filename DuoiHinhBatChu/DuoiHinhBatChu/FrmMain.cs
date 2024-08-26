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
using System.Media;

namespace DuoiHinhBatChu
{
    public partial class FrmMain : Form
    {
        String[] arrImages;//Mảng đường dẫn ảnh
        public static int index;//Số random ra vị trí mảng
        int[] arrImagesUsed;//Mảng lưu vị trí ảnh đã dùng
        int indexUsed;//Thứ tự của mảng đã dùng
        bool checkUsed;//Kiểm tra xem ảnh đã xuất hiện chưa True: Rồi | False: Chưa
        Label[] arrlablebAns;//Danh sách cách ô đáp án
        Button[] arrRecommendAns;//Danh sách các button đáp án
        Random rand = new Random();
        int point; //Điểm của người chơi
        int clickSuggest = 0;//Số thứ tự gợi ý
        String[] arrAnswer;//Mảng đáp án
        int sumPlayer;//Tổng người chơi

        public static string regime;//chế độ
        public static string name;//tên người chơi
        public static string path = @"../../Data.xml";//Đường dẫn file xml

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void AddNewPicture()
        {
            clickSuggest = 0;
            do
            {
                if (indexUsed == arrImages.Length - 1)
                {
                    this.Hide();
                    FrmFinish f = new FrmFinish();
                    f.ShowDialog();
                    this.Close();
                    break;
                }

                checkUsed = false;
                index = rand.Next(0, arrImages.Length);

                for (int i = 0; i <= indexUsed; ++i)
                {
                    if (arrImagesUsed[i] == index)
                    {
                        checkUsed = true;
                        break;
                    }
                }

                if (!checkUsed)
                {
                    player.Play();
                    PicImage.BackgroundImage = Image.FromFile(arrImages[index]);
                    PicImage.BackgroundImageLayout = ImageLayout.Stretch;
                    PicImage.BorderRadius = 15;
                    arrImagesUsed[++indexUsed] = index;

                    lblQuestion.Text = (indexUsed + 1).ToString();

                    Edit_XML(name, point);
                }
            } while (checkUsed);
        }

        public void InsertImages()
        {
            try
            {
                if (regime == "Singer")
                {
                    arrImages = Directory.GetFiles(Application.StartupPath + @"\Images\Singer\");
                    arrAnswer = File.ReadAllLines("Singer.txt");
                }
                else if (regime == "Normal")
                {
                    arrImages = Directory.GetFiles(Application.StartupPath + @"\Images\Normal\");
                    arrAnswer = File.ReadAllLines("Normal.txt");
                }
                else if (regime == "Brand")
                {
                    arrImages = Directory.GetFiles(Application.StartupPath + @"\Images\Brand\");
                    arrAnswer = File.ReadAllLines("Brand.txt");
                }    
                else
                {
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
        }

        ////Tạo ra những ô đáp án
        private void CreateLableAns()
        {
            int numLable = arrAnswer[index].Length;
            arrlablebAns = new Label[numLable];

            int wForm = this.Width / 2;
            int wAns = (numLable * 47 + (numLable - 1) * 10) / 2;
            int startPos = (wForm - wAns);

            arrlablebAns[0] = new Label();
            //arrlablebAns[0].Location = new Point(PicImage.Location.X, PicImage.Location.Y + PicImage.Size.Height + 30);
            arrlablebAns[0].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 30);
            arrlablebAns[0].Size = new Size(47, 41);
            arrlablebAns[0].BackColor = Color.White;
            arrlablebAns[0].ForeColor = Color.Black;
            arrlablebAns[0].Font = new Font("Tahoma", 20);
            arrlablebAns[0].TextAlign = ContentAlignment.MiddleCenter;
            arrlablebAns[0].Click += FrmMain_Click;

            this.Controls.Add(arrlablebAns[0]);

            for (int i = 1; i < numLable; i++)
            {
                arrlablebAns[i] = new Label();
                arrlablebAns[i].Location = new Point(arrlablebAns[i - 1].Location.X + arrlablebAns[i - 1].Size.Width + 10, arrlablebAns[0].Location.Y);
                arrlablebAns[i].Size = new Size(47, 41);
                arrlablebAns[i].BackColor = Color.White;
                arrlablebAns[i].ForeColor = Color.Black;
                arrlablebAns[i].Font = new Font("Tahoma", 20);
                arrlablebAns[i].TextAlign = ContentAlignment.MiddleCenter;
                arrlablebAns[i].Click += FrmMain_Click;

                this.Controls.Add(arrlablebAns[i]);
            }
        }

        private void CreateLableAns2()
        {
            int numLable = arrAnswer[index].Length;
            arrlablebAns = new Label[numLable];

            if (numLable < 8)
            {
                int wForm = this.Width / 2;
                int wAns = (numLable * 47 + (numLable - 1) * 10) / 2;
                int startPos = (wForm - wAns);

                arrlablebAns[0] = new Label();
                //arrlablebAns[0].Location = new Point(PicImage.Location.X, PicImage.Location.Y + PicImage.Size.Height + 30);
                arrlablebAns[0].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 30);
                arrlablebAns[0].Size = new Size(47, 41);
                arrlablebAns[0].BackColor = Color.White;
                arrlablebAns[0].ForeColor = Color.Black;
                arrlablebAns[0].Font = new Font("Tahoma", 20);
                arrlablebAns[0].TextAlign = ContentAlignment.MiddleCenter;
                arrlablebAns[0].Click += FrmMain_Click;

                this.Controls.Add(arrlablebAns[0]);

                for (int i = 1; i < numLable; i++)
                {
                    arrlablebAns[i] = new Label();
                    arrlablebAns[i].Location = new Point(arrlablebAns[i - 1].Location.X + arrlablebAns[i - 1].Size.Width + 10, arrlablebAns[0].Location.Y);
                    arrlablebAns[i].Size = new Size(47, 41);
                    arrlablebAns[i].BackColor = Color.White;
                    arrlablebAns[i].ForeColor = Color.Black;
                    arrlablebAns[i].Font = new Font("Tahoma", 20);
                    arrlablebAns[i].TextAlign = ContentAlignment.MiddleCenter;
                    arrlablebAns[i].Click += FrmMain_Click;

                    this.Controls.Add(arrlablebAns[i]);
                }
            }
            else
            {
                int wForm = this.Width / 2;
                int wAns = (8 * 47 + (8 - 1) * 10) / 2;
                int startPos = (wForm - wAns);

                int wForm1 = this.Width / 2;
                int wAns1 = ((numLable - 8) * 47 + (((numLable - 8) - 1) * 10) / 2);
                int startPos1 = (wForm1 - wAns1);

                arrlablebAns[0] = new Label();
                //arrlablebAns[0].Location = new Point(PicImage.Location.X, PicImage.Location.Y + PicImage.Size.Height + 30);
                arrlablebAns[0].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 30);
                arrlablebAns[0].Size = new Size(47, 41);
                arrlablebAns[0].BackColor = Color.White;
                arrlablebAns[0].ForeColor = Color.Black;
                arrlablebAns[0].Font = new Font("Tahoma", 20);
                arrlablebAns[0].TextAlign = ContentAlignment.MiddleCenter;
                arrlablebAns[0].Click += FrmMain_Click;

                this.Controls.Add(arrlablebAns[0]);

                for (int i = 1; i < 8; i++)
                {
                    arrlablebAns[i] = new Label();
                    arrlablebAns[i].Location = new Point(arrlablebAns[i - 1].Location.X + arrlablebAns[i - 1].Size.Width + 10, arrlablebAns[0].Location.Y);
                    arrlablebAns[i].Size = new Size(47, 41);
                    arrlablebAns[i].BackColor = Color.White;
                    arrlablebAns[i].ForeColor = Color.Black;
                    arrlablebAns[i].Font = new Font("Tahoma", 20);
                    arrlablebAns[i].TextAlign = ContentAlignment.MiddleCenter;
                    arrlablebAns[i].Click += FrmMain_Click;

                    this.Controls.Add(arrlablebAns[i]);
                }

                for (int i = 8; i < numLable; i++)
                {
                    arrlablebAns[i] = new Label();
                    arrlablebAns[i].Location = new Point(arrlablebAns[i - 8].Location.X, arrlablebAns[i - 8].Location.Y + arrlablebAns[i - 8].Size.Height + 10);
                    arrlablebAns[i].Size = new Size(47, 41);
                    arrlablebAns[i].BackColor = Color.White;
                    arrlablebAns[i].ForeColor = Color.Black;
                    arrlablebAns[i].Font = new Font("Tahoma", 20);
                    arrlablebAns[i].TextAlign = ContentAlignment.MiddleCenter;
                    arrlablebAns[i].Click += FrmMain_Click;

                    this.Controls.Add(arrlablebAns[i]);
                }    
            }
        }

        //Tạo ra những button gợi ý đáp án
        private void CreateRecommendAns()
        {
            #region Create_1

            //int numButton = arrAnswer[index].Length;
            //arrRecommendAns = new Button[numButton * 2];

            //int wForm = this.Width / 2;
            //int wAns = (numButton * 45 + (numButton - 1) * 10) / 2;
            //int startPos = (wForm - wAns);

            //arrRecommendAns[0] = new Button();
            //arrRecommendAns[0].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 160);
            //arrRecommendAns[0].Size = new Size(45, 40);
            //arrRecommendAns[0].BackColor = Color.DarkBlue;

            //arrRecommendAns[1] = new Button();
            //arrRecommendAns[1].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 160 + arrRecommendAns[0].Size.Height + 10);
            //arrRecommendAns[1].Size = new Size(45, 40);
            //arrRecommendAns[1].BackColor = Color.DarkBlue;

            //this.Controls.Add(arrRecommendAns[0]);
            //this.Controls.Add(arrRecommendAns[1]);

            //for (int i = 2; i < arrRecommendAns.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        arrRecommendAns[i] = new Button();
            //        arrRecommendAns[i].Location = new Point(arrRecommendAns[i - 2].Location.X + arrRecommendAns[i - 2].Size.Width + 10, PicImage.Location.Y + PicImage.Size.Height + 160);
            //        arrRecommendAns[i].Size = new Size(45, 40);
            //        arrRecommendAns[i].BackColor = Color.DarkBlue;

            //        this.Controls.Add(arrRecommendAns[i]);
            //    }
            //    else
            //    {
            //        arrRecommendAns[i] = new Button();
            //        arrRecommendAns[i].Location = new Point(arrRecommendAns[i - 2].Location.X + arrRecommendAns[i - 2].Size.Width + 10, PicImage.Location.Y + PicImage.Size.Height + 160 + arrRecommendAns[0].Size.Height + 10);
            //        arrRecommendAns[i].Size = new Size(45, 40);
            //        arrRecommendAns[i].BackColor = Color.DarkBlue;

            //        this.Controls.Add(arrRecommendAns[i]);
            //    }
            //}

            #endregion

            #region Create_2

            int numButton = 14;
            arrRecommendAns = new Button[numButton];

            int wForm = this.Width / 2;
            int wAns = (numButton / 2 * 47 + (numButton / 2 - 1) * 15) / 2;
            int startPos = (wForm - wAns);

            arrRecommendAns[0] = new Button();
            arrRecommendAns[0].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 160);
            arrRecommendAns[0].Size = new Size(47, 42);
            arrRecommendAns[0].Font = new Font("Tahoma", 18);
            arrRecommendAns[0].Cursor = Cursors.Hand;
            arrRecommendAns[0].Click += FrmMain_Click;

            arrRecommendAns[1] = new Button();
            arrRecommendAns[1].Location = new Point(startPos - 10, PicImage.Location.Y + PicImage.Size.Height + 160 + arrRecommendAns[0].Size.Height + 10);
            arrRecommendAns[1].Size = new Size(47, 42);
            arrRecommendAns[1].Font = new Font("Tahoma", 18);
            arrRecommendAns[1].Cursor = Cursors.Hand;
            arrRecommendAns[1].Click += FrmMain_Click;

            this.Controls.Add(arrRecommendAns[0]);
            this.Controls.Add(arrRecommendAns[1]);

            for (int i = 2; i < arrRecommendAns.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arrRecommendAns[i] = new Button();
                    arrRecommendAns[i].Location = new Point(arrRecommendAns[i - 2].Location.X + arrRecommendAns[i - 2].Size.Width + 15, PicImage.Location.Y + PicImage.Size.Height + 160);
                    arrRecommendAns[i].Size = new Size(47, 42);
                    arrRecommendAns[i].Font = new Font("Tahoma", 18);
                    arrRecommendAns[i].Cursor = Cursors.Hand;
                    arrRecommendAns[i].Click += FrmMain_Click;

                    this.Controls.Add(arrRecommendAns[i]);
                }
                else
                {
                    arrRecommendAns[i] = new Button();
                    arrRecommendAns[i].Location = new Point(arrRecommendAns[i - 2].Location.X + arrRecommendAns[i - 2].Size.Width + 15, PicImage.Location.Y + PicImage.Size.Height + 160 + arrRecommendAns[0].Size.Height + 10);
                    arrRecommendAns[i].Size = new Size(47, 42);
                    arrRecommendAns[i].Font = new Font("Tahoma", 18);
                    arrRecommendAns[i].Cursor = Cursors.Hand;
                    arrRecommendAns[i].Click += FrmMain_Click;

                    this.Controls.Add(arrRecommendAns[i]);
                }
            }

            #endregion
        }

        //Lấy đáp án trong danh sách hiển thị lên các button đáp án
        private void CreateAns()
        {
            Char[] arrTextAns = new Char[arrRecommendAns.Length];

            //arrAnswer[index]: Mảng các đáp án
            //Lưu các ký tự đáp án vào mảng
            for (int i = 0; i < arrAnswer[index].Length; i++)
            {
                Char kt = arrAnswer[index][i];
                if (Char.IsLower(kt))
                {
                    arrTextAns[i] = (Char)(kt - 32);
                }
                else
                {
                    arrTextAns[i] = kt;
                }
            }

            //Random các ký tự vào mảng dùng ascii A - Z : 65 - 90 F: 70  J: 74 W: 87 Z: 90
            //arrRecommendAns: Mảng các button đáp án
            for (int i = arrAnswer[index].Length; i < arrRecommendAns.Length; i++)
            {
                int tmp = rand.Next(65, 90);
                if (tmp == 70 || tmp == 74 || tmp == 87)
                {
                    arrTextAns[i] = (Char)(tmp - 1);
                }
                else
                {
                    arrTextAns[i] = (Char)(tmp);
                }
            }

            //Mảng lưu trữ các vị trí đã đưa lên button
            int[] arrIndexTextAns = new int[arrTextAns.Length];

            int quantity = 0;

            //Trộn lẫn và đưa lên button
            for (int i = 0; i < arrTextAns.Length; i++)
            {
                bool CheckAns;

                //arrRecommendAns[i].Text = arrTextAns[i].ToString();

                do
                {
                    int idx = rand.Next(0, arrTextAns.Length); // random ra một vị trí trong mảng arrTextAns

                    CheckAns = true; //True: Chưa trùng  False: Đã trùng

                    //Kiểm tra xem đã trùng hay chưa
                    for (int j = 0; j < quantity; j++)
                    {
                        if (idx == arrIndexTextAns[j])
                        {
                            CheckAns = false;
                            break;
                        }
                    }

                    if (CheckAns)
                    {
                        //Hiển thị ký tự lên button
                        arrRecommendAns[i].Text = arrTextAns[idx].ToString();

                        //Cập nhật index vào mảng 
                        arrIndexTextAns[quantity++] = idx;
                    }
                } while (!CheckAns);
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //arrImages = Directory.GetFiles("Images");
            //arrImages = Directory.GetFiles(Application.StartupPath + @"\Images");

            InsertImages();
            arrImagesUsed = new int[arrImages.Length];
            indexUsed = 0;

            lblQuestion.Text = (indexUsed + 1).ToString();
            
            //Gắn một ảnh lên trước
            index = rand.Next(0, arrImages.Length);
            arrImagesUsed[indexUsed] = index;//Lưu index vào mảng đã dùng

            PicImage.BackgroundImage = Image.FromFile(arrImages[index]);
            PicImage.BackgroundImageLayout = ImageLayout.Stretch;
            PicImage.BorderRadius = 15;

            //Tạo ra những ô đáp án
            CreateLableAns2();
            //Tạo button gợi ý
            CreateRecommendAns();
            //Tạo đáp án trên button
            CreateAns();

            player.SoundLocation = @"Music/Nen.wav";
            player.Play();

            Load_XML();
            txtPoint.Text = point.ToString();
        }   

        private void FrmMain_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                bool checkNull = false; //True: Vẫn còn trống   False: Hết trống

                //Điền text của button lên lable
                for (int i = 0; i < arrlablebAns.Length; i++)
                {
                    if (arrlablebAns[i].Text == "")
                    {
                        arrlablebAns[i].Text = ((Button)sender).Text;
                        ((Button)sender).Visible = false;//Ẩn button đi
                        break;
                    }
                }

                //Kiểm tra xem đã đầy chưa
                foreach (Label lbl in arrlablebAns)
                {
                    if (lbl.Text == "")
                    {
                        checkNull = true;
                        break;
                    }
                }

                if (!checkNull) //Đã đầy hết Lable =>> Kiểm tra đáp án
                {
                    String ans = "";
                    foreach (Label lbl in arrlablebAns)
                        ans += lbl.Text;

                    if (String.Compare(arrAnswer[index], ans, true) == 0)
                    {
                        player.Stop();
                        FrmTrue f = new FrmTrue();
                        f.ShowDialog();

                        point += 100;
                        txtPoint.Text = point.ToString();

                        Edit_XML(name, point);

                        AddNewPicture();
                        //Xóa các ô đáp án
                        foreach (Label lbl in arrlablebAns)
                        {
                            this.Controls.Remove(lbl);
                        }
                        CreateLableAns2();
                        //Xóa ô gợi ý đáp án
                        foreach (Button btn in arrRecommendAns)
                        {
                            this.Controls.Remove(btn);
                        }
                        CreateRecommendAns();

                        CreateAns();
                    }   
                    else
                    {
                        //MessageBox.Show("Sai");

                        if (point >= 10)
                            point -= 10;
                        else
                            point = 0;
                        txtPoint.Text = point.ToString();
                        clickSuggest = 0;

                        Edit_XML(name, point);

                        //Xóa các text của ô đáp án
                        foreach (Label lbl in arrlablebAns)
                        {
                            lbl.Text = "";
                        }
                        for (int i = 0; i < arrRecommendAns.Length; i++)
                        {
                            arrRecommendAns[i].Visible = true;
                        }
                    }    
                }
            }
            else if (sender is Label)
            {
                //Kiểm tra text ở Lable click đem so sánh với Button đã bị ẩn => hiện lên
                foreach (Button btn in arrRecommendAns)
                {
                    if (btn.Visible == false && String.Compare((btn.Text), ((Label)sender).Text, true) == 0)
                    {
                        btn.Visible = true;
                        break;
                    }
                }
                ((Label)sender).ResetText();
            }
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            String ans = arrAnswer[index];
            char[] listAns = ans.ToCharArray();

            if (clickSuggest < listAns.Length && point >= 25)
            {
                arrlablebAns[clickSuggest].Text = listAns[clickSuggest].ToString();
                for (int j = 0; j < arrRecommendAns.Length; j++)
                {
                    if (listAns[clickSuggest].ToString() == arrRecommendAns[j].Text)
                    {
                        ((Button)arrRecommendAns[j]).Visible = false;
                        break;
                    }
                }

                clickSuggest++;
                point -= 25;
                Edit_XML(name, point);
                txtPoint.Text = point.ToString();

                if (clickSuggest == listAns.Length)
                {
                    bool checkNull = false; //True: Vẫn còn trống   False: Hết trống

                    //Kiểm tra xem đã đầy chưa
                    foreach (Label lbl in arrlablebAns)
                    {
                        if (lbl.Text == "")
                        {
                            checkNull = true;
                            break;
                        }
                    }

                    if (!checkNull) //Đã đầy hết Lable =>> Kiểm tra đáp án
                    {
                        String checkAns = "";
                        foreach (Label lbl in arrlablebAns)
                            checkAns += lbl.Text;

                        if (String.Compare(arrAnswer[index], ans, true) == 0)
                        {
                            player.Stop();
                            FrmTrue f = new FrmTrue();
                            f.ShowDialog();

                            point += 100;
                            txtPoint.Text = point.ToString();

                            AddNewPicture();
                            //Xóa các ô đáp án
                            foreach (Label lbl in arrlablebAns)
                            {
                                this.Controls.Remove(lbl);
                            }
                            CreateLableAns2();
                            //Xóa ô gợi ý đáp án
                            foreach (Button btn in arrRecommendAns)
                            {
                                this.Controls.Remove(btn);
                            }
                            CreateRecommendAns();

                            CreateAns();
                            clickSuggest = 0;
                        }
                        else
                        {
                            //MessageBox.Show("Sai");

                            if (point >= 10)
                                point -= 10;
                            else
                                point = 0;
                            txtPoint.Text = point.ToString();
                            clickSuggest = 0;

                            //Xóa các text của ô đáp án
                            foreach (Label lbl in arrlablebAns)
                            {
                                lbl.Text = "";
                            }
                            for (int i = 0; i < arrRecommendAns.Length; i++)
                            {
                                arrRecommendAns[i].Visible = true;
                            }
                        }
                    }
                }
            }    
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            player.Stop();
            this.Hide();
            FrmStart f = new FrmStart();
            f.ShowDialog();
            this.Close();
        }

        bool checkXML;//true: có r false: chưa có
        int markXML;
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

                sumPlayer = data.Count;

                
               
                for (int i = 0; i < data.Count; i++)
                {
                    if (name != data[i].name)
                    {
                        checkXML = false;
                    }    
                    else
                    {
                        checkXML = true;
                        markXML = int.Parse(data[i].tmark);
                        break;

                    }    
                }

                if (checkXML)
                {
                    point = markXML;
                }
                else
                {
                    Inser_XML(++sumPlayer, name, 0);
                }    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Inser_XML(int id, string name, int mark)
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

                XElement cPlayer = xDocument.Descendants("Player").FirstOrDefault(c => c.Element("Name").Value == name);
                cPlayer.Element("TotalMarks").Value = mark.ToString();
                xDocument.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}