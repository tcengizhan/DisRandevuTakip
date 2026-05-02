namespace RandevuTakip
{
    partial class TedaviNotuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlUstAlan;
        private System.Windows.Forms.Panel pnlFormKart;
        private System.Windows.Forms.Panel pnlButonAlan;
        private System.Windows.Forms.Label lblFormBaslik;
        private System.Windows.Forms.Label lblRandevu;
        private System.Windows.Forms.Label lblTedaviTuru;
        private System.Windows.Forms.Label lblTedaviTarihi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ComboBox cmbRandevu;
        private System.Windows.Forms.ComboBox cmbTedaviTuru;
        private System.Windows.Forms.DateTimePicker dtpTedaviTarihi;
        private System.Windows.Forms.TextBox txtAciklama;
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
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dtpTedaviTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTedaviTarihi = new System.Windows.Forms.Label();
            this.cmbTedaviTuru = new System.Windows.Forms.ComboBox();
            this.lblTedaviTuru = new System.Windows.Forms.Label();
            this.cmbRandevu = new System.Windows.Forms.ComboBox();
            this.lblRandevu = new System.Windows.Forms.Label();
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
            this.pnlUstAlan.Size = new System.Drawing.Size(520, 100);
            this.pnlUstAlan.TabIndex = 0;
            // 
            // lblFormBaslik
            // 
            this.lblFormBaslik.AutoSize = true;
            this.lblFormBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblFormBaslik.Location = new System.Drawing.Point(28, 22);
            this.lblFormBaslik.Name = "lblFormBaslik";
            this.lblFormBaslik.Size = new System.Drawing.Size(207, 32);
            this.lblFormBaslik.TabIndex = 0;
            this.lblFormBaslik.Text = "Yeni Tedavi Notu";
            // 
            // pnlFormKart
            // 
            this.pnlFormKart.BackColor = System.Drawing.Color.White;
            this.pnlFormKart.Controls.Add(this.txtAciklama);
            this.pnlFormKart.Controls.Add(this.lblAciklama);
            this.pnlFormKart.Controls.Add(this.dtpTedaviTarihi);
            this.pnlFormKart.Controls.Add(this.lblTedaviTarihi);
            this.pnlFormKart.Controls.Add(this.cmbTedaviTuru);
            this.pnlFormKart.Controls.Add(this.lblTedaviTuru);
            this.pnlFormKart.Controls.Add(this.cmbRandevu);
            this.pnlFormKart.Controls.Add(this.lblRandevu);
            this.pnlFormKart.Location = new System.Drawing.Point(28, 122);
            this.pnlFormKart.Name = "pnlFormKart";
            this.pnlFormKart.Size = new System.Drawing.Size(464, 320);
            this.pnlFormKart.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(252)))), ((int)(((byte)(253)))));
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAciklama.Location = new System.Drawing.Point(31, 174);
            this.txtAciklama.MaxLength = 1000;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(400, 120);
            this.txtAciklama.TabIndex = 9;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblAciklama.Location = new System.Drawing.Point(28, 152);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(83, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Tedavi Notu";
            // 
            // dtpTedaviTarihi
            // 
            this.dtpTedaviTarihi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpTedaviTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTedaviTarihi.Location = new System.Drawing.Point(253, 110);
            this.dtpTedaviTarihi.Name = "dtpTedaviTarihi";
            this.dtpTedaviTarihi.Size = new System.Drawing.Size(178, 26);
            this.dtpTedaviTarihi.TabIndex = 7;
            // 
            // lblTedaviTarihi
            // 
            this.lblTedaviTarihi.AutoSize = true;
            this.lblTedaviTarihi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTedaviTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblTedaviTarihi.Location = new System.Drawing.Point(250, 88);
            this.lblTedaviTarihi.Name = "lblTedaviTarihi";
            this.lblTedaviTarihi.Size = new System.Drawing.Size(87, 17);
            this.lblTedaviTarihi.TabIndex = 6;
            this.lblTedaviTarihi.Text = "Tedavi Tarihi";
            // 
            // cmbTedaviTuru
            // 
            this.cmbTedaviTuru.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbTedaviTuru.FormattingEnabled = true;
            this.cmbTedaviTuru.Location = new System.Drawing.Point(31, 110);
            this.cmbTedaviTuru.Name = "cmbTedaviTuru";
            this.cmbTedaviTuru.Size = new System.Drawing.Size(190, 27);
            this.cmbTedaviTuru.TabIndex = 5;
            // 
            // lblTedaviTuru
            // 
            this.lblTedaviTuru.AutoSize = true;
            this.lblTedaviTuru.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTedaviTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblTedaviTuru.Location = new System.Drawing.Point(28, 88);
            this.lblTedaviTuru.Name = "lblTedaviTuru";
            this.lblTedaviTuru.Size = new System.Drawing.Size(80, 17);
            this.lblTedaviTuru.TabIndex = 4;
            this.lblTedaviTuru.Text = "Tedavi Türü";
            // 
            // cmbRandevu
            // 
            this.cmbRandevu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRandevu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbRandevu.FormattingEnabled = true;
            this.cmbRandevu.Location = new System.Drawing.Point(31, 46);
            this.cmbRandevu.Name = "cmbRandevu";
            this.cmbRandevu.Size = new System.Drawing.Size(400, 27);
            this.cmbRandevu.TabIndex = 3;
            // 
            // lblRandevu
            // 
            this.lblRandevu.AutoSize = true;
            this.lblRandevu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRandevu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.lblRandevu.Location = new System.Drawing.Point(28, 24);
            this.lblRandevu.Name = "lblRandevu";
            this.lblRandevu.Size = new System.Drawing.Size(61, 17);
            this.lblRandevu.TabIndex = 2;
            this.lblRandevu.Text = "Randevu";
            // 
            // pnlButonAlan
            // 
            this.pnlButonAlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.pnlButonAlan.Controls.Add(this.btnIptal);
            this.pnlButonAlan.Controls.Add(this.btnKaydet);
            this.pnlButonAlan.Location = new System.Drawing.Point(28, 460);
            this.pnlButonAlan.Name = "pnlButonAlan";
            this.pnlButonAlan.Size = new System.Drawing.Size(464, 56);
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
            this.btnIptal.Location = new System.Drawing.Point(330, 8);
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
            this.btnKaydet.Location = new System.Drawing.Point(184, 8);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 40);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // TedaviNotuForm
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(520, 534);
            this.Controls.Add(this.pnlButonAlan);
            this.Controls.Add(this.pnlFormKart);
            this.Controls.Add(this.pnlUstAlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TedaviNotuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Tedavi Notu";
            this.pnlUstAlan.ResumeLayout(false);
            this.pnlUstAlan.PerformLayout();
            this.pnlFormKart.ResumeLayout(false);
            this.pnlFormKart.PerformLayout();
            this.pnlButonAlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
