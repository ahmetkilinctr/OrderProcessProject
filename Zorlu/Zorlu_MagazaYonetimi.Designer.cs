namespace ZorluKartela
{
    partial class Zorlu_MagazaYonetimi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zorlu_MagazaYonetimi));
            this.btnMagazaEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dgvMagazalar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.lblMagazaAdi = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblMagazaMuduru = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblVergiDairesi = new System.Windows.Forms.Label();
            this.lblVergiNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMagazaKodu = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.txtMagazaMuduru = new System.Windows.Forms.TextBox();
            this.cbxSehir = new System.Windows.Forms.ComboBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.txtMagazaKodu = new System.Windows.Forms.TextBox();
            this.lblEPosta = new System.Windows.Forms.Label();
            this.txtEPosta = new System.Windows.Forms.TextBox();
            this.txtRollware = new System.Windows.Forms.TextBox();
            this.lblRollware = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtfMagazaAdi = new System.Windows.Forms.TextBox();
            this.txtfKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtfMagazaKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazalar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMagazaEkle
            // 
            this.btnMagazaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMagazaEkle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagazaEkle.Location = new System.Drawing.Point(25, 707);
            this.btnMagazaEkle.Name = "btnMagazaEkle";
            this.btnMagazaEkle.Size = new System.Drawing.Size(98, 23);
            this.btnMagazaEkle.TabIndex = 13;
            this.btnMagazaEkle.Text = "Mağaza Ekle";
            this.btnMagazaEkle.UseVisualStyleBackColor = true;
            this.btnMagazaEkle.Click += new System.EventHandler(this.btnMagazaEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(659, 707);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 20;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(740, 707);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dgvMagazalar
            // 
            this.dgvMagazalar.AllowUserToAddRows = false;
            this.dgvMagazalar.AllowUserToDeleteRows = false;
            this.dgvMagazalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMagazalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazalar.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvMagazalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMagazalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMagazalar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMagazalar.Location = new System.Drawing.Point(286, 124);
            this.dgvMagazalar.Name = "dgvMagazalar";
            this.dgvMagazalar.ReadOnly = true;
            this.dgvMagazalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagazalar.Size = new System.Drawing.Size(529, 567);
            this.dgvMagazalar.TabIndex = 22;
            this.dgvMagazalar.TabStop = false;
            this.dgvMagazalar.Click += new System.EventHandler(this.dgvMagazalar_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(129, 707);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKayitSil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayitSil.Location = new System.Drawing.Point(210, 707);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(75, 23);
            this.btnKayitSil.TabIndex = 15;
            this.btnKayitSil.Text = "Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // lblMagazaAdi
            // 
            this.lblMagazaAdi.AutoSize = true;
            this.lblMagazaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazaAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblMagazaAdi.Location = new System.Drawing.Point(24, 91);
            this.lblMagazaAdi.Name = "lblMagazaAdi";
            this.lblMagazaAdi.Size = new System.Drawing.Size(72, 13);
            this.lblMagazaAdi.TabIndex = 33;
            this.lblMagazaAdi.Text = "Mağaza Adı:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(24, 127);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(75, 13);
            this.lblKullaniciAdi.TabIndex = 34;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdres.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdres.Location = new System.Drawing.Point(24, 239);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(40, 13);
            this.lblAdres.TabIndex = 35;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSehir.ForeColor = System.Drawing.Color.Maroon;
            this.lblSehir.Location = new System.Drawing.Point(26, 337);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(36, 13);
            this.lblSehir.TabIndex = 36;
            this.lblSehir.Text = "Şehir:";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmaAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblFirmaAdi.Location = new System.Drawing.Point(26, 380);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(60, 13);
            this.lblFirmaAdi.TabIndex = 37;
            this.lblFirmaAdi.Text = "Firma Adı:";
            // 
            // lblMagazaMuduru
            // 
            this.lblMagazaMuduru.AutoSize = true;
            this.lblMagazaMuduru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazaMuduru.ForeColor = System.Drawing.Color.Maroon;
            this.lblMagazaMuduru.Location = new System.Drawing.Point(26, 415);
            this.lblMagazaMuduru.Name = "lblMagazaMuduru";
            this.lblMagazaMuduru.Size = new System.Drawing.Size(97, 13);
            this.lblMagazaMuduru.TabIndex = 38;
            this.lblMagazaMuduru.Text = "Mağaza Müdürü:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifre.ForeColor = System.Drawing.Color.Maroon;
            this.lblSifre.Location = new System.Drawing.Point(24, 163);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(33, 13);
            this.lblSifre.TabIndex = 39;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.AutoSize = true;
            this.lblVergiDairesi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVergiDairesi.ForeColor = System.Drawing.Color.Maroon;
            this.lblVergiDairesi.Location = new System.Drawing.Point(26, 453);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Size = new System.Drawing.Size(75, 13);
            this.lblVergiDairesi.TabIndex = 40;
            this.lblVergiDairesi.Text = "Vergi Dairesi:";
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.AutoSize = true;
            this.lblVergiNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVergiNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblVergiNo.Location = new System.Drawing.Point(24, 494);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Size = new System.Drawing.Size(56, 13);
            this.lblVergiNo.TabIndex = 41;
            this.lblVergiNo.Text = "Vergi No:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.ForeColor = System.Drawing.Color.Maroon;
            this.lblTelefon.Location = new System.Drawing.Point(24, 531);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 42;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblMagazaKodu
            // 
            this.lblMagazaKodu.AutoSize = true;
            this.lblMagazaKodu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazaKodu.ForeColor = System.Drawing.Color.Maroon;
            this.lblMagazaKodu.Location = new System.Drawing.Point(24, 568);
            this.lblMagazaKodu.Name = "lblMagazaKodu";
            this.lblMagazaKodu.Size = new System.Drawing.Size(82, 13);
            this.lblMagazaKodu.TabIndex = 43;
            this.lblMagazaKodu.Text = "Mağaza Kodu:";
            // 
            // txtShopName
            // 
            this.txtShopName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.Location = new System.Drawing.Point(124, 89);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(137, 22);
            this.txtShopName.TabIndex = 0;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(124, 124);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(137, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(124, 160);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(137, 22);
            this.txtSifre.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(124, 239);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(137, 73);
            this.txtAdres.TabIndex = 4;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirmaAdi.Location = new System.Drawing.Point(124, 377);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(137, 22);
            this.txtFirmaAdi.TabIndex = 6;
            // 
            // txtMagazaMuduru
            // 
            this.txtMagazaMuduru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMagazaMuduru.Location = new System.Drawing.Point(124, 412);
            this.txtMagazaMuduru.Name = "txtMagazaMuduru";
            this.txtMagazaMuduru.Size = new System.Drawing.Size(137, 22);
            this.txtMagazaMuduru.TabIndex = 7;
            // 
            // cbxSehir
            // 
            this.cbxSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSehir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSehir.FormattingEnabled = true;
            this.cbxSehir.Location = new System.Drawing.Point(124, 334);
            this.cbxSehir.Name = "cbxSehir";
            this.cbxSehir.Size = new System.Drawing.Size(137, 21);
            this.cbxSehir.TabIndex = 5;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVergiDairesi.Location = new System.Drawing.Point(124, 450);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(137, 22);
            this.txtVergiDairesi.TabIndex = 8;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVergiNo.Location = new System.Drawing.Point(124, 491);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(137, 22);
            this.txtVergiNo.TabIndex = 9;
            // 
            // txtMagazaKodu
            // 
            this.txtMagazaKodu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMagazaKodu.Location = new System.Drawing.Point(124, 565);
            this.txtMagazaKodu.Name = "txtMagazaKodu";
            this.txtMagazaKodu.Size = new System.Drawing.Size(137, 22);
            this.txtMagazaKodu.TabIndex = 11;
            // 
            // lblEPosta
            // 
            this.lblEPosta.AutoSize = true;
            this.lblEPosta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEPosta.ForeColor = System.Drawing.Color.Maroon;
            this.lblEPosta.Location = new System.Drawing.Point(25, 200);
            this.lblEPosta.Name = "lblEPosta";
            this.lblEPosta.Size = new System.Drawing.Size(85, 13);
            this.lblEPosta.TabIndex = 55;
            this.lblEPosta.Text = "E-Posta Adresi:";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPosta.Location = new System.Drawing.Point(124, 197);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(137, 22);
            this.txtEPosta.TabIndex = 3;
            // 
            // txtRollware
            // 
            this.txtRollware.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollware.Location = new System.Drawing.Point(124, 603);
            this.txtRollware.Name = "txtRollware";
            this.txtRollware.Size = new System.Drawing.Size(137, 22);
            this.txtRollware.TabIndex = 12;
            // 
            // lblRollware
            // 
            this.lblRollware.AutoSize = true;
            this.lblRollware.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollware.ForeColor = System.Drawing.Color.Maroon;
            this.lblRollware.Location = new System.Drawing.Point(24, 603);
            this.lblRollware.Name = "lblRollware";
            this.lblRollware.Size = new System.Drawing.Size(86, 13);
            this.lblRollware.TabIndex = 57;
            this.lblRollware.Text = "Rollware Kodu:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(284, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "Mağaza Listesi";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSorgula.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorgula.Location = new System.Drawing.Point(740, 67);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 19;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtfMagazaAdi
            // 
            this.txtfMagazaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfMagazaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfMagazaAdi.Location = new System.Drawing.Point(287, 68);
            this.txtfMagazaAdi.Name = "txtfMagazaAdi";
            this.txtfMagazaAdi.Size = new System.Drawing.Size(137, 22);
            this.txtfMagazaAdi.TabIndex = 16;
            // 
            // txtfKullaniciAdi
            // 
            this.txtfKullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfKullaniciAdi.Location = new System.Drawing.Point(440, 68);
            this.txtfKullaniciAdi.Name = "txtfKullaniciAdi";
            this.txtfKullaniciAdi.Size = new System.Drawing.Size(137, 22);
            this.txtfKullaniciAdi.TabIndex = 17;
            // 
            // txtfMagazaKodu
            // 
            this.txtfMagazaKodu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfMagazaKodu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfMagazaKodu.Location = new System.Drawing.Point(594, 68);
            this.txtfMagazaKodu.Name = "txtfMagazaKodu";
            this.txtfMagazaKodu.Size = new System.Drawing.Size(137, 22);
            this.txtfMagazaKodu.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(284, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mağaza Adı:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(437, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(591, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mağaza Kodu:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Image = global::ZorluKartela.Properties.Resources.zorluteks_logo;
            this.label5.Location = new System.Drawing.Point(714, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(25, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 69;
            this.label6.Text = "Hoşgeldiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(123, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "-";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(124, 528);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(137, 22);
            this.txtTelefon.TabIndex = 10;
            // 
            // Zorlu_MagazaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(827, 742);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfMagazaKodu);
            this.Controls.Add(this.txtfKullaniciAdi);
            this.Controls.Add(this.txtfMagazaAdi);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRollware);
            this.Controls.Add(this.lblRollware);
            this.Controls.Add(this.txtEPosta);
            this.Controls.Add(this.lblEPosta);
            this.Controls.Add(this.txtMagazaKodu);
            this.Controls.Add(this.txtVergiNo);
            this.Controls.Add(this.txtVergiDairesi);
            this.Controls.Add(this.cbxSehir);
            this.Controls.Add(this.txtMagazaMuduru);
            this.Controls.Add(this.txtFirmaAdi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.lblMagazaKodu);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblVergiNo);
            this.Controls.Add(this.lblVergiDairesi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblMagazaMuduru);
            this.Controls.Add(this.lblFirmaAdi);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblMagazaAdi);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvMagazalar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnMagazaEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zorlu_MagazaYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAĞAZA YÖNETİMİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Zorlu_MagazaYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMagazaEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dgvMagazalar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Label lblMagazaAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblMagazaMuduru;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblVergiDairesi;
        private System.Windows.Forms.Label lblVergiNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMagazaKodu;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.TextBox txtMagazaMuduru;
        private System.Windows.Forms.ComboBox cbxSehir;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtMagazaKodu;
        private System.Windows.Forms.Label lblEPosta;
        private System.Windows.Forms.TextBox txtEPosta;
        private System.Windows.Forms.TextBox txtRollware;
        private System.Windows.Forms.Label lblRollware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtfMagazaAdi;
        private System.Windows.Forms.TextBox txtfKullaniciAdi;
        private System.Windows.Forms.TextBox txtfMagazaKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}