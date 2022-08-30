namespace isBulmaUygulamasi
{
    partial class frmArama
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
            this.btnIlanGoruntule = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.comboBoxIsTanimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxIsTecrubesi = new System.Windows.Forms.ComboBox();
            this.comboBoxSehirler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTanimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecrube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlanVerilmeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmakullaniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIlanGoruntule
            // 
            this.btnIlanGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnIlanGoruntule.FlatAppearance.BorderSize = 0;
            this.btnIlanGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIlanGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnIlanGoruntule.Location = new System.Drawing.Point(9, 8);
            this.btnIlanGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnIlanGoruntule.Name = "btnIlanGoruntule";
            this.btnIlanGoruntule.Size = new System.Drawing.Size(125, 30);
            this.btnIlanGoruntule.TabIndex = 5;
            this.btnIlanGoruntule.Text = "Görüntüle";
            this.btnIlanGoruntule.UseVisualStyleBackColor = false;
            this.btnIlanGoruntule.Click += new System.EventHandler(this.btnIlanGoruntule_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnVazgec.FlatAppearance.BorderSize = 0;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(142, 8);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(4);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(125, 30);
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 48);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIlanGoruntule);
            this.panel2.Controls.Add(this.btnVazgec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(524, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 48);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.comboBoxIsTanimi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBoxIsTecrubesi);
            this.panel3.Controls.Add(this.comboBoxSehirler);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 64);
            this.panel3.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAra);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(704, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 64);
            this.panel5.TabIndex = 19;
            // 
            // btnAra
            // 
            this.btnAra.AutoSize = true;
            this.btnAra.Location = new System.Drawing.Point(18, 28);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(60, 27);
            this.btnAra.TabIndex = 17;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // comboBoxIsTanimi
            // 
            this.comboBoxIsTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.comboBoxIsTanimi.Location = new System.Drawing.Point(96, 29);
            this.comboBoxIsTanimi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIsTanimi.Name = "comboBoxIsTanimi";
            this.comboBoxIsTanimi.Size = new System.Drawing.Size(172, 24);
            this.comboBoxIsTanimi.TabIndex = 18;
            this.comboBoxIsTanimi.Text = "Acil Yardım ve Afet Yönetimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "İş Tanımı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(290, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şehir :";
            // 
            // comboBoxIsTecrubesi
            // 
            this.comboBoxIsTecrubesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIsTecrubesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxIsTecrubesi.FormattingEnabled = true;
            this.comboBoxIsTecrubesi.Items.AddRange(new object[] {
            "Yok",
            "Var"});
            this.comboBoxIsTecrubesi.Location = new System.Drawing.Point(599, 29);
            this.comboBoxIsTecrubesi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIsTecrubesi.Name = "comboBoxIsTecrubesi";
            this.comboBoxIsTecrubesi.Size = new System.Drawing.Size(97, 24);
            this.comboBoxIsTecrubesi.TabIndex = 16;
            // 
            // comboBoxSehirler
            // 
            this.comboBoxSehirler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.comboBoxSehirler.Location = new System.Drawing.Point(347, 29);
            this.comboBoxSehirler.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSehirler.Name = "comboBoxSehirler";
            this.comboBoxSehirler.Size = new System.Drawing.Size(131, 24);
            this.comboBoxSehirler.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(498, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "İş Tecrübesi :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 449);
            this.panel4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IlanId,
            this.Sehir,
            this.IsTanimi,
            this.FirmaAdi,
            this.Tecrube,
            this.Aciklama,
            this.IlanVerilmeTarihi,
            this.FirmakullaniciId});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 449);
            this.dataGridView1.TabIndex = 19;
            // 
            // IlanId
            // 
            this.IlanId.DataPropertyName = "IlanId";
            this.IlanId.HeaderText = "İlan Numarası";
            this.IlanId.Name = "IlanId";
            this.IlanId.ReadOnly = true;
            this.IlanId.Visible = false;
            // 
            // Sehir
            // 
            this.Sehir.DataPropertyName = "Sehir";
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.ReadOnly = true;
            this.Sehir.Visible = false;
            // 
            // IsTanimi
            // 
            this.IsTanimi.DataPropertyName = "IsTanimi";
            this.IsTanimi.HeaderText = "İş Tanımı";
            this.IsTanimi.Name = "IsTanimi";
            this.IsTanimi.ReadOnly = true;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.DataPropertyName = "FirmaAdi";
            this.FirmaAdi.HeaderText = "Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.ReadOnly = true;
            // 
            // Tecrube
            // 
            this.Tecrube.DataPropertyName = "Tecrube";
            this.Tecrube.HeaderText = "Tecrübe";
            this.Tecrube.Name = "Tecrube";
            this.Tecrube.ReadOnly = true;
            this.Tecrube.Visible = false;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Visible = false;
            // 
            // IlanVerilmeTarihi
            // 
            this.IlanVerilmeTarihi.DataPropertyName = "IlanVerilmeTarihi";
            this.IlanVerilmeTarihi.HeaderText = "İlan Tarihi";
            this.IlanVerilmeTarihi.Name = "IlanVerilmeTarihi";
            this.IlanVerilmeTarihi.ReadOnly = true;
            // 
            // FirmakullaniciId
            // 
            this.FirmakullaniciId.DataPropertyName = "FirmaId";
            this.FirmakullaniciId.HeaderText = "Firma Kullanıcı Id";
            this.FirmakullaniciId.Name = "FirmakullaniciId";
            this.FirmakullaniciId.ReadOnly = true;
            this.FirmakullaniciId.Visible = false;
            // 
            // frmArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlan Arama";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIlanGoruntule;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxIsTanimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxIsTecrubesi;
        private System.Windows.Forms.ComboBox comboBoxSehirler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsTanimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecrube;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlanVerilmeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmakullaniciId;
    }
}