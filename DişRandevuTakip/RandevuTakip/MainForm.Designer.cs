namespace RandevuTakip
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSolMenu;
        private System.Windows.Forms.Panel pnlUstAlan;
        private System.Windows.Forms.Panel pnlListeKart;
        private System.Windows.Forms.Panel pnlButonAlan;
        private System.Windows.Forms.Panel pnlArama;
        private System.Windows.Forms.Label lblKlinikAdi;
        private System.Windows.Forms.Label lblMenuBaslik;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblListeBaslik;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Button btnYeniRandevu;
        private System.Windows.Forms.Button btnRandevuGuncelle;
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnBugun;
        private System.Windows.Forms.Button btnTumRandevular;

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
            this.pnlSolMenu = new System.Windows.Forms.Panel();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.lblMenuBaslik = new System.Windows.Forms.Label();
            this.lblKlinikAdi = new System.Windows.Forms.Label();
            this.pnlUstAlan = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlListeKart = new System.Windows.Forms.Panel();
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.pnlArama = new System.Windows.Forms.Panel();
            this.btnTumRandevular = new System.Windows.Forms.Button();
            this.btnBugun = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.lblListeBaslik = new System.Windows.Forms.Label();
            this.pnlButonAlan = new System.Windows.Forms.Panel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.btnRandevuGuncelle = new System.Windows.Forms.Button();
            this.btnYeniRandevu = new System.Windows.Forms.Button();
            this.pnlSolMenu.SuspendLayout();
            this.pnlUstAlan.SuspendLayout();
            this.pnlListeKart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.pnlArama.SuspendLayout();
            this.pnlButonAlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSolMenu
            // 
            this.pnlSolMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.pnlSolMenu.Controls.Add(this.lblMenu3);
            this.pnlSolMenu.Controls.Add(this.lblMenu1);
            this.pnlSolMenu.Controls.Add(this.lblMenuBaslik);
            this.pnlSolMenu.Controls.Add(this.lblKlinikAdi);
            this.pnlSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSolMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSolMenu.Name = "pnlSolMenu";
            this.pnlSolMenu.Size = new System.Drawing.Size(230, 680);
            this.pnlSolMenu.TabIndex = 0;
            // 
            // lblMenu3
            // 
            this.lblMenu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMenu3.ForeColor = System.Drawing.Color.White;
            this.lblMenu3.Location = new System.Drawing.Point(0, 194);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lblMenu3.Size = new System.Drawing.Size(230, 44);
            this.lblMenu3.TabIndex = 3;
            this.lblMenu3.Text = "Tedavi Notları";
            this.lblMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu3.Click += new System.EventHandler(this.lblMenu3_Click);
            // 
            // lblMenu1
            // 
            this.lblMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMenu1.ForeColor = System.Drawing.Color.White;
            this.lblMenu1.Location = new System.Drawing.Point(0, 146);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lblMenu1.Size = new System.Drawing.Size(230, 44);
            this.lblMenu1.TabIndex = 2;
            this.lblMenu1.Text = "Randevular";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenu1.Click += new System.EventHandler(this.lblMenu1_Click);
            // 
            // lblMenuBaslik
            // 
            this.lblMenuBaslik.AutoSize = true;
            this.lblMenuBaslik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMenuBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(222)))), ((int)(((byte)(232)))));
            this.lblMenuBaslik.Location = new System.Drawing.Point(28, 108);
            this.lblMenuBaslik.Name = "lblMenuBaslik";
            this.lblMenuBaslik.Size = new System.Drawing.Size(42, 15);
            this.lblMenuBaslik.TabIndex = 1;
            this.lblMenuBaslik.Text = "MENÜ";
            // 
            // lblKlinikAdi
            // 
            this.lblKlinikAdi.AutoSize = true;
            this.lblKlinikAdi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKlinikAdi.ForeColor = System.Drawing.Color.White;
            this.lblKlinikAdi.Location = new System.Drawing.Point(24, 32);
            this.lblKlinikAdi.Name = "lblKlinikAdi";
            this.lblKlinikAdi.Size = new System.Drawing.Size(160, 37);
            this.lblKlinikAdi.TabIndex = 0;
            this.lblKlinikAdi.Text = "DentalCare";
            // 
            // pnlUstAlan
            // 
            this.pnlUstAlan.BackColor = System.Drawing.Color.White;
            this.pnlUstAlan.Controls.Add(this.lblBaslik);
            this.pnlUstAlan.Location = new System.Drawing.Point(230, 0);
            this.pnlUstAlan.Name = "pnlUstAlan";
            this.pnlUstAlan.Size = new System.Drawing.Size(1025, 108);
            this.pnlUstAlan.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblBaslik.Location = new System.Drawing.Point(32, 28);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(454, 38);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Diş Kliniği Randevu Takip Sistemi";
            // 
            // pnlListeKart
            // 
            this.pnlListeKart.BackColor = System.Drawing.Color.White;
            this.pnlListeKart.Controls.Add(this.dgvRandevular);
            this.pnlListeKart.Controls.Add(this.pnlArama);
            this.pnlListeKart.Controls.Add(this.lblKayitSayisi);
            this.pnlListeKart.Controls.Add(this.lblListeBaslik);
            this.pnlListeKart.Location = new System.Drawing.Point(258, 132);
            this.pnlListeKart.Name = "pnlListeKart";
            this.pnlListeKart.Size = new System.Drawing.Size(997, 438);
            this.pnlListeKart.TabIndex = 2;
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.AllowUserToAddRows = false;
            this.dgvRandevular.AllowUserToDeleteRows = false;
            this.dgvRandevular.BackgroundColor = System.Drawing.Color.White;
            this.dgvRandevular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRandevular.ColumnHeadersHeight = 34;
            this.dgvRandevular.Location = new System.Drawing.Point(24, 136);
            this.dgvRandevular.MultiSelect = false;
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.ReadOnly = true;
            this.dgvRandevular.RowHeadersVisible = false;
            this.dgvRandevular.RowTemplate.Height = 32;
            this.dgvRandevular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevular.Size = new System.Drawing.Size(947, 276);
            this.dgvRandevular.TabIndex = 3;
            this.dgvRandevular.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRandevular_CellDoubleClick);
            // 
            // pnlArama
            // 
            this.pnlArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlArama.Controls.Add(this.btnTumRandevular);
            this.pnlArama.Controls.Add(this.btnBugun);
            this.pnlArama.Controls.Add(this.txtArama);
            this.pnlArama.Controls.Add(this.lblArama);
            this.pnlArama.Location = new System.Drawing.Point(24, 60);
            this.pnlArama.Name = "pnlArama";
            this.pnlArama.Size = new System.Drawing.Size(947, 58);
            this.pnlArama.TabIndex = 2;
            // 
            // btnTumRandevular
            // 
            this.btnTumRandevular.BackColor = System.Drawing.Color.White;
            this.btnTumRandevular.FlatAppearance.BorderSize = 0;
            this.btnTumRandevular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumRandevular.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTumRandevular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btnTumRandevular.Location = new System.Drawing.Point(568, 13);
            this.btnTumRandevular.Name = "btnTumRandevular";
            this.btnTumRandevular.Size = new System.Drawing.Size(132, 32);
            this.btnTumRandevular.TabIndex = 3;
            this.btnTumRandevular.Text = "Tüm Randevular";
            this.btnTumRandevular.UseVisualStyleBackColor = false;
            this.btnTumRandevular.Click += new System.EventHandler(this.btnTumRandevular_Click);
            // 
            // btnBugun
            // 
            this.btnBugun.BackColor = System.Drawing.Color.White;
            this.btnBugun.FlatAppearance.BorderSize = 0;
            this.btnBugun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBugun.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnBugun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.btnBugun.Location = new System.Drawing.Point(420, 13);
            this.btnBugun.Name = "btnBugun";
            this.btnBugun.Size = new System.Drawing.Size(136, 32);
            this.btnBugun.TabIndex = 2;
            this.btnBugun.Text = "Bugünkü Randevular";
            this.btnBugun.UseVisualStyleBackColor = false;
            this.btnBugun.Click += new System.EventHandler(this.btnBugun_Click);
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArama.Location = new System.Drawing.Point(78, 17);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(312, 25);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblArama.Location = new System.Drawing.Point(18, 20);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(48, 17);
            this.lblArama.TabIndex = 0;
            this.lblArama.Text = "Arama";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKayitSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(125)))));
            this.lblKayitSayisi.Location = new System.Drawing.Point(650, 24);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(160, 20);
            this.lblKayitSayisi.TabIndex = 1;
            this.lblKayitSayisi.Text = "0 randevu listeleniyor";
            this.lblKayitSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblListeBaslik
            // 
            this.lblListeBaslik.AutoSize = true;
            this.lblListeBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblListeBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblListeBaslik.Location = new System.Drawing.Point(24, 20);
            this.lblListeBaslik.Name = "lblListeBaslik";
            this.lblListeBaslik.Size = new System.Drawing.Size(148, 25);
            this.lblListeBaslik.TabIndex = 0;
            this.lblListeBaslik.Text = "Randevu Listesi";
            // 
            // pnlButonAlan
            // 
            this.pnlButonAlan.BackColor = System.Drawing.Color.Transparent;
            this.pnlButonAlan.Controls.Add(this.btnYenile);
            this.pnlButonAlan.Controls.Add(this.btnRandevuSil);
            this.pnlButonAlan.Controls.Add(this.btnRandevuGuncelle);
            this.pnlButonAlan.Controls.Add(this.btnYeniRandevu);
            this.pnlButonAlan.Location = new System.Drawing.Point(258, 592);
            this.pnlButonAlan.Name = "pnlButonAlan";
            this.pnlButonAlan.Size = new System.Drawing.Size(997, 56);
            this.pnlButonAlan.TabIndex = 3;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btnYenile.Location = new System.Drawing.Point(592, 8);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(112, 40);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnRandevuSil.FlatAppearance.BorderSize = 0;
            this.btnRandevuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuSil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRandevuSil.Location = new System.Drawing.Point(423, 8);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(140, 40);
            this.btnRandevuSil.TabIndex = 2;
            this.btnRandevuSil.Text = "Randevuyu Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = false;
            this.btnRandevuSil.Click += new System.EventHandler(this.btnRandevuSil_Click);
            // 
            // btnRandevuGuncelle
            // 
            this.btnRandevuGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnRandevuGuncelle.FlatAppearance.BorderSize = 0;
            this.btnRandevuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btnRandevuGuncelle.Location = new System.Drawing.Point(211, 8);
            this.btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            this.btnRandevuGuncelle.Size = new System.Drawing.Size(170, 40);
            this.btnRandevuGuncelle.TabIndex = 1;
            this.btnRandevuGuncelle.Text = "Randevuyu Güncelle";
            this.btnRandevuGuncelle.UseVisualStyleBackColor = false;
            this.btnRandevuGuncelle.Click += new System.EventHandler(this.btnRandevuGuncelle_Click);
            // 
            // btnYeniRandevu
            // 
            this.btnYeniRandevu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.btnYeniRandevu.FlatAppearance.BorderSize = 0;
            this.btnYeniRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniRandevu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeniRandevu.ForeColor = System.Drawing.Color.White;
            this.btnYeniRandevu.Location = new System.Drawing.Point(0, 8);
            this.btnYeniRandevu.Name = "btnYeniRandevu";
            this.btnYeniRandevu.Size = new System.Drawing.Size(160, 40);
            this.btnYeniRandevu.TabIndex = 0;
            this.btnYeniRandevu.Text = "+ Yeni Randevu";
            this.btnYeniRandevu.UseVisualStyleBackColor = false;
            this.btnYeniRandevu.Click += new System.EventHandler(this.btnYeniRandevu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1315, 680);
            this.Controls.Add(this.pnlButonAlan);
            this.Controls.Add(this.pnlListeKart);
            this.Controls.Add(this.pnlUstAlan);
            this.Controls.Add(this.pnlSolMenu);
            this.MinimumSize = new System.Drawing.Size(1136, 719);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diş Kliniği Randevu Takip Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSolMenu.ResumeLayout(false);
            this.pnlSolMenu.PerformLayout();
            this.pnlUstAlan.ResumeLayout(false);
            this.pnlUstAlan.PerformLayout();
            this.pnlListeKart.ResumeLayout(false);
            this.pnlListeKart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.pnlArama.ResumeLayout(false);
            this.pnlArama.PerformLayout();
            this.pnlButonAlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
