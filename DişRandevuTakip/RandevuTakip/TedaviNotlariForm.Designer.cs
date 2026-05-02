namespace RandevuTakip
{
    partial class TedaviNotlariForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlUstAlan;
        private System.Windows.Forms.Panel pnlListeKart;
        private System.Windows.Forms.Panel pnlArama;
        private System.Windows.Forms.Panel pnlButonAlan;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblListeBaslik;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgvTedaviNotlari;
        private System.Windows.Forms.Button btnYeniTedaviNotu;
        private System.Windows.Forms.Button btnTedaviNotuGuncelle;
        private System.Windows.Forms.Button btnTedaviNotuSil;
        private System.Windows.Forms.Button btnYenile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlUstAlan = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlListeKart = new System.Windows.Forms.Panel();
            this.dgvTedaviNotlari = new System.Windows.Forms.DataGridView();
            this.pnlArama = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.lblListeBaslik = new System.Windows.Forms.Label();
            this.pnlButonAlan = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnTedaviNotuSil = new System.Windows.Forms.Button();
            this.btnTedaviNotuGuncelle = new System.Windows.Forms.Button();
            this.btnYeniTedaviNotu = new System.Windows.Forms.Button();
            this.pnlUstAlan.SuspendLayout();
            this.pnlListeKart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedaviNotlari)).BeginInit();
            this.pnlArama.SuspendLayout();
            this.pnlButonAlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUstAlan
            // 
            this.pnlUstAlan.BackColor = System.Drawing.Color.White;
            this.pnlUstAlan.Controls.Add(this.lblBaslik);
            this.pnlUstAlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUstAlan.Location = new System.Drawing.Point(0, 0);
            this.pnlUstAlan.Name = "pnlUstAlan";
            this.pnlUstAlan.Size = new System.Drawing.Size(1268, 104);
            this.pnlUstAlan.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblBaslik.Location = new System.Drawing.Point(28, 24);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(199, 37);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Tedavi Notları";
            // 
            // pnlListeKart
            // 
            this.pnlListeKart.BackColor = System.Drawing.Color.White;
            this.pnlListeKart.Controls.Add(this.dgvTedaviNotlari);
            this.pnlListeKart.Controls.Add(this.pnlArama);
            this.pnlListeKart.Controls.Add(this.lblKayitSayisi);
            this.pnlListeKart.Controls.Add(this.lblListeBaslik);
            this.pnlListeKart.Location = new System.Drawing.Point(28, 128);
            this.pnlListeKart.Name = "pnlListeKart";
            this.pnlListeKart.Size = new System.Drawing.Size(1232, 394);
            this.pnlListeKart.TabIndex = 1;
            this.pnlListeKart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlListeKart_Paint);
            // 
            // dgvTedaviNotlari
            // 
            this.dgvTedaviNotlari.AllowUserToAddRows = false;
            this.dgvTedaviNotlari.AllowUserToDeleteRows = false;
            this.dgvTedaviNotlari.BackgroundColor = System.Drawing.Color.White;
            this.dgvTedaviNotlari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTedaviNotlari.ColumnHeadersHeight = 34;
            this.dgvTedaviNotlari.Location = new System.Drawing.Point(24, 132);
            this.dgvTedaviNotlari.MultiSelect = false;
            this.dgvTedaviNotlari.Name = "dgvTedaviNotlari";
            this.dgvTedaviNotlari.ReadOnly = true;
            this.dgvTedaviNotlari.RowHeadersVisible = false;
            this.dgvTedaviNotlari.RowTemplate.Height = 32;
            this.dgvTedaviNotlari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTedaviNotlari.Size = new System.Drawing.Size(1204, 240);
            this.dgvTedaviNotlari.TabIndex = 3;
            this.dgvTedaviNotlari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTedaviNotlari_CellDoubleClick);
            // 
            // pnlArama
            // 
            this.pnlArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlArama.Controls.Add(this.txtArama);
            this.pnlArama.Controls.Add(this.lblArama);
            this.pnlArama.Location = new System.Drawing.Point(24, 60);
            this.pnlArama.Name = "pnlArama";
            this.pnlArama.Size = new System.Drawing.Size(456, 56);
            this.pnlArama.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArama.Location = new System.Drawing.Point(78, 16);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(350, 25);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblArama.Location = new System.Drawing.Point(18, 19);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(48, 17);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Arama";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKayitSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(125)))));
            this.lblKayitSayisi.Location = new System.Drawing.Point(280, 25);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(200, 20);
            this.lblKayitSayisi.TabIndex = 1;
            this.lblKayitSayisi.Text = "0 tedavi notu listeleniyor";
            this.lblKayitSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblListeBaslik
            // 
            this.lblListeBaslik.AutoSize = true;
            this.lblListeBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListeBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblListeBaslik.Location = new System.Drawing.Point(24, 20);
            this.lblListeBaslik.Name = "lblListeBaslik";
            this.lblListeBaslik.Size = new System.Drawing.Size(177, 25);
            this.lblListeBaslik.TabIndex = 0;
            this.lblListeBaslik.Text = "Tedavi Notu Listesi";
            // 
            // pnlButonAlan
            // 
            this.pnlButonAlan.Controls.Add(this.btnYenile);
            this.pnlButonAlan.Controls.Add(this.btnTedaviNotuSil);
            this.pnlButonAlan.Controls.Add(this.btnTedaviNotuGuncelle);
            this.pnlButonAlan.Controls.Add(this.btnYeniTedaviNotu);
            this.pnlButonAlan.Location = new System.Drawing.Point(28, 542);
            this.pnlButonAlan.Name = "pnlButonAlan";
            this.pnlButonAlan.Size = new System.Drawing.Size(698, 56);
            this.pnlButonAlan.TabIndex = 2;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btnYenile.Location = new System.Drawing.Point(530, 8);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(100, 40);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnTedaviNotuSil
            // 
            this.btnTedaviNotuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnTedaviNotuSil.FlatAppearance.BorderSize = 0;
            this.btnTedaviNotuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedaviNotuSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTedaviNotuSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTedaviNotuSil.Location = new System.Drawing.Point(376, 8);
            this.btnTedaviNotuSil.Name = "btnTedaviNotuSil";
            this.btnTedaviNotuSil.Size = new System.Drawing.Size(140, 40);
            this.btnTedaviNotuSil.TabIndex = 2;
            this.btnTedaviNotuSil.Text = "Notu Sil";
            this.btnTedaviNotuSil.UseVisualStyleBackColor = false;
            this.btnTedaviNotuSil.Click += new System.EventHandler(this.btnTedaviNotuSil_Click);
            // 
            // btnTedaviNotuGuncelle
            // 
            this.btnTedaviNotuGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnTedaviNotuGuncelle.FlatAppearance.BorderSize = 0;
            this.btnTedaviNotuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedaviNotuGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTedaviNotuGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btnTedaviNotuGuncelle.Location = new System.Drawing.Point(182, 8);
            this.btnTedaviNotuGuncelle.Name = "btnTedaviNotuGuncelle";
            this.btnTedaviNotuGuncelle.Size = new System.Drawing.Size(180, 40);
            this.btnTedaviNotuGuncelle.TabIndex = 1;
            this.btnTedaviNotuGuncelle.Text = "Tedavi Notunu Güncelle";
            this.btnTedaviNotuGuncelle.UseVisualStyleBackColor = false;
            this.btnTedaviNotuGuncelle.Click += new System.EventHandler(this.btnTedaviNotuGuncelle_Click);
            // 
            // btnYeniTedaviNotu
            // 
            this.btnYeniTedaviNotu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.btnYeniTedaviNotu.FlatAppearance.BorderSize = 0;
            this.btnYeniTedaviNotu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniTedaviNotu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeniTedaviNotu.ForeColor = System.Drawing.Color.White;
            this.btnYeniTedaviNotu.Location = new System.Drawing.Point(0, 8);
            this.btnYeniTedaviNotu.Name = "btnYeniTedaviNotu";
            this.btnYeniTedaviNotu.Size = new System.Drawing.Size(168, 40);
            this.btnYeniTedaviNotu.TabIndex = 0;
            this.btnYeniTedaviNotu.Text = "+ Yeni Tedavi Notu";
            this.btnYeniTedaviNotu.UseVisualStyleBackColor = false;
            this.btnYeniTedaviNotu.Click += new System.EventHandler(this.btnYeniTedaviNotu_Click);
            // 
            // TedaviNotlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1268, 620);
            this.Controls.Add(this.pnlButonAlan);
            this.Controls.Add(this.pnlListeKart);
            this.Controls.Add(this.pnlUstAlan);
            this.MinimumSize = new System.Drawing.Size(1056, 659);
            this.Name = "TedaviNotlariForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tedavi Notları";
            this.Load += new System.EventHandler(this.TedaviNotlariForm_Load);
            this.pnlUstAlan.ResumeLayout(false);
            this.pnlUstAlan.PerformLayout();
            this.pnlListeKart.ResumeLayout(false);
            this.pnlListeKart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTedaviNotlari)).EndInit();
            this.pnlArama.ResumeLayout(false);
            this.pnlArama.PerformLayout();
            this.pnlButonAlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
