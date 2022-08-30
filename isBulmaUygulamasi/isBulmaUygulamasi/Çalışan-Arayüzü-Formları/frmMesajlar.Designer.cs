namespace isBulmaUygulamasi.Çalışan_Arayüzü_Formları
{
    partial class frmMesajlar
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
            this.btnGecmisMesajlar = new System.Windows.Forms.Button();
            this.btnYeniMesajlar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMesajGoruntule = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MesajId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesajTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GondericiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AliciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesajOkundu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGecmisMesajlar);
            this.panel1.Controls.Add(this.btnYeniMesajlar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnGecmisMesajlar
            // 
            this.btnGecmisMesajlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGecmisMesajlar.Location = new System.Drawing.Point(401, 0);
            this.btnGecmisMesajlar.Name = "btnGecmisMesajlar";
            this.btnGecmisMesajlar.Size = new System.Drawing.Size(401, 48);
            this.btnGecmisMesajlar.TabIndex = 1;
            this.btnGecmisMesajlar.Text = "Geçmiş Mesajlarım";
            this.btnGecmisMesajlar.UseVisualStyleBackColor = true;
            this.btnGecmisMesajlar.Click += new System.EventHandler(this.btnGecmisMesajlar_Click);
            // 
            // btnYeniMesajlar
            // 
            this.btnYeniMesajlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYeniMesajlar.Location = new System.Drawing.Point(0, 0);
            this.btnYeniMesajlar.Name = "btnYeniMesajlar";
            this.btnYeniMesajlar.Size = new System.Drawing.Size(401, 48);
            this.btnYeniMesajlar.TabIndex = 0;
            this.btnYeniMesajlar.Text = "Yeni Mesajlarım";
            this.btnYeniMesajlar.UseVisualStyleBackColor = true;
            this.btnYeniMesajlar.Click += new System.EventHandler(this.btnYeniMesajlar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMesajGoruntule);
            this.panel3.Controls.Add(this.btnGeri);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(524, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 48);
            this.panel3.TabIndex = 0;
            // 
            // btnMesajGoruntule
            // 
            this.btnMesajGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnMesajGoruntule.FlatAppearance.BorderSize = 0;
            this.btnMesajGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesajGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnMesajGoruntule.Location = new System.Drawing.Point(9, 8);
            this.btnMesajGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnMesajGoruntule.Name = "btnMesajGoruntule";
            this.btnMesajGoruntule.Size = new System.Drawing.Size(125, 30);
            this.btnMesajGoruntule.TabIndex = 8;
            this.btnMesajGoruntule.Text = "Görüntüle";
            this.btnMesajGoruntule.UseVisualStyleBackColor = false;
            this.btnMesajGoruntule.Click += new System.EventHandler(this.btnMesajGoruntule_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(3)))));
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(142, 8);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(125, 30);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 465);
            this.panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MesajId,
            this.FirmaAdi,
            this.Mesaj,
            this.MesajTarihi,
            this.GondericiId,
            this.AliciId,
            this.MesajOkundu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(804, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // MesajId
            // 
            this.MesajId.DataPropertyName = "MesajId";
            this.MesajId.HeaderText = "Mesaj Id";
            this.MesajId.Name = "MesajId";
            this.MesajId.ReadOnly = true;
            this.MesajId.Visible = false;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.DataPropertyName = "FirmaAdi";
            this.FirmaAdi.HeaderText = "Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.ReadOnly = true;
            // 
            // Mesaj
            // 
            this.Mesaj.DataPropertyName = "Mesaj";
            this.Mesaj.HeaderText = "Mesaj";
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.ReadOnly = true;
            // 
            // MesajTarihi
            // 
            this.MesajTarihi.DataPropertyName = "MesajTarihi";
            this.MesajTarihi.HeaderText = "Mesaj Tarihi";
            this.MesajTarihi.Name = "MesajTarihi";
            this.MesajTarihi.ReadOnly = true;
            // 
            // GondericiId
            // 
            this.GondericiId.DataPropertyName = "GondericiId";
            this.GondericiId.HeaderText = "Gönderici Id";
            this.GondericiId.Name = "GondericiId";
            this.GondericiId.ReadOnly = true;
            this.GondericiId.Visible = false;
            // 
            // AliciId
            // 
            this.AliciId.DataPropertyName = "AliciId";
            this.AliciId.HeaderText = "Alıcı Id";
            this.AliciId.Name = "AliciId";
            this.AliciId.ReadOnly = true;
            this.AliciId.Visible = false;
            // 
            // MesajOkundu
            // 
            this.MesajOkundu.DataPropertyName = "MesajOkundu";
            this.MesajOkundu.HeaderText = "Mesaj Okundu";
            this.MesajOkundu.Name = "MesajOkundu";
            this.MesajOkundu.ReadOnly = true;
            this.MesajOkundu.Visible = false;
            // 
            // frmMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMesajlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesajlarım";
            this.Load += new System.EventHandler(this.frmMesajlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGecmisMesajlar;
        private System.Windows.Forms.Button btnYeniMesajlar;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnMesajGoruntule;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesajId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesajTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GondericiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AliciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesajOkundu;
    }
}