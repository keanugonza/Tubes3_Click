using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mysqlx.Session;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string input;
        private bool isToggledOn = false;
        private Bitmap imageUser;
        private string ASCIIUser;
        string targetFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap backgroundImage = new Bitmap(@"..\..\..\Resources\vecteezy_fingerprint-with-concept-abstract-technology-background_6574656.jpg");
            this.BackgroundImage = backgroundImage;

        }


        private void buttonAlgorithm_Click(object sender, EventArgs e)
        {
            isToggledOn = !isToggledOn;

            if (!isToggledOn)
            {
                buttonAlgorithm.Text = "KMP";
                buttonAlgorithm.BackColor = Color.GreenYellow;
            }
            else
            {
                buttonAlgorithm.Text = "BM";
                buttonAlgorithm.BackColor = Color.Aqua;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Title = "Add Image";
            image.Filter = "bmp image (*.bmp)|*.bmp";
            image.RestoreDirectory = true;
            if (image.ShowDialog() == DialogResult.OK)
            {
                this.imageUser = new Bitmap(image.FileName);
                this.ASCIIUser = ImageConverter.getASCUser(this.imageUser);
                pictureBoxUser.Image = this.imageUser;

            }
        }

        private void KMPSearch(ref double perc, ref Bitmap res, ref string[] bmpFiles)
        {
            foreach (string bmpFile in bmpFiles)
            {
                Bitmap temp = new Bitmap(bmpFile);
                string pattern1 = ImageConverter.getASCDB(temp);
                string pattern2 = ImageConverter.getASCUser(temp);
                if (Algorithm_KMP.KMP(this.ASCIIUser, pattern1) > -1)
                {
                    int[,] tempLCS = Algorithm_LCS.LCSLength(this.ASCIIUser, pattern2);
                    int n = this.ASCIIUser.Length;
                    int m = pattern2.Length;
                    string lcs = Algorithm_LCS.PrintLCS(tempLCS, this.ASCIIUser, pattern2, n, m);
                    double lenLCS = lcs.Length;
                    double lenM = pattern2.Length;
                    double resPersen = lenLCS / lenM * 100;
                    if (resPersen > perc && resPersen > 60.0)
                    {
                        perc = resPersen;
                        res = temp;
                        this.targetFile = Path.GetFileName(bmpFile);
                    }
                }
                else
                {
                    int[,] tempLCS = Algorithm_LCS.LCSLength(this.ASCIIUser, pattern2);
                    int n = this.ASCIIUser.Length;
                    int m = pattern2.Length;
                    string lcs = Algorithm_LCS.PrintLCS(tempLCS, this.ASCIIUser, pattern2, n, m);
                    double lenLCS = lcs.Length;
                    double lenM = pattern2.Length;
                    double resPersen = lenLCS / lenM * 100;
                    if (resPersen > perc && resPersen > 60.0)
                    {
                        perc = resPersen;
                        res = temp;
                        this.targetFile = Path.GetFileName(bmpFile);
                    }
                }
            }
        }

        private void BMSearch(ref double perc, ref Bitmap res, ref string[] bmpFiles)
        {
            foreach (string bmpFile in bmpFiles)
            {
                Bitmap temp = new Bitmap(bmpFile);
                string pattern1 = ImageConverter.getASCDB(temp);
                string pattern2 = ImageConverter.getASCUser(temp);
                if (Algoritma_BM.BM(this.ASCIIUser, pattern1) > -1)
                {
                    int[,] tempLCS = Algorithm_LCS.LCSLength(this.ASCIIUser, pattern2);
                    int n = this.ASCIIUser.Length;
                    int m = pattern2.Length;
                    string lcs = Algorithm_LCS.PrintLCS(tempLCS, this.ASCIIUser, pattern2, n, m);
                    double lenLCS = lcs.Length;
                    double lenM = pattern2.Length;
                    double resPersen = lenLCS / lenM * 100;
                    if (resPersen > perc && resPersen > 60.0)
                    {
                        perc = resPersen;
                        res = temp;
                        this.targetFile = Path.GetFileName(bmpFile);
                    }
                }
                else
                {
                    int[,] tempLCS = Algorithm_LCS.LCSLength(this.ASCIIUser, pattern2);
                    int n = this.ASCIIUser.Length;
                    int m = pattern2.Length;
                    string lcs = Algorithm_LCS.PrintLCS(tempLCS, this.ASCIIUser, pattern2, n, m);
                    double lenLCS = lcs.Length;
                    double lenM = pattern2.Length;
                    double resPersen = lenLCS / lenM * 100;
                    if (resPersen > perc && resPersen > 60.0)
                    {
                        perc = resPersen;
                        res = temp;
                        this.targetFile = Path.GetFileName(bmpFile);
                    }
                }
            }
        }

        private string regexMatching(ref DatabaseOperations dbOps)
        {
            Algorithm_Regex regex = new Algorithm_Regex();

            string a = "test/" + this.targetFile;
            string namaSidikJari = dbOps.GetNamaSidikJari(a);

            List<string> listNama = new List<string>();
            listNama = dbOps.GetBiodataEntries_NamaOnly();
            string nama = null;
            double resPersen = 0.0;
            foreach (string s in listNama)
            {
                if (s.Equals(regex.Reg(namaSidikJari)))
                {
                    nama = s;
                    return nama;
                }
                else
                {
                    int[,] tempLCS = Algorithm_LCS.LCSLength(s, namaSidikJari);
                    int n = s.Length;
                    int m = namaSidikJari.Length;
                    string lcs = Algorithm_LCS.PrintLCS(tempLCS, s, namaSidikJari, n, m);
                    double lenLCS = lcs.Length;
                    double lenM = namaSidikJari.Length;
                    double tempPersen = lenLCS / lenM * 100;
                    if (tempPersen > resPersen)
                    {
                        nama = s;
                        resPersen = tempPersen;
                    }
                }
            }
            return nama;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            string folderPath = @"..\..\..\..\..\..\test";
            string[] bmpFiles = ImageConverter.GetBmpFiles(folderPath);

            double perc = 1.0;
            Bitmap res = null;
            stopwatch.Start();
            if (!this.isToggledOn)
            {
                KMPSearch(ref perc, ref res, ref bmpFiles);
            }
            else
            {
                BMSearch(ref perc, ref res, ref bmpFiles);
            }
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            double resSecond = elapsedTime.TotalSeconds;
            if (perc > 60.0)
            {
                DatabaseOperations dbOps = new DatabaseOperations();
                pictureBoxResult.Image = res;
                textBoxPersentaseMirip.Text = perc.ToString();
                textBoxWaktuPencarian.Text = resSecond.ToString();
                string nama = regexMatching(ref dbOps);
                
                //MessageBox.Show(nama);
                Dictionary<string, string> biodata = dbOps.GetBiodata(nama);
                textBoxNIK.Text = biodata["NIK"];
                textBoxNama.Text = biodata["nama"];
                textBoxTempatLahir.Text = biodata["tempat_lahir"];
                textBoxTanggalLahir.Text = biodata["tanggal_lahir"];
                textBoxJenisKelamin.Text = biodata["jenis_kelamin"];
                textBoxGolonganDarah.Text = biodata["golongan_darah"];
                textBoxAlamat.Text = biodata["alamat"];
                textBoxAgama.Text = biodata["agama"];
                textBoxStatusPerkawinan.Text = biodata["status_perkawinan"];
                textBoxPekerjaan.Text = biodata["pekerjaan"];
                textBoxKewarganegaraan.Text = biodata["kewarganegaraan"];

            }
            else
            {
                MessageBox.Show("NOT FOUND");
            }

        }
    }
}
