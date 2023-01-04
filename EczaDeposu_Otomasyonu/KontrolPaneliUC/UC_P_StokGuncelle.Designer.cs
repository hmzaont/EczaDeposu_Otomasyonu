namespace EczaDeposu_Otomasyonu.KontrolPaneliUC
{
    partial class UC_P_StokGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_StokGuncelle));
            this.lblStokGuncelle = new System.Windows.Forms.Label();
            this.lblStokID = new System.Windows.Forms.Label();
            this.txtStokID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStokIsmi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStokIsmi = new System.Windows.Forms.Label();
            this.txtBarkodNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBarkodNo = new System.Windows.Forms.Label();
            this.dtpUretimTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpSonKullanmaTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblUretimTarihi = new System.Windows.Forms.Label();
            this.lblSonKullanmaTarihi = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtMevcutMiktar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMevcutMiktar = new System.Windows.Forms.Label();
            this.txtMiktarEkle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMiktarEkle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnAra = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblStokGuncelle
            // 
            this.lblStokGuncelle.AutoSize = true;
            this.lblStokGuncelle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokGuncelle.Location = new System.Drawing.Point(59, 42);
            this.lblStokGuncelle.Name = "lblStokGuncelle";
            this.lblStokGuncelle.Size = new System.Drawing.Size(233, 38);
            this.lblStokGuncelle.TabIndex = 0;
            this.lblStokGuncelle.Text = "Stok Güncelle";
            // 
            // lblStokID
            // 
            this.lblStokID.AutoSize = true;
            this.lblStokID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokID.Location = new System.Drawing.Point(106, 141);
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
            this.txtStokID.ForeColor = System.Drawing.Color.Black;
            this.txtStokID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokID.Location = new System.Drawing.Point(109, 165);
            this.txtStokID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokID.Name = "txtStokID";
            this.txtStokID.PasswordChar = '\0';
            this.txtStokID.PlaceholderText = "";
            this.txtStokID.SelectedText = "";
            this.txtStokID.Size = new System.Drawing.Size(340, 36);
            this.txtStokID.TabIndex = 2;
            // 
            // txtStokIsmi
            // 
            this.txtStokIsmi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStokIsmi.DefaultText = "";
            this.txtStokIsmi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStokIsmi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStokIsmi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokIsmi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStokIsmi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokIsmi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStokIsmi.ForeColor = System.Drawing.Color.Black;
            this.txtStokIsmi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokIsmi.Location = new System.Drawing.Point(109, 304);
            this.txtStokIsmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokIsmi.Name = "txtStokIsmi";
            this.txtStokIsmi.PasswordChar = '\0';
            this.txtStokIsmi.PlaceholderText = "";
            this.txtStokIsmi.SelectedText = "";
            this.txtStokIsmi.Size = new System.Drawing.Size(340, 36);
            this.txtStokIsmi.TabIndex = 4;
            // 
            // lblStokIsmi
            // 
            this.lblStokIsmi.AutoSize = true;
            this.lblStokIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokIsmi.Location = new System.Drawing.Point(106, 280);
            this.lblStokIsmi.Name = "lblStokIsmi";
            this.lblStokIsmi.Size = new System.Drawing.Size(89, 20);
            this.lblStokIsmi.TabIndex = 3;
            this.lblStokIsmi.Text = "Stok İsmi:";
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
            this.txtBarkodNo.ForeColor = System.Drawing.Color.Black;
            this.txtBarkodNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarkodNo.Location = new System.Drawing.Point(109, 427);
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
            this.lblBarkodNo.Location = new System.Drawing.Point(106, 403);
            this.lblBarkodNo.Name = "lblBarkodNo";
            this.lblBarkodNo.Size = new System.Drawing.Size(98, 20);
            this.lblBarkodNo.TabIndex = 5;
            this.lblBarkodNo.Text = "Barkod No:";
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.BorderThickness = 1;
            this.dtpUretimTarihi.Checked = true;
            this.dtpUretimTarihi.FillColor = System.Drawing.Color.White;
            this.dtpUretimTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(110, 549);
            this.dtpUretimTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpUretimTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(340, 36);
            this.dtpUretimTarihi.TabIndex = 7;
            this.dtpUretimTarihi.Value = new System.DateTime(2023, 1, 1, 20, 2, 30, 151);
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.BorderThickness = 1;
            this.dtpSonKullanmaTarihi.Checked = true;
            this.dtpSonKullanmaTarihi.FillColor = System.Drawing.Color.White;
            this.dtpSonKullanmaTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSonKullanmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(668, 165);
            this.dtpSonKullanmaTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSonKullanmaTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(340, 36);
            this.dtpSonKullanmaTarihi.TabIndex = 8;
            this.dtpSonKullanmaTarihi.Value = new System.DateTime(2023, 1, 1, 20, 2, 30, 158);
            // 
            // lblUretimTarihi
            // 
            this.lblUretimTarihi.AutoSize = true;
            this.lblUretimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUretimTarihi.Location = new System.Drawing.Point(106, 527);
            this.lblUretimTarihi.Name = "lblUretimTarihi";
            this.lblUretimTarihi.Size = new System.Drawing.Size(116, 20);
            this.lblUretimTarihi.TabIndex = 9;
            this.lblUretimTarihi.Text = "Üretim Tarihi:";
            // 
            // lblSonKullanmaTarihi
            // 
            this.lblSonKullanmaTarihi.AutoSize = true;
            this.lblSonKullanmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonKullanmaTarihi.Location = new System.Drawing.Point(665, 142);
            this.lblSonKullanmaTarihi.Name = "lblSonKullanmaTarihi";
            this.lblSonKullanmaTarihi.Size = new System.Drawing.Size(173, 20);
            this.lblSonKullanmaTarihi.TabIndex = 10;
            this.lblSonKullanmaTarihi.Text = "Son Kullanma Tarihi:";
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
            this.txtBirimFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtBirimFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirimFiyat.Location = new System.Drawing.Point(668, 427);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.PlaceholderText = "";
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.Size = new System.Drawing.Size(340, 36);
            this.txtBirimFiyat.TabIndex = 14;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(665, 403);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(98, 20);
            this.lblBirimFiyat.TabIndex = 13;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // txtMevcutMiktar
            // 
            this.txtMevcutMiktar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMevcutMiktar.DefaultText = "";
            this.txtMevcutMiktar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMevcutMiktar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMevcutMiktar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMevcutMiktar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMevcutMiktar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMevcutMiktar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMevcutMiktar.ForeColor = System.Drawing.Color.Black;
            this.txtMevcutMiktar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMevcutMiktar.Location = new System.Drawing.Point(669, 304);
            this.txtMevcutMiktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMevcutMiktar.Name = "txtMevcutMiktar";
            this.txtMevcutMiktar.PasswordChar = '\0';
            this.txtMevcutMiktar.PlaceholderText = "";
            this.txtMevcutMiktar.SelectedText = "";
            this.txtMevcutMiktar.Size = new System.Drawing.Size(340, 36);
            this.txtMevcutMiktar.TabIndex = 12;
            // 
            // lblMevcutMiktar
            // 
            this.lblMevcutMiktar.AutoSize = true;
            this.lblMevcutMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMevcutMiktar.Location = new System.Drawing.Point(665, 280);
            this.lblMevcutMiktar.Name = "lblMevcutMiktar";
            this.lblMevcutMiktar.Size = new System.Drawing.Size(125, 20);
            this.lblMevcutMiktar.TabIndex = 11;
            this.lblMevcutMiktar.Text = "Mevcut Miktar:";
            // 
            // txtMiktarEkle
            // 
            this.txtMiktarEkle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMiktarEkle.BorderThickness = 2;
            this.txtMiktarEkle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiktarEkle.DefaultText = "0";
            this.txtMiktarEkle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiktarEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiktarEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktarEkle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiktarEkle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktarEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiktarEkle.ForeColor = System.Drawing.Color.Black;
            this.txtMiktarEkle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiktarEkle.Location = new System.Drawing.Point(883, 349);
            this.txtMiktarEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMiktarEkle.Name = "txtMiktarEkle";
            this.txtMiktarEkle.PasswordChar = '\0';
            this.txtMiktarEkle.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtMiktarEkle.PlaceholderText = "";
            this.txtMiktarEkle.SelectedText = "";
            this.txtMiktarEkle.Size = new System.Drawing.Size(125, 36);
            this.txtMiktarEkle.TabIndex = 16;
            this.txtMiktarEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMiktarEkle
            // 
            this.lblMiktarEkle.AutoSize = true;
            this.lblMiktarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiktarEkle.Location = new System.Drawing.Point(773, 355);
            this.lblMiktarEkle.Name = "lblMiktarEkle";
            this.lblMiktarEkle.Size = new System.Drawing.Size(103, 20);
            this.lblMiktarEkle.TabIndex = 15;
            this.lblMiktarEkle.Text = "Miktar Ekle:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BorderRadius = 18;
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
            this.btnTemizle.Location = new System.Drawing.Point(863, 537);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 48);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BorderRadius = 18;
            this.btnGuncelle.BorderThickness = 1;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuncelle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnGuncelle.HoverState.FillColor = System.Drawing.Color.White;
            this.btnGuncelle.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuncelle.Location = new System.Drawing.Point(669, 537);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(146, 48);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BorderRadius = 18;
            this.btnAra.BorderThickness = 1;
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAra.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnAra.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAra.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAra.Location = new System.Drawing.Point(339, 208);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(110, 34);
            this.btnAra.TabIndex = 17;
            this.btnAra.Text = "ARA";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(547, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 500);
            this.panel2.TabIndex = 20;
            // 
            // UC_P_StokGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtMiktarEkle);
            this.Controls.Add(this.lblMiktarEkle);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.txtMevcutMiktar);
            this.Controls.Add(this.lblMevcutMiktar);
            this.Controls.Add(this.lblSonKullanmaTarihi);
            this.Controls.Add(this.lblUretimTarihi);
            this.Controls.Add(this.dtpSonKullanmaTarihi);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.lblBarkodNo);
            this.Controls.Add(this.txtStokIsmi);
            this.Controls.Add(this.lblStokIsmi);
            this.Controls.Add(this.txtStokID);
            this.Controls.Add(this.lblStokID);
            this.Controls.Add(this.lblStokGuncelle);
            this.Name = "UC_P_StokGuncelle";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_P_StoguGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStokGuncelle;
        private System.Windows.Forms.Label lblStokID;
        private Guna.UI2.WinForms.Guna2TextBox txtStokID;
        private Guna.UI2.WinForms.Guna2TextBox txtStokIsmi;
        private System.Windows.Forms.Label lblStokIsmi;
        private Guna.UI2.WinForms.Guna2TextBox txtBarkodNo;
        private System.Windows.Forms.Label lblBarkodNo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpUretimTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSonKullanmaTarihi;
        private System.Windows.Forms.Label lblUretimTarihi;
        private System.Windows.Forms.Label lblSonKullanmaTarihi;
        private Guna.UI2.WinForms.Guna2TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtMevcutMiktar;
        private System.Windows.Forms.Label lblMevcutMiktar;
        private Guna.UI2.WinForms.Guna2TextBox txtMiktarEkle;
        private System.Windows.Forms.Label lblMiktarEkle;
        private Guna.UI2.WinForms.Guna2Button btnAra;
        private Guna.UI2.WinForms.Guna2Button btnGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
    }
}
