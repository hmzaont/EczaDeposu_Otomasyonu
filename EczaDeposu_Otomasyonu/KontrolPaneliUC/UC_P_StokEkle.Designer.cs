namespace EczaDeposu_Otomasyonu.KontrolPaneliUC
{
    partial class UC_P_StokEkle
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_StokEkle));
            this.lblStokEkle = new System.Windows.Forms.Label();
            this.lblStokID = new System.Windows.Forms.Label();
            this.txtStokID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStokAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStokAdi = new System.Windows.Forms.Label();
            this.txtBarkodNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.txtMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.dtpUretimTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblUretimTarihi = new System.Windows.Forms.Label();
            this.lblSonKullanmaTarihi = new System.Windows.Forms.Label();
            this.dtpSonKullanmaTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnEkle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblStokEkle
            // 
            this.lblStokEkle.AutoSize = true;
            this.lblStokEkle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokEkle.Location = new System.Drawing.Point(57, 45);
            this.lblStokEkle.Name = "lblStokEkle";
            this.lblStokEkle.Size = new System.Drawing.Size(156, 38);
            this.lblStokEkle.TabIndex = 0;
            this.lblStokEkle.Text = "Stok Ekle";
            this.lblStokEkle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStokID
            // 
            this.lblStokID.AutoSize = true;
            this.lblStokID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokID.Location = new System.Drawing.Point(108, 148);
            this.lblStokID.Name = "lblStokID";
            this.lblStokID.Size = new System.Drawing.Size(75, 20);
            this.lblStokID.TabIndex = 1;
            this.lblStokID.Text = "Stok ID:";
            // 
            // txtStokID
            // 
            this.txtStokID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStokID.DefaultText = "";
            this.txtStokID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStokID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStokID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokID.Location = new System.Drawing.Point(112, 172);
            this.txtStokID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokID.Name = "txtStokID";
            this.txtStokID.PasswordChar = '\0';
            this.txtStokID.PlaceholderText = "";
            this.txtStokID.SelectedText = "";
            this.txtStokID.Size = new System.Drawing.Size(340, 36);
            this.txtStokID.TabIndex = 2;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStokAdi.DefaultText = "";
            this.txtStokAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStokAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStokAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokAdi.Location = new System.Drawing.Point(112, 286);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.PasswordChar = '\0';
            this.txtStokAdi.PlaceholderText = "";
            this.txtStokAdi.SelectedText = "";
            this.txtStokAdi.Size = new System.Drawing.Size(340, 36);
            this.txtStokAdi.TabIndex = 4;
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.AutoSize = true;
            this.lblStokAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokAdi.Location = new System.Drawing.Point(108, 262);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(82, 20);
            this.lblStokAdi.TabIndex = 3;
            this.lblStokAdi.Text = "Stok Adı:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarkodNo.DefaultText = "";
            this.txtBarkodNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarkodNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarkodNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarkodNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarkodNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarkodNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarkodNo.Location = new System.Drawing.Point(112, 403);
            this.txtBarkodNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.PasswordChar = '\0';
            this.txtBarkodNo.PlaceholderText = "";
            this.txtBarkodNo.SelectedText = "";
            this.txtBarkodNo.Size = new System.Drawing.Size(340, 36);
            this.txtBarkodNo.TabIndex = 6;
            // 
            // lblBarkodNo
            // 
            this.lblBarkodNo.AutoSize = true;
            this.lblBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarkodNo.Location = new System.Drawing.Point(108, 379);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(98, 20);
            this.lblBarkodNo.TabIndex = 5;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiktar.DefaultText = "";
            this.txtMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktar.Location = new System.Drawing.Point(649, 286);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.PasswordChar = '\0';
            this.txtMiktar.PlaceholderText = "";
            this.txtMiktar.SelectedText = "";
            this.txtMiktar.Size = new System.Drawing.Size(340, 36);
            this.txtMiktar.TabIndex = 8;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiktar.Location = new System.Drawing.Point(645, 262);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(63, 20);
            this.lblMiktar.TabIndex = 7;
            this.lblMiktar.Text = "Miktar:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirimFiyat.DefaultText = "";
            this.txtBirimFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBirimFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBirimFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirimFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirimFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirimFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirimFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirimFiyat.Location = new System.Drawing.Point(649, 403);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.PlaceholderText = "";
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.Size = new System.Drawing.Size(340, 36);
            this.txtBirimFiyat.TabIndex = 10;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(645, 379);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(98, 20);
            this.lblBirimFiyat.TabIndex = 9;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.BorderThickness = 1;
            this.dtpUretimTarihi.Checked = true;
            this.dtpUretimTarihi.FillColor = System.Drawing.Color.White;
            this.dtpUretimTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(112, 519);
            this.dtpUretimTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpUretimTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(340, 36);
            this.dtpUretimTarihi.TabIndex = 11;
            this.dtpUretimTarihi.Value = new System.DateTime(2023, 1, 1, 17, 53, 8, 0);
            // 
            // lblUretimTarihi
            // 
            this.lblUretimTarihi.AutoSize = true;
            this.lblUretimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUretimTarihi.Location = new System.Drawing.Point(108, 496);
            this.lblUretimTarihi.Name = "lblUretimTarihi";
            this.lblUretimTarihi.Size = new System.Drawing.Size(116, 20);
            this.lblUretimTarihi.TabIndex = 12;
            this.lblUretimTarihi.Text = "Üretim Tarihi:";
            // 
            // lblSonKullanmaTarihi
            // 
            this.lblSonKullanmaTarihi.AutoSize = true;
            this.lblSonKullanmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonKullanmaTarihi.Location = new System.Drawing.Point(645, 149);
            this.lblSonKullanmaTarihi.Name = "lblSonKullanmaTarihi";
            this.lblSonKullanmaTarihi.Size = new System.Drawing.Size(173, 20);
            this.lblSonKullanmaTarihi.TabIndex = 14;
            this.lblSonKullanmaTarihi.Text = "Son Kullanma Tarihi:";
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.BorderThickness = 1;
            this.dtpSonKullanmaTarihi.Checked = true;
            this.dtpSonKullanmaTarihi.FillColor = System.Drawing.Color.White;
            this.dtpSonKullanmaTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSonKullanmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(649, 172);
            this.dtpSonKullanmaTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSonKullanmaTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(340, 36);
            this.dtpSonKullanmaTarihi.TabIndex = 13;
            this.dtpSonKullanmaTarihi.Value = new System.DateTime(2023, 1, 1, 12, 56, 12, 731);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BorderRadius = 19;
            this.btnTemizle.BorderThickness = 1;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTemizle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnTemizle.HoverState.FillColor = System.Drawing.Color.White;
            this.btnTemizle.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTemizle.Location = new System.Drawing.Point(843, 507);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 48);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BorderRadius = 19;
            this.btnEkle.BorderThickness = 1;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.HoverState.FillColor = System.Drawing.Color.White;
            this.btnEkle.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEkle.Location = new System.Drawing.Point(649, 507);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(146, 48);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(549, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 500);
            this.panel2.TabIndex = 17;
            // 
            // UC_P_StokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblSonKullanmaTarihi);
            this.Controls.Add(this.dtpSonKullanmaTarihi);
            this.Controls.Add(this.lblUretimTarihi);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.lblStokAdi);
            this.Controls.Add(this.txtStokID);
            this.Controls.Add(this.lblStokID);
            this.Controls.Add(this.lblStokEkle);
            this.Name = "UC_P_StokEkle";
            this.Size = new System.Drawing.Size(1104, 770);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStokEkle;
        private System.Windows.Forms.Label lblStokID;
        private Guna.UI2.WinForms.Guna2TextBox txtStokID;
        private Guna.UI2.WinForms.Guna2TextBox txtStokAdi;
        private System.Windows.Forms.Label lblStokAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblBarkodNo;
        private Guna.UI2.WinForms.Guna2TextBox txtMiktar;
        private System.Windows.Forms.Label lblMiktar;
        private Guna.UI2.WinForms.Guna2TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpUretimTarihi;
        private System.Windows.Forms.Label lblUretimTarihi;
        private System.Windows.Forms.Label lblSonKullanmaTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSonKullanmaTarihi;
        private Guna.UI2.WinForms.Guna2Button btnEkle;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
    }
}
