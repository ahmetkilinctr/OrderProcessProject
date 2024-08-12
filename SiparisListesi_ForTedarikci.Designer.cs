namespace KullaniciGiris {
    partial class SiparisListesi_ForTedarikci {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvSiparisListesi = new System.Windows.Forms.DataGridView();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblTedarikciAdi = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.lblKartelaAdi = new System.Windows.Forms.Label();
            this.txtKartelaAdi = new System.Windows.Forms.TextBox();
            this.lblMagazaAdi = new System.Windows.Forms.Label();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.txtMagazaAdi = new System.Windows.Forms.TextBox();
            this.lblSiparisListesi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSevkiyatBilgisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisListesi
            // 
            this.dgvSiparisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisListesi.Location = new System.Drawing.Point(15, 111);
            this.dgvSiparisListesi.Name = "dgvSiparisListesi";
            this.dgvSiparisListesi.Size = new System.Drawing.Size(770, 346);
            this.dgvSiparisListesi.TabIndex = 40;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(537, 17);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 39;
            this.lblAdet.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(540, 33);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(125, 20);
            this.txtAdet.TabIndex = 38;
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(360, 17);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(69, 13);
            this.lblTedarikciAdi.TabIndex = 37;
            this.lblTedarikciAdi.Text = "Tedarikçi Adı";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(363, 33);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(125, 20);
            this.txtTedarikciAdi.TabIndex = 36;
            // 
            // lblKartelaAdi
            // 
            this.lblKartelaAdi.AutoSize = true;
            this.lblKartelaAdi.Location = new System.Drawing.Point(186, 17);
            this.lblKartelaAdi.Name = "lblKartelaAdi";
            this.lblKartelaAdi.Size = new System.Drawing.Size(58, 13);
            this.lblKartelaAdi.TabIndex = 35;
            this.lblKartelaAdi.Text = "Kartela Adı";
            // 
            // txtKartelaAdi
            // 
            this.txtKartelaAdi.Location = new System.Drawing.Point(189, 33);
            this.txtKartelaAdi.Name = "txtKartelaAdi";
            this.txtKartelaAdi.Size = new System.Drawing.Size(125, 20);
            this.txtKartelaAdi.TabIndex = 34;
            // 
            // lblMagazaAdi
            // 
            this.lblMagazaAdi.AutoSize = true;
            this.lblMagazaAdi.Location = new System.Drawing.Point(12, 17);
            this.lblMagazaAdi.Name = "lblMagazaAdi";
            this.lblMagazaAdi.Size = new System.Drawing.Size(63, 13);
            this.lblMagazaAdi.TabIndex = 33;
            this.lblMagazaAdi.Text = "Mağaza Adı";
            // 
            // btnFiltre
            // 
            this.btnFiltre.Location = new System.Drawing.Point(710, 30);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(75, 23);
            this.btnFiltre.TabIndex = 32;
            this.btnFiltre.Text = "Sorgula";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // txtMagazaAdi
            // 
            this.txtMagazaAdi.Location = new System.Drawing.Point(15, 33);
            this.txtMagazaAdi.Name = "txtMagazaAdi";
            this.txtMagazaAdi.Size = new System.Drawing.Size(125, 20);
            this.txtMagazaAdi.TabIndex = 31;
            // 
            // lblSiparisListesi
            // 
            this.lblSiparisListesi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSiparisListesi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiparisListesi.Location = new System.Drawing.Point(12, 70);
            this.lblSiparisListesi.Name = "lblSiparisListesi";
            this.lblSiparisListesi.Size = new System.Drawing.Size(773, 29);
            this.lblSiparisListesi.TabIndex = 30;
            this.lblSiparisListesi.Text = "Sipariş Listesi";
            this.lblSiparisListesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(695, 463);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 23);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSevkiyatBilgisi
            // 
            this.btnSevkiyatBilgisi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSevkiyatBilgisi.Location = new System.Drawing.Point(12, 463);
            this.btnSevkiyatBilgisi.Name = "btnSevkiyatBilgisi";
            this.btnSevkiyatBilgisi.Size = new System.Drawing.Size(115, 26);
            this.btnSevkiyatBilgisi.TabIndex = 28;
            this.btnSevkiyatBilgisi.Text = "Sevkiyat Bilgisi";
            this.btnSevkiyatBilgisi.UseVisualStyleBackColor = true;
            this.btnSevkiyatBilgisi.Click += new System.EventHandler(this.btnSevkiyatBilgisi_Click);
            // 
            // SiparisListesi_ForTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 506);
            this.Controls.Add(this.dgvSiparisListesi);
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
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSevkiyatBilgisi);
            this.Name = "SiparisListesi_ForTedarikci";
            this.Text = "SiparisListesi_ForTedarikci";
            this.Load += new System.EventHandler(this.SiparisListesi_ForTedarikci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisListesi;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblTedarikciAdi;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.Label lblKartelaAdi;
        private System.Windows.Forms.TextBox txtKartelaAdi;
        private System.Windows.Forms.Label lblMagazaAdi;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.TextBox txtMagazaAdi;
        private System.Windows.Forms.Label lblSiparisListesi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSevkiyatBilgisi;
    }
}