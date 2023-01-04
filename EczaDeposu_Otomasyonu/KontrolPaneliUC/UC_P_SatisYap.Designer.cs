namespace EczaDeposu_Otomasyonu.KontrolPaneliUC
{
    partial class UC_P_SatisYap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_P_SatisYap));
            this.lblSatisYap = new System.Windows.Forms.Label();
            this.lblAra = new System.Windows.Forms.Label();
            this.txtAra = new Guna.UI2.WinForms.Guna2TextBox();
            this.listBoxStokVerileri = new System.Windows.Forms.ListBox();
            this.txtStokID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStokID = new System.Windows.Forms.Label();
            this.txtStokAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStokAdi = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.txtBirimSayisi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBirimSayisi = new System.Windows.Forms.Label();
            this.lblSonKullanmaTarihi = new System.Windows.Forms.Label();
            this.dtpSonKullanmaTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtHesaplananFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHesaplananFiyat = new System.Windows.Forms.Label();
            this.TabloStok = new Guna.UI2.WinForms.Guna2DataGridView();
            this.StokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonKullanmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimSayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamFiyat = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnOdemeYapYazdir = new Guna.UI2.WinForms.Guna2Button();
            this.btnSil = new Guna.UI2.WinForms.Guna2Button();
            this.btnSepeteEkle = new Guna.UI2.WinForms.Guna2Button();
            this.btnYenile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TabloStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYenile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSatisYap
            // 
            this.lblSatisYap.AutoSize = true;
            this.lblSatisYap.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatisYap.Location = new System.Drawing.Point(58, 48);
            this.lblSatisYap.Name = "lblSatisYap";
            this.lblSatisYap.Size = new System.Drawing.Size(158, 38);
            this.lblSatisYap.TabIndex = 1;
            this.lblSatisYap.Text = "Satış Yap";
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAra.Location = new System.Drawing.Point(121, 108);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(42, 20);
            this.lblAra.TabIndex = 5;
            this.lblAra.Text = "Ara:";
            // 
            // txtAra
            // 
            this.txtAra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAra.DefaultText = "";
            this.txtAra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAra.ForeColor = System.Drawing.Color.Black;
            this.txtAra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAra.Location = new System.Drawing.Point(51, 132);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.PlaceholderText = "";
            this.txtAra.SelectedText = "";
            this.txtAra.Size = new System.Drawing.Size(210, 36);
            this.txtAra.TabIndex = 7;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // listBoxStokVerileri
            // 
            this.listBoxStokVerileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStokVerileri.FormattingEnabled = true;
            this.listBoxStokVerileri.ItemHeight = 24;
            this.listBoxStokVerileri.Location = new System.Drawing.Point(51, 194);
            this.listBoxStokVerileri.Name = "listBoxStokVerileri";
            this.listBoxStokVerileri.Size = new System.Drawing.Size(211, 484);
            this.listBoxStokVerileri.TabIndex = 8;
            this.listBoxStokVerileri.SelectedIndexChanged += new System.EventHandler(this.listBoxStokVerileri_SelectedIndexChanged);
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
            this.txtStokID.Location = new System.Drawing.Point(351, 132);
            this.txtStokID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokID.Name = "txtStokID";
            this.txtStokID.PasswordChar = '\0';
            this.txtStokID.PlaceholderText = "";
            this.txtStokID.ReadOnly = true;
            this.txtStokID.SelectedText = "";
            this.txtStokID.Size = new System.Drawing.Size(340, 36);
            this.txtStokID.TabIndex = 10;
            // 
            // lblStokID
            // 
            this.lblStokID.AutoSize = true;
            this.lblStokID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokID.Location = new System.Drawing.Point(347, 108);
            this.lblStokID.Name = "lblStokID";
            this.lblStokID.Size = new System.Drawing.Size(75, 20);
            this.lblStokID.TabIndex = 9;
            this.lblStokID.Text = "Stok ID:";
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
            this.txtStokAdi.ForeColor = System.Drawing.Color.Black;
            this.txtStokAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStokAdi.Location = new System.Drawing.Point(351, 210);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.PasswordChar = '\0';
            this.txtStokAdi.PlaceholderText = "";
            this.txtStokAdi.ReadOnly = true;
            this.txtStokAdi.SelectedText = "";
            this.txtStokAdi.Size = new System.Drawing.Size(340, 36);
            this.txtStokAdi.TabIndex = 12;
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.AutoSize = true;
            this.lblStokAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokAdi.Location = new System.Drawing.Point(347, 186);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(82, 20);
            this.lblStokAdi.TabIndex = 11;
            this.lblStokAdi.Text = "Stok Adı:";
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
            this.txtBirimFiyat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBirimFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtBirimFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirimFiyat.Location = new System.Drawing.Point(727, 132);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.PlaceholderText = "";
            this.txtBirimFiyat.ReadOnly = true;
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.Size = new System.Drawing.Size(340, 36);
            this.txtBirimFiyat.TabIndex = 14;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(723, 108);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(129, 20);
            this.lblBirimFiyat.TabIndex = 13;
            this.lblBirimFiyat.Text = "Birim Fiyatı (₺):";
            // 
            // txtBirimSayisi
            // 
            this.txtBirimSayisi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBirimSayisi.DefaultText = "";
            this.txtBirimSayisi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBirimSayisi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBirimSayisi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirimSayisi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBirimSayisi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirimSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirimSayisi.ForeColor = System.Drawing.Color.Black;
            this.txtBirimSayisi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBirimSayisi.Location = new System.Drawing.Point(727, 210);
            this.txtBirimSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirimSayisi.Name = "txtBirimSayisi";
            this.txtBirimSayisi.PasswordChar = '\0';
            this.txtBirimSayisi.PlaceholderText = "";
            this.txtBirimSayisi.SelectedText = "";
            this.txtBirimSayisi.Size = new System.Drawing.Size(340, 36);
            this.txtBirimSayisi.TabIndex = 16;
            this.txtBirimSayisi.TextChanged += new System.EventHandler(this.txtBirimSayisi_TextChanged);
            // 
            // lblBirimSayisi
            // 
            this.lblBirimSayisi.AutoSize = true;
            this.lblBirimSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirimSayisi.Location = new System.Drawing.Point(723, 186);
            this.lblBirimSayisi.Name = "lblBirimSayisi";
            this.lblBirimSayisi.Size = new System.Drawing.Size(179, 20);
            this.lblBirimSayisi.TabIndex = 15;
            this.lblBirimSayisi.Text = "Alınacak Birim Sayısı:";
            // 
            // lblSonKullanmaTarihi
            // 
            this.lblSonKullanmaTarihi.AutoSize = true;
            this.lblSonKullanmaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonKullanmaTarihi.Location = new System.Drawing.Point(347, 271);
            this.lblSonKullanmaTarihi.Name = "lblSonKullanmaTarihi";
            this.lblSonKullanmaTarihi.Size = new System.Drawing.Size(173, 20);
            this.lblSonKullanmaTarihi.TabIndex = 17;
            this.lblSonKullanmaTarihi.Text = "Son Kullanma Tarihi:";
            // 
            // dtpSonKullanmaTarihi
            // 
            this.dtpSonKullanmaTarihi.Checked = true;
            this.dtpSonKullanmaTarihi.FillColor = System.Drawing.Color.White;
            this.dtpSonKullanmaTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSonKullanmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonKullanmaTarihi.Location = new System.Drawing.Point(351, 294);
            this.dtpSonKullanmaTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSonKullanmaTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSonKullanmaTarihi.Name = "dtpSonKullanmaTarihi";
            this.dtpSonKullanmaTarihi.Size = new System.Drawing.Size(340, 36);
            this.dtpSonKullanmaTarihi.TabIndex = 18;
            this.dtpSonKullanmaTarihi.Value = new System.DateTime(2023, 1, 1, 23, 49, 52, 828);
            // 
            // txtHesaplananFiyat
            // 
            this.txtHesaplananFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHesaplananFiyat.DefaultText = "";
            this.txtHesaplananFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHesaplananFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHesaplananFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHesaplananFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHesaplananFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHesaplananFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHesaplananFiyat.ForeColor = System.Drawing.Color.Black;
            this.txtHesaplananFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHesaplananFiyat.Location = new System.Drawing.Point(727, 294);
            this.txtHesaplananFiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHesaplananFiyat.Name = "txtHesaplananFiyat";
            this.txtHesaplananFiyat.PasswordChar = '\0';
            this.txtHesaplananFiyat.PlaceholderText = "";
            this.txtHesaplananFiyat.ReadOnly = true;
            this.txtHesaplananFiyat.SelectedText = "";
            this.txtHesaplananFiyat.Size = new System.Drawing.Size(340, 36);
            this.txtHesaplananFiyat.TabIndex = 20;
            this.txtHesaplananFiyat.TextChanged += new System.EventHandler(this.txtToplamFiyat_TextChanged);
            // 
            // lblHesaplananFiyat
            // 
            this.lblHesaplananFiyat.AutoSize = true;
            this.lblHesaplananFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHesaplananFiyat.Location = new System.Drawing.Point(723, 270);
            this.lblHesaplananFiyat.Name = "lblHesaplananFiyat";
            this.lblHesaplananFiyat.Size = new System.Drawing.Size(181, 20);
            this.lblHesaplananFiyat.TabIndex = 19;
            this.lblHesaplananFiyat.Text = "Hesaplanan Fiyat (₺):";
            // 
            // TabloStok
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.TabloStok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabloStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabloStok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabloStok.ColumnHeadersHeight = 21;
            this.TabloStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TabloStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokID,
            this.StokAdi,
            this.SonKullanmaTarihi,
            this.BirimFiyat,
            this.topFiyat,
            this.BirimSayisi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabloStok.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabloStok.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.TabloStok.Location = new System.Drawing.Point(351, 416);
            this.TabloStok.Name = "TabloStok";
            this.TabloStok.RowHeadersVisible = false;
            this.TabloStok.RowHeadersWidth = 82;
            this.TabloStok.Size = new System.Drawing.Size(716, 237);
            this.TabloStok.TabIndex = 22;
            this.TabloStok.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.TabloStok.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.TabloStok.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TabloStok.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TabloStok.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TabloStok.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TabloStok.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TabloStok.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.TabloStok.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.TabloStok.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TabloStok.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabloStok.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TabloStok.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TabloStok.ThemeStyle.HeaderStyle.Height = 21;
            this.TabloStok.ThemeStyle.ReadOnly = false;
            this.TabloStok.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.TabloStok.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TabloStok.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabloStok.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.TabloStok.ThemeStyle.RowsStyle.Height = 22;
            this.TabloStok.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.TabloStok.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.TabloStok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabloStok_CellContentClick);
            // 
            // StokID
            // 
            this.StokID.HeaderText = "Stok ID";
            this.StokID.MinimumWidth = 10;
            this.StokID.Name = "StokID";
            // 
            // StokAdi
            // 
            this.StokAdi.HeaderText = "Stok Adi";
            this.StokAdi.MinimumWidth = 10;
            this.StokAdi.Name = "StokAdi";
            // 
            // SonKullanmaTarihi
            // 
            this.SonKullanmaTarihi.HeaderText = "Son Kullanma Tarihi";
            this.SonKullanmaTarihi.MinimumWidth = 10;
            this.SonKullanmaTarihi.Name = "SonKullanmaTarihi";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.MinimumWidth = 10;
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // topFiyat
            // 
            this.topFiyat.HeaderText = "Toplam Fiyat";
            this.topFiyat.MinimumWidth = 10;
            this.topFiyat.Name = "topFiyat";
            // 
            // BirimSayisi
            // 
            this.BirimSayisi.HeaderText = "Birim Sayisi";
            this.BirimSayisi.MinimumWidth = 10;
            this.BirimSayisi.Name = "BirimSayisi";
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.BackColor = System.Drawing.Color.Gold;
            this.ToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToplamFiyat.Location = new System.Drawing.Point(601, 660);
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.Size = new System.Drawing.Size(111, 48);
            this.ToplamFiyat.TabIndex = 25;
            this.ToplamFiyat.Text = "0 ₺";
            this.ToplamFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnOdemeYapYazdir
            // 
            this.btnOdemeYapYazdir.BorderRadius = 19;
            this.btnOdemeYapYazdir.BorderThickness = 1;
            this.btnOdemeYapYazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeYapYazdir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOdemeYapYazdir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOdemeYapYazdir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOdemeYapYazdir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOdemeYapYazdir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOdemeYapYazdir.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdemeYapYazdir.ForeColor = System.Drawing.Color.White;
            this.btnOdemeYapYazdir.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnOdemeYapYazdir.HoverState.FillColor = System.Drawing.Color.White;
            this.btnOdemeYapYazdir.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOdemeYapYazdir.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeYapYazdir.Image")));
            this.btnOdemeYapYazdir.ImageSize = new System.Drawing.Size(30, 30);
            this.btnOdemeYapYazdir.Location = new System.Drawing.Point(791, 660);
            this.btnOdemeYapYazdir.Name = "btnOdemeYapYazdir";
            this.btnOdemeYapYazdir.Size = new System.Drawing.Size(276, 45);
            this.btnOdemeYapYazdir.TabIndex = 24;
            this.btnOdemeYapYazdir.Text = "ÖDEME YAP ve YAZDIR";
            this.btnOdemeYapYazdir.Click += new System.EventHandler(this.btnOdemeYapYazdir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BorderRadius = 19;
            this.btnSil.BorderThickness = 1;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSil.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSil.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSil.Location = new System.Drawing.Point(351, 660);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 45);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BorderRadius = 19;
            this.btnSepeteEkle.BorderThickness = 1;
            this.btnSepeteEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSepeteEkle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSepeteEkle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSepeteEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSepeteEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSepeteEkle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSepeteEkle.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepeteEkle.ForeColor = System.Drawing.Color.White;
            this.btnSepeteEkle.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSepeteEkle.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSepeteEkle.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSepeteEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnSepeteEkle.Image")));
            this.btnSepeteEkle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSepeteEkle.Location = new System.Drawing.Point(887, 347);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(180, 45);
            this.btnSepeteEkle.TabIndex = 21;
            this.btnSepeteEkle.Text = "SEPETE EKLE";
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(244, 48);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(32, 33);
            this.btnYenile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYenile.TabIndex = 4;
            this.btnYenile.TabStop = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Location = new System.Drawing.Point(303, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 500);
            this.panel2.TabIndex = 26;
            // 
            // UC_P_SatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ToplamFiyat);
            this.Controls.Add(this.btnOdemeYapYazdir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.TabloStok);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtHesaplananFiyat);
            this.Controls.Add(this.lblHesaplananFiyat);
            this.Controls.Add(this.dtpSonKullanmaTarihi);
            this.Controls.Add(this.lblSonKullanmaTarihi);
            this.Controls.Add(this.txtBirimSayisi);
            this.Controls.Add(this.lblBirimSayisi);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblBirimFiyat);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.lblStokAdi);
            this.Controls.Add(this.txtStokID);
            this.Controls.Add(this.lblStokID);
            this.Controls.Add(this.listBoxStokVerileri);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSatisYap);
            this.Name = "UC_P_SatisYap";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_P_SatisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabloStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYenile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSatisYap;
        private System.Windows.Forms.PictureBox btnYenile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAra;
        private Guna.UI2.WinForms.Guna2TextBox txtAra;
        private System.Windows.Forms.ListBox listBoxStokVerileri;
        private Guna.UI2.WinForms.Guna2TextBox txtStokID;
        private System.Windows.Forms.Label lblStokID;
        private Guna.UI2.WinForms.Guna2TextBox txtStokAdi;
        private System.Windows.Forms.Label lblStokAdi;
        private Guna.UI2.WinForms.Guna2TextBox txtBirimFiyat;
        private System.Windows.Forms.Label lblBirimFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtBirimSayisi;
        private System.Windows.Forms.Label lblBirimSayisi;
        private System.Windows.Forms.Label lblSonKullanmaTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSonKullanmaTarihi;
        private Guna.UI2.WinForms.Guna2TextBox txtHesaplananFiyat;
        private System.Windows.Forms.Label lblHesaplananFiyat;
        private Guna.UI2.WinForms.Guna2Button btnSepeteEkle;
        private Guna.UI2.WinForms.Guna2DataGridView TabloStok;
        private Guna.UI2.WinForms.Guna2Button btnSil;
        private Guna.UI2.WinForms.Guna2Button btnOdemeYapYazdir;
        private System.Windows.Forms.Label ToplamFiyat;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonKullanmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn topFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimSayisi;
        private System.Windows.Forms.Panel panel2;
    }
}
