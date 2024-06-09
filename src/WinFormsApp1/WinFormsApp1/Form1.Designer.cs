namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxResult = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNIK = new TextBox();
            textBoxNama = new TextBox();
            label3 = new Label();
            textBoxTempatLahir = new TextBox();
            label4 = new Label();
            textBoxTanggalLahir = new TextBox();
            label5 = new Label();
            textBoxJenisKelamin = new TextBox();
            label6 = new Label();
            textBoxGolonganDarah = new TextBox();
            label7 = new Label();
            textBoxAlamat = new TextBox();
            label8 = new Label();
            textBoxAgama = new TextBox();
            label9 = new Label();
            textBoxStatusPerkawinan = new TextBox();
            textBoxPekerjaan = new TextBox();
            label11 = new Label();
            textBoxKewarganegaraan = new TextBox();
            label12 = new Label();
            label10 = new Label();
            buttonAdd = new Button();
            buttonAlgorithm = new Button();
            buttonSearch = new Button();
            label13 = new Label();
            textBoxWaktuPencarian = new TextBox();
            label14 = new Label();
            label15 = new Label();
            textBoxPersentaseMirip = new TextBox();
            label16 = new Label();
            groupBox1 = new GroupBox();
            pictureBoxUser = new PictureBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxResult
            // 
            pictureBoxResult.Dock = DockStyle.Fill;
            pictureBoxResult.Location = new Point(3, 27);
            pictureBoxResult.Name = "pictureBoxResult";
            pictureBoxResult.Size = new Size(494, 470);
            pictureBoxResult.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResult.TabIndex = 1;
            pictureBoxResult.TabStop = false;
            pictureBoxResult.Click += pictureBoxResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(510, 71);
            label1.Name = "label1";
            label1.Size = new Size(160, 81);
            label1.TabIndex = 2;
            label1.Text = "Click";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1155, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 3;
            label2.Text = "NIK";
            // 
            // textBoxNIK
            // 
            textBoxNIK.Location = new Point(1155, 84);
            textBoxNIK.Name = "textBoxNIK";
            textBoxNIK.ReadOnly = true;
            textBoxNIK.Size = new Size(327, 31);
            textBoxNIK.TabIndex = 4;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(1155, 155);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(327, 31);
            textBoxNama.TabIndex = 6;
            textBoxNama.TextChanged += textBoxNama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1155, 118);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "NAMA";
            // 
            // textBoxTempatLahir
            // 
            textBoxTempatLahir.Location = new Point(1155, 236);
            textBoxTempatLahir.Name = "textBoxTempatLahir";
            textBoxTempatLahir.ReadOnly = true;
            textBoxTempatLahir.Size = new Size(327, 31);
            textBoxTempatLahir.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1155, 199);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 7;
            label4.Text = "TEMPAT LAHIR";
            // 
            // textBoxTanggalLahir
            // 
            textBoxTanggalLahir.Location = new Point(1155, 314);
            textBoxTanggalLahir.Name = "textBoxTanggalLahir";
            textBoxTanggalLahir.ReadOnly = true;
            textBoxTanggalLahir.Size = new Size(327, 31);
            textBoxTanggalLahir.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1155, 277);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 9;
            label5.Text = "TANGGAL LAHIR";
            // 
            // textBoxJenisKelamin
            // 
            textBoxJenisKelamin.Location = new Point(1155, 385);
            textBoxJenisKelamin.Name = "textBoxJenisKelamin";
            textBoxJenisKelamin.ReadOnly = true;
            textBoxJenisKelamin.Size = new Size(327, 31);
            textBoxJenisKelamin.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1155, 348);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 11;
            label6.Text = "JENIS KELAMIN";
            // 
            // textBoxGolonganDarah
            // 
            textBoxGolonganDarah.Location = new Point(1155, 454);
            textBoxGolonganDarah.Name = "textBoxGolonganDarah";
            textBoxGolonganDarah.ReadOnly = true;
            textBoxGolonganDarah.Size = new Size(327, 31);
            textBoxGolonganDarah.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1155, 417);
            label7.Name = "label7";
            label7.Size = new Size(175, 25);
            label7.TabIndex = 13;
            label7.Text = "GOLONGAN DARAH";
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(1155, 526);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.ReadOnly = true;
            textBoxAlamat.Size = new Size(327, 31);
            textBoxAlamat.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1155, 489);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 15;
            label8.Text = "ALAMAT";
            // 
            // textBoxAgama
            // 
            textBoxAgama.Location = new Point(1155, 595);
            textBoxAgama.Name = "textBoxAgama";
            textBoxAgama.ReadOnly = true;
            textBoxAgama.Size = new Size(327, 31);
            textBoxAgama.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1155, 558);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 17;
            label9.Text = "AGAMA";
            // 
            // textBoxStatusPerkawinan
            // 
            textBoxStatusPerkawinan.Location = new Point(1155, 665);
            textBoxStatusPerkawinan.Name = "textBoxStatusPerkawinan";
            textBoxStatusPerkawinan.ReadOnly = true;
            textBoxStatusPerkawinan.Size = new Size(327, 31);
            textBoxStatusPerkawinan.TabIndex = 20;
            // 
            // textBoxPekerjaan
            // 
            textBoxPekerjaan.Location = new Point(1155, 735);
            textBoxPekerjaan.Name = "textBoxPekerjaan";
            textBoxPekerjaan.ReadOnly = true;
            textBoxPekerjaan.Size = new Size(327, 31);
            textBoxPekerjaan.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1155, 698);
            label11.Name = "label11";
            label11.Size = new Size(105, 25);
            label11.TabIndex = 21;
            label11.Text = "PEKERJAAN";
            // 
            // textBoxKewarganegaraan
            // 
            textBoxKewarganegaraan.Location = new Point(1155, 810);
            textBoxKewarganegaraan.Name = "textBoxKewarganegaraan";
            textBoxKewarganegaraan.ReadOnly = true;
            textBoxKewarganegaraan.Size = new Size(327, 31);
            textBoxKewarganegaraan.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1155, 773);
            label12.Name = "label12";
            label12.Size = new Size(188, 25);
            label12.TabIndex = 23;
            label12.Text = "KEWARGANEGARAAN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1155, 629);
            label10.Name = "label10";
            label10.Size = new Size(188, 25);
            label10.TabIndex = 25;
            label10.Text = "STATUS PERKAWINAN";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(53, 722);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(500, 81);
            buttonAdd.TabIndex = 26;
            buttonAdd.Text = "Add Image";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click_1;
            // 
            // buttonAlgorithm
            // 
            buttonAlgorithm.BackColor = Color.GreenYellow;
            buttonAlgorithm.Location = new Point(607, 722);
            buttonAlgorithm.Name = "buttonAlgorithm";
            buttonAlgorithm.Size = new Size(251, 81);
            buttonAlgorithm.TabIndex = 27;
            buttonAlgorithm.Text = "KMP";
            buttonAlgorithm.UseVisualStyleBackColor = false;
            buttonAlgorithm.Click += buttonAlgorithm_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(864, 722);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(251, 81);
            buttonSearch.TabIndex = 28;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(53, 853);
            label13.Name = "label13";
            label13.Size = new Size(226, 32);
            label13.TabIndex = 29;
            label13.Text = "WAKTU PENCARIAN";
            // 
            // textBoxWaktuPencarian
            // 
            textBoxWaktuPencarian.Location = new Point(325, 856);
            textBoxWaktuPencarian.Name = "textBoxWaktuPencarian";
            textBoxWaktuPencarian.ReadOnly = true;
            textBoxWaktuPencarian.Size = new Size(178, 31);
            textBoxWaktuPencarian.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(510, 856);
            label14.Name = "label14";
            label14.Size = new Size(27, 32);
            label14.TabIndex = 31;
            label14.Text = "S";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F);
            label15.Location = new Point(1048, 853);
            label15.Name = "label15";
            label15.Size = new Size(34, 32);
            label15.TabIndex = 34;
            label15.Text = "%";
            // 
            // textBoxPersentaseMirip
            // 
            textBoxPersentaseMirip.Location = new Point(864, 856);
            textBoxPersentaseMirip.Name = "textBoxPersentaseMirip";
            textBoxPersentaseMirip.ReadOnly = true;
            textBoxPersentaseMirip.Size = new Size(178, 31);
            textBoxPersentaseMirip.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(607, 853);
            label16.Name = "label16";
            label16.Size = new Size(215, 32);
            label16.TabIndex = 32;
            label16.Text = "PERSENTASE MIRIP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxUser);
            groupBox1.Location = new Point(53, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 500);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Dock = DockStyle.Fill;
            pictureBoxUser.Location = new Point(3, 27);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(494, 470);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 0;
            pictureBoxUser.TabStop = false;
            pictureBoxUser.Click += pictureBoxUser_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBoxResult);
            groupBox2.Location = new Point(607, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 500);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 913);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label15);
            Controls.Add(textBoxPersentaseMirip);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(textBoxWaktuPencarian);
            Controls.Add(label13);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAlgorithm);
            Controls.Add(buttonAdd);
            Controls.Add(label10);
            Controls.Add(textBoxKewarganegaraan);
            Controls.Add(label12);
            Controls.Add(textBoxPekerjaan);
            Controls.Add(label11);
            Controls.Add(textBoxStatusPerkawinan);
            Controls.Add(textBoxAgama);
            Controls.Add(label9);
            Controls.Add(textBoxAlamat);
            Controls.Add(label8);
            Controls.Add(textBoxGolonganDarah);
            Controls.Add(label7);
            Controls.Add(textBoxJenisKelamin);
            Controls.Add(label6);
            Controls.Add(textBoxTanggalLahir);
            Controls.Add(label5);
            Controls.Add(textBoxTempatLahir);
            Controls.Add(label4);
            Controls.Add(textBoxNama);
            Controls.Add(label3);
            Controls.Add(textBoxNIK);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResult).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxResult;
        private Label label1;
        private Label label2;
        private TextBox textBoxNIK;
        private TextBox textBoxNama;
        private Label label3;
        private TextBox textBoxTempatLahir;
        private Label label4;
        private TextBox textBoxTanggalLahir;
        private Label label5;
        private TextBox textBoxJenisKelamin;
        private Label label6;
        private TextBox textBoxGolonganDarah;
        private Label label7;
        private TextBox textBoxAlamat;
        private Label label8;
        private TextBox textBoxAgama;
        private Label label9;
        private TextBox textBoxStatusPerkawinan;
        private TextBox textBoxPekerjaan;
        private Label label11;
        private TextBox textBoxKewarganegaraan;
        private Label label12;
        private Label label10;
        private Button buttonAdd;
        private Button buttonAlgorithm;
        private Button buttonSearch;
        private Label label13;
        private TextBox textBoxWaktuPencarian;
        private Label label14;
        private Label label15;
        private TextBox textBoxPersentaseMirip;
        private Label label16;
        private GroupBox groupBox1;
        private PictureBox pictureBoxUser;
        private GroupBox groupBox2;
    }
}
