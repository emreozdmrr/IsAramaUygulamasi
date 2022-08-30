namespace isBulmaUygulamasi.Çalışan_Arayüzü_Formları
{
    partial class frmIlanGoruntule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBasvuruYap = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxSehirler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTecrube = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.comboBoxIsTanimi = new System.Windows.Forms.ComboBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBasvuruYap);
            this.panel2.Controls.Add(this.btnVazgec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(524, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 48);
            this.panel2.TabIndex = 0;
            // 
            // btnBasvuruYap
            // 
            this.btnBasvuruYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnBasvuruYap.FlatAppearance.BorderSize = 0;
            this.btnBasvuruYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasvuruYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasvuruYap.ForeColor = System.Drawing.Color.White;
            this.btnBasvuruYap.Location = new System.Drawing.Point(11, 9);
            this.btnBasvuruYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnBasvuruYap.Name = "btnBasvuruYap";
            this.btnBasvuruYap.Size = new System.Drawing.Size(125, 30);
            this.btnBasvuruYap.TabIndex = 7;
            this.btnBasvuruYap.Text = "Başvuru Yap";
            this.btnBasvuruYap.UseVisualStyleBackColor = false;
            this.btnBasvuruYap.Click += new System.EventHandler(this.btnBasvuruYap_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnVazgec.FlatAppearance.BorderSize = 0;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(144, 9);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(4);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(125, 30);
            this.btnVazgec.TabIndex = 8;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.comboBoxSehirler);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBoxTecrube);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.richTextBoxAciklama);
            this.panel3.Controls.Add(this.comboBoxIsTanimi);
            this.panel3.Controls.Add(this.txtFirmaAdi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 513);
            this.panel3.TabIndex = 1;
            // 
            // comboBoxSehirler
            // 
            this.comboBoxSehirler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSehirler.Enabled = false;
            this.comboBoxSehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSehirler.FormattingEnabled = true;
            this.comboBoxSehirler.Items.AddRange(new object[] {
            "Tüm Şehirler",
            "Adana",
            "Adıyaman",
            "Afyon ",
            "Ağrı ",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.comboBoxSehirler.Location = new System.Drawing.Point(160, 97);
            this.comboBoxSehirler.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSehirler.Name = "comboBoxSehirler";
            this.comboBoxSehirler.Size = new System.Drawing.Size(197, 28);
            this.comboBoxSehirler.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Şehir :";
            // 
            // comboBoxTecrube
            // 
            this.comboBoxTecrube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecrube.Enabled = false;
            this.comboBoxTecrube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTecrube.FormattingEnabled = true;
            this.comboBoxTecrube.Items.AddRange(new object[] {
            "Yok",
            "Var"});
            this.comboBoxTecrube.Location = new System.Drawing.Point(160, 186);
            this.comboBoxTecrube.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTecrube.Name = "comboBoxTecrube";
            this.comboBoxTecrube.Size = new System.Drawing.Size(100, 28);
            this.comboBoxTecrube.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tecrübe :";
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Enabled = false;
            this.richTextBoxAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxAciklama.Location = new System.Drawing.Point(160, 240);
            this.richTextBoxAciklama.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.Size = new System.Drawing.Size(371, 156);
            this.richTextBoxAciklama.TabIndex = 22;
            this.richTextBoxAciklama.Text = "";
            // 
            // comboBoxIsTanimi
            // 
            this.comboBoxIsTanimi.Enabled = false;
            this.comboBoxIsTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxIsTanimi.FormattingEnabled = true;
            this.comboBoxIsTanimi.Items.AddRange(new object[] {
            "Acil Yardım ve Afet Yönetimi",
            "Antrenörlük Eğitimi",
            "Bankacılık",
            "Beslenme ve Diyetetik",
            "Bilgisayar Mühendisliği",
            "Coğrafya",
            "Coğrafya Öğretmenliği",
            "Çeviribilim",
            "Çevre Mühendisliği",
            "Deniz Ulaştırma İşletme Mühendisliği",
            "Diş Hekimliği",
            "Eczacılık",
            "Elektrik-Elektronik Mühendisliği",
            "Elektronik ve Haberleşme Mühendisliği",
            "Endüstri Mühendisliği",
            "Endüstriyel Tasarım Mühendisliği",
            "Enerji Mühendisliği",
            "Enerji Sistemleri Mühendisliği",
            "Felsefe",
            "Fizik Mühendisliği",
            "Gastronomi ve Mutfak Sanatları",
            "Gemi Makineleri İşletme Mühendisliği",
            "Gıda Mühendisliği",
            "Halkla İlişkiler",
            "Harita Mühendisliği",
            "Hemşirelik",
            "Hukuk",
            "İç Mimarlık",
            "İktisat",
            "İnşaat Mühendisliği",
            "Jeoloji Mühendisliği",
            "Kamu Yönetimi",
            "Kimya",
            "Kimya Mühendisliği",
            "Lojistik Yönetimi",
            "Maden Mühendisliği",
            "Makine Mühendisliği",
            "Matematik",
            "Mekatronik Mühendisliği",
            "Metalurji ve Malzeme Mühendisliği",
            "Mimarlık",
            "Nanoteknoloji Mühendisliği",
            "Orman Endüstrisi Mühendisliği",
            "Otomotiv Mühendisliği",
            "Özel Eğitim Öğretmenliği",
            "Pazarlama",
            "Pilotaj",
            "Radyo, Televizyon ve Sinema",
            "Reklamcılık",
            "Sigortacılık",
            "Siyaset Bilimi ve Kamu Yönetimi",
            "Şehir ve Bölge Planlama",
            "Tarih",
            "Tekstil Mühendisliği",
            "Tıp",
            "Turizm İşletmeciliği",
            "Uçak Bakım ve Onarım",
            "Uluslararası İlişkiler",
            "Veteriner",
            "Yazılım Geliştirme",
            "Ziraat Mühendisliği"});
            this.comboBoxIsTanimi.Location = new System.Drawing.Point(160, 141);
            this.comboBoxIsTanimi.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxIsTanimi.Name = "comboBoxIsTanimi";
            this.comboBoxIsTanimi.Size = new System.Drawing.Size(197, 28);
            this.comboBoxIsTanimi.TabIndex = 19;
            this.comboBoxIsTanimi.Text = "Acil Yardım ve Afet Yönetimi";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Enabled = false;
            this.txtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(160, 57);
            this.txtFirmaAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(197, 26);
            this.txtFirmaAdi.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "İş Tanımı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Firma Adı :";
            // 
            // frmIlanGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmIlanGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlan Detay";
            this.Load += new System.EventHandler(this.frmIlanGoruntule_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBasvuruYap;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxSehirler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTecrube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.ComboBox comboBoxIsTanimi;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}