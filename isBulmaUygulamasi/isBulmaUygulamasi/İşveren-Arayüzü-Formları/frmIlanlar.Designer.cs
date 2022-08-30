namespace isBulmaUygulamasi
{
    partial class frmIlanlar
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
            this.btnBasvurulariGoruntule = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTanimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecrube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlanVerilmeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasvurulariGoruntule
            // 
            this.btnBasvurulariGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnBasvurulariGoruntule.FlatAppearance.BorderSize = 0;
            this.btnBasvurulariGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasvurulariGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasvurulariGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnBasvurulariGoruntule.Location = new System.Drawing.Point(9, 8);
            this.btnBasvurulariGoruntule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBasvurulariGoruntule.Name = "btnBasvurulariGoruntule";
            this.btnBasvurulariGoruntule.Size = new System.Drawing.Size(125, 30);
            this.btnBasvurulariGoruntule.TabIndex = 1;
            this.btnBasvurulariGoruntule.Text = "Başvurular";
            this.btnBasvurulariGoruntule.UseVisualStyleBackColor = false;
            this.btnBasvurulariGoruntule.Click += new System.EventHandler(this.btnBasvurulariGoruntule_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnVazgec.FlatAppearance.BorderSize = 0;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(142, 8);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(125, 30);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(13, 8);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "İlanı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 48);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 48);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVazgec);
            this.panel2.Controls.Add(this.btnBasvurulariGoruntule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(524, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 48);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 513);
            this.panel4.TabIndex = 5;
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
            this.FirmaAdi,
            this.FirmaId,
            this.IsTanimi,
            this.Tecrube,
            this.Aciklama,
            this.IlanVerilmeTarihi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 513);
            this.dataGridView1.TabIndex = 1;
            // 
            // IlanId
            // 
            this.IlanId.DataPropertyName = "IlanId";
            this.IlanId.HeaderText = "İlan Numarası";
            this.IlanId.Name = "IlanId";
            this.IlanId.ReadOnly = true;
            // 
            // Sehir
            // 
            this.Sehir.DataPropertyName = "Sehir";
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.Name = "Sehir";
            this.Sehir.ReadOnly = true;
            this.Sehir.Visible = false;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.DataPropertyName = "FirmaAdi";
            this.FirmaAdi.HeaderText = "Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.ReadOnly = true;
            this.FirmaAdi.Visible = false;
            // 
            // FirmaId
            // 
            this.FirmaId.DataPropertyName = "FirmaId";
            this.FirmaId.HeaderText = "FirmaId";
            this.FirmaId.Name = "FirmaId";
            this.FirmaId.ReadOnly = true;
            this.FirmaId.Visible = false;
            // 
            // IsTanimi
            // 
            this.IsTanimi.DataPropertyName = "IsTanimi";
            this.IsTanimi.HeaderText = "İş Tanımı";
            this.IsTanimi.Name = "IsTanimi";
            this.IsTanimi.ReadOnly = true;
            // 
            // Tecrube
            // 
            this.Tecrube.DataPropertyName = "Tecrube";
            this.Tecrube.HeaderText = "Tecrübe";
            this.Tecrube.Name = "Tecrube";
            this.Tecrube.ReadOnly = true;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            // 
            // IlanVerilmeTarihi
            // 
            this.IlanVerilmeTarihi.DataPropertyName = "IlanVerilmeTarihi";
            this.IlanVerilmeTarihi.HeaderText = "İlan Tarihi";
            this.IlanVerilmeTarihi.Name = "IlanVerilmeTarihi";
            this.IlanVerilmeTarihi.ReadOnly = true;
            // 
            // frmIlanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIlanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlanlarım";
            this.Load += new System.EventHandler(this.frmIlanlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBasvurulariGoruntule;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsTanimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tecrube;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlanVerilmeTarihi;
    }
}