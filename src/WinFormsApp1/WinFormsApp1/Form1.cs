using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.input = textBox1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseOperations dbOps = new DatabaseOperations();
            Algorithm_Regex regex = new Algorithm_Regex();
            string a = this.input;

            string namaSidikJari = dbOps.GetNamaSidikJari(a);
            textBox2.Text = namaSidikJari;

            List<string> listNama = new List<string>();
            listNama = dbOps.GetBiodataEntries_NamaOnly();
            string nama = null;
            foreach (string s in listNama)
            {
                if (s.Equals(regex.Reg(namaSidikJari)))
                {
                    nama = s;
                    break;
                }
            }

            Dictionary<string, string> biodata = dbOps.GetBiodata(nama);
            textBox3.Text = biodata["NIK"];
        }
    }
}
