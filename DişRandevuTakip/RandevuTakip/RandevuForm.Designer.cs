namespace RandevuTakip
{
    partial class RandevuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlUstAlan;
        private System.Windows.Forms.Panel pnlFormKart;
        private System.Windows.Forms.Panel pnlButonAlan;
        private System.Windows.Forms.Label lblFormBaslik;
        private System.Windows.Forms.Label lblKisi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTedaviTuru;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.DateTimePicker dtpSaat;
        private System.Windows.Forms.ComboBox cmbTedaviTuru;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;

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
            this.lblFormBaslik = new System.Windows.Forms.Label();
            this.pnlFormKart = new System.Windows.Forms.Panel();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbTedaviTuru = new System.Windows.Forms.ComboBox();
            this.lblTedaviTuru = new System.Windows.Forms.Label();
            this.dtpSaat = new System.Windows.Forms.DateTimePicker();
            this.lblSaat = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.lblKisi = new System.Windows.Forms.Label();
            this.pnlButonAlan = new System.Windows.Forms.Panel();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pnlUstAlan.SuspendLayout();
            this.pnlFormKart.SuspendLayout();
            this.pnlButonAlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUstAlan
            // 
            this.pnlUstAlan.BackColor = System.Drawing.Color.White;
            this.pnlUstAlan.Controls.Add(this.lblFormBaslik);
            this.pnlUstAlan.Location = new System.Drawing.Point(0, 0);
            this.pnlUstAlan.Name = "pnlUstAlan";
            this.pnlUstAlan.Size = new System.Drawing.Size(500, 102);
            this.pnlUstAlan.TabIndex = 0;
            // 
            // lblFormBaslik
            // 
            this.lblFormBaslik.AutoSize = true;
            this.lblFormBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblFormBaslik.Location = new System.Drawing.Point(28, 22);
            this.lblFormBaslik.Name = "lblFormBaslik";
            this.lblFormBaslik.Size = new System.Drawing.Size(169, 32);
            this.lblFormBaslik.TabIndex = 0;
            this.lblFormBaslik.Text = "Yeni Randevu";
            // 
            // pnlFormKart
            // 
            this.pnlFormKart.BackColor = System.Drawing.Color.White;
            this.pnlFormKart.Controls.Add(this.txtNotlar);
            this.pnlFormKart.Controls.Add(this.lblNotlar);
            this.pnlFormKart.Controls.Add(this.cmbDurum);
            this.pnlFormKart.Controls.Add(this.lblDurum);
            this.pnlFormKart.Controls.Add(this.cmbTedaviTuru);
            this.pnlFormKart.Controls.Add(this.lblTedaviTuru);
            this.pnlFormKart.Controls.Add(this.dtpSaat);
            this.pnlFormKart.Controls.Add(this.lblSaat);
            this.pnlFormKart.Controls.Add(this.dtpTarih);
            this.pnlFormKart.Controls.Add(this.lblTarih);
            this.pnlFormKart.Controls.Add(this.txtTelefon);
            this.pnlFormKart.Controls.Add(this.lblTelefon);
            this.pnlFormKart.Controls.Add(this.txtKisi);
            this.pnlFormKart.Controls.Add(this.lblKisi);
            this.pnlFormKart.Location = new System.Drawing.Point(28, 122);
            this.pnlFormKart.Name = "pnlFormKart";
            this.pnlFormKart.Size = new System.Drawing.Size(444, 410);
            this.pnlFormKart.TabIndex = 1;
            // 
            // txtNotlar
            // 
            this.txtNotlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtNotlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotlar.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNotlar.Location = new System.Drawing.Point(31, 302);
            this.txtNotlar.MaxLength = 500;
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(380, 78);
            this.txtNotlar.TabIndex = 13;
            // 
            // lblNotlar
            // 
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNotlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblNotlar.Location = new System.Drawing.Point(28, 280);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(150, 17);
            this.lblNotlar.TabIndex = 12;
            this.lblNotlar.Text = "Tedavi / Randevu Notu";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(233, 236);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(178, 27);
            this.cmbDurum.TabIndex = 11;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblDurum.Location = new System.Drawing.Point(230, 214);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(51, 17);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durum";
            // 
            // cmbTedaviTuru
            // 
            this.cmbTedaviTuru.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbTedaviTuru.FormattingEnabled = true;
            this.cmbTedaviTuru.Location = new System.Drawing.Point(31, 236);
            this.cmbTedaviTuru.Name = "cmbTedaviTuru";
            this.cmbTedaviTuru.Size = new System.Drawing.Size(180, 27);
            this.cmbTedaviTuru.TabIndex = 9;
            // 
            // lblTedaviTuru
            // 
            this.lblTedaviTuru.AutoSize = true;
            this.lblTedaviTuru.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTedaviTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblTedaviTuru.Location = new System.Drawing.Point(28, 214);
            this.lblTedaviTuru.Name = "lblTedaviTuru";
            this.lblTedaviTuru.Size = new System.Drawing.Size(80, 17);
            this.lblTedaviTuru.TabIndex = 8;
            this.lblTedaviTuru.Text = "Tedavi Türü";
            // 
            // dtpSaat
            // 
            this.dtpSaat.CustomFormat = "HH:mm";
            this.dtpSaat.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpSaat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaat.Location = new System.Drawing.Point(233, 172);
            this.dtpSaat.Name = "dtpSaat";
            this.dtpSaat.ShowUpDown = true;
            this.dtpSaat.Size = new System.Drawing.Size(178, 26);
            this.dtpSaat.TabIndex = 7;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblSaat.Location = new System.Drawing.Point(230, 150);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(95, 17);
            this.lblSaat.TabIndex = 6;
            this.lblSaat.Text = "Randevu Saati";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(31, 172);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(180, 26);
            this.dtpTarih.TabIndex = 5;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblTarih.Location = new System.Drawing.Point(28, 150);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(100, 17);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Randevu Tarihi";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTelefon.Location = new System.Drawing.Point(31, 110);
            this.txtTelefon.MaxLength = 30;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(380, 26);
            this.txtTelefon.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblTelefon.Location = new System.Drawing.Point(28, 88);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(54, 17);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon";
            // 
            // txtKisi
            // 
            this.txtKisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtKisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKisi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtKisi.Location = new System.Drawing.Point(31, 48);
            this.txtKisi.MaxLength = 100;
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(380, 26);
            this.txtKisi.TabIndex = 1;
            // 
            // lblKisi
            // 
            this.lblKisi.AutoSize = true;
            this.lblKisi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblKisi.Location = new System.Drawing.Point(28, 26);
            this.lblKisi.Name = "lblKisi";
            this.lblKisi.Size = new System.Drawing.Size(113, 17);
            this.lblKisi.TabIndex = 0;
            this.lblKisi.Text = "Hasta Adı Soyadı";
            // 
            // pnlButonAlan
            // 
            this.pnlButonAlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.pnlButonAlan.Controls.Add(this.btnIptal);
            this.pnlButonAlan.Controls.Add(this.btnKaydet);
            this.pnlButonAlan.Location = new System.Drawing.Point(28, 550);
            this.pnlButonAlan.Name = "pnlButonAlan";
            this.pnlButonAlan.Size = new System.Drawing.Size(444, 56);
            this.pnlButonAlan.TabIndex = 2;
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(94)))), ((int)(((byte)(112)))));
            this.btnIptal.Location = new System.Drawing.Point(310, 8);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(120, 40);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(164, 8);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 40);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // RandevuForm
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(500, 624);
            this.Controls.Add(this.pnlButonAlan);
            this.Controls.Add(this.pnlFormKart);
            this.Controls.Add(this.pnlUstAlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandevuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Randevu";
            this.pnlUstAlan.ResumeLayout(false);
            this.pnlUstAlan.PerformLayout();
            this.pnlFormKart.ResumeLayout(false);
            this.pnlFormKart.PerformLayout();
            this.pnlButonAlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
