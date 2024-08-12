namespace ZorluKartela
{
    partial class SiparisListesi_ForZorlu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisListesi_ForZorlu));
            this.btnSevkiyatBilgisi = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dgvSiparisListesi = new System.Windows.Forms.DataGridView();
            this.lblSiparisListesi = new System.Windows.Forms.Label();
            this.txtMagazaAdi = new System.Windows.Forms.TextBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.lblMagazaAdi = new System.Windows.Forms.Label();
            this.lblKartelaAdi = new System.Windows.Forms.Label();
            this.txtKartelaAdi = new System.Windows.Forms.TextBox();
            this.lblTedarikciAdi = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSevkiyatBilgisi
            // 
            this.btnSevkiyatBilgisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSevkiyatBilgisi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSevkiyatBilgisi.Location = new System.Drawing.Point(10, 495);
            this.btnSevkiyatBilgisi.Name = "btnSevkiyatBilgisi";
            this.btnSevkiyatBilgisi.Size = new System.Drawing.Size(115, 26);
            this.btnSevkiyatBilgisi.TabIndex = 5;
            this.btnSevkiyatBilgisi.Text = "Sevkiyat Bilgisi";
            this.btnSevkiyatBilgisi.UseVisualStyleBackColor = true;
            this.btnSevkiyatBilgisi.Click += new System.EventHandler(this.btnSevkiyatBilgisi_Click);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiparisSil.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisSil.Location = new System.Drawing.Point(127, 495);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(110, 26);
            this.btnSiparisSil.TabIndex = 6;
            this.btnSiparisSil.Text = "Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = true;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(858, 495);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 23);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dgvSiparisListesi
            // 
            this.dgvSiparisListesi.AllowUserToAddRows = false;
            this.dgvSiparisListesi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvSiparisListesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSiparisListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisListesi.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvSiparisListesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSiparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSiparisListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSiparisListesi.Location = new System.Drawing.Point(10, 134);
            this.dgvSiparisListesi.Name = "dgvSiparisListesi";
            this.dgvSiparisListesi.ReadOnly = true;
            this.dgvSiparisListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisListesi.Size = new System.Drawing.Size(938, 344);
            this.dgvSiparisListesi.TabIndex = 8;
            this.dgvSiparisListesi.TabStop = false;
            // 
            // lblSiparisListesi
            // 
            this.lblSiparisListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSiparisListesi.BackColor = System.Drawing.SystemColors.Control;
            this.lblSiparisListesi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiparisListesi.ForeColor = System.Drawing.Color.Maroon;
            this.lblSiparisListesi.Location = new System.Drawing.Point(10, 102);
            this.lblSiparisListesi.Name = "lblSiparisListesi";
            this.lblSiparisListesi.Size = new System.Drawing.Size(938, 29);
            this.lblSiparisListesi.TabIndex = 4;
            this.lblSiparisListesi.Text = "Sipariş Listesi";
            this.lblSiparisListesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMagazaAdi
            // 
            this.txtMagazaAdi.Location = new System.Drawing.Point(13, 65);
            this.txtMagazaAdi.Name = "txtMagazaAdi";
            this.txtMagazaAdi.Size = new System.Drawing.Size(185, 22);
            this.txtMagazaAdi.TabIndex = 0;
            // 
            // btnFiltre
            // 
            this.btnFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltre.Location = new System.Drawing.Point(873, 62);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltre.TabIndex = 4;
            this.btnFiltre.Text = "Sorgula";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // lblMagazaAdi
            // 
            this.lblMagazaAdi.AutoSize = true;
            this.lblMagazaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMagazaAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblMagazaAdi.Location = new System.Drawing.Point(10, 49);
            this.lblMagazaAdi.Name = "lblMagazaAdi";
            this.lblMagazaAdi.Size = new System.Drawing.Size(69, 13);
            this.lblMagazaAdi.TabIndex = 7;
            this.lblMagazaAdi.Text = "Mağaza Adı";
            // 
            // lblKartelaAdi
            // 
            this.lblKartelaAdi.AutoSize = true;
            this.lblKartelaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKartelaAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblKartelaAdi.Location = new System.Drawing.Point(216, 49);
            this.lblKartelaAdi.Name = "lblKartelaAdi";
            this.lblKartelaAdi.Size = new System.Drawing.Size(64, 13);
            this.lblKartelaAdi.TabIndex = 9;
            this.lblKartelaAdi.Text = "Kartela Adı";
            // 
            // txtKartelaAdi
            // 
            this.txtKartelaAdi.Location = new System.Drawing.Point(219, 65);
            this.txtKartelaAdi.Name = "txtKartelaAdi";
            this.txtKartelaAdi.Size = new System.Drawing.Size(195, 22);
            this.txtKartelaAdi.TabIndex = 1;
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTedarikciAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(430, 49);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(74, 13);
            this.lblTedarikciAdi.TabIndex = 11;
            this.lblTedarikciAdi.Text = "Tedarikçi Adı";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(433, 65);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(187, 22);
            this.txtTedarikciAdi.TabIndex = 2;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdet.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdet.Location = new System.Drawing.Point(639, 49);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(32, 13);
            this.lblAdet.TabIndex = 13;
            this.lblAdet.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(642, 65);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(179, 22);
            this.txtAdet.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hoşgeldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(109, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::ZorluKartela.Properties.Resources.zorluteks_logo;
            this.label3.Location = new System.Drawing.Point(847, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 14;
            // 
            // SiparisListesi_ForZorlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(961, 526);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblTedarikciAdi);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.lblKartelaAdi);
            this.Controls.Add(this.txtKartelaAdi);
            this.Controls.Add(this.lblMagazaAdi);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.txtMagazaAdi);
            this.Controls.Add(this.lblSiparisListesi);
            this.Controls.Add(this.dgvSiparisListesi);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnSevkiyatBilgisi);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparisListesi_ForZorlu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SİPARİŞ LİSTESİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSevkiyatBilgisi;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dgvSiparisListesi;
        private System.Windows.Forms.Label lblSiparisListesi;
        private System.Windows.Forms.TextBox txtMagazaAdi;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Label lblMagazaAdi;
        private System.Windows.Forms.Label lblKartelaAdi;
        private System.Windows.Forms.TextBox txtKartelaAdi;
        private System.Windows.Forms.Label lblTedarikciAdi;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}