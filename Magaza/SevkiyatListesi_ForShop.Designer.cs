namespace ZorluKartela.Magaza {
    partial class SevkiyatListesi_ForShop {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SevkiyatListesi_ForShop));
            this.lblSevkiyatListesi = new System.Windows.Forms.Label();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnTeslimAlindi = new System.Windows.Forms.Button();
            this.dgvSevkiyatListesi = new System.Windows.Forms.DataGridView();
            this.lblAdet = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblTedarikciAdi = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.lblKartelaAdi = new System.Windows.Forms.Label();
            this.txtKartelaAdi = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnIade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIadeNedeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSevkiyatListesi
            // 
            this.lblSevkiyatListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSevkiyatListesi.BackColor = System.Drawing.SystemColors.Control;
            this.lblSevkiyatListesi.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSevkiyatListesi.ForeColor = System.Drawing.Color.Maroon;
            this.lblSevkiyatListesi.Location = new System.Drawing.Point(9, 98);
            this.lblSevkiyatListesi.Name = "lblSevkiyatListesi";
            this.lblSevkiyatListesi.Size = new System.Drawing.Size(598, 27);
            this.lblSevkiyatListesi.TabIndex = 0;
            this.lblSevkiyatListesi.Text = "Sevkiyat Listesi";
            this.lblSevkiyatListesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrele.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.Location = new System.Drawing.Point(532, 57);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrele.TabIndex = 3;
            this.btnFiltrele.Text = "Sorgula";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnTeslimAlindi
            // 
            this.btnTeslimAlindi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTeslimAlindi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeslimAlindi.Location = new System.Drawing.Point(12, 477);
            this.btnTeslimAlindi.Name = "btnTeslimAlindi";
            this.btnTeslimAlindi.Size = new System.Drawing.Size(83, 23);
            this.btnTeslimAlindi.TabIndex = 4;
            this.btnTeslimAlindi.Text = "Teslim Alındı";
            this.btnTeslimAlindi.UseVisualStyleBackColor = true;
            this.btnTeslimAlindi.Click += new System.EventHandler(this.btnTeslimAlindi_Click);
            // 
            // dgvSevkiyatListesi
            // 
            this.dgvSevkiyatListesi.AllowUserToAddRows = false;
            this.dgvSevkiyatListesi.AllowUserToDeleteRows = false;
            this.dgvSevkiyatListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSevkiyatListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSevkiyatListesi.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvSevkiyatListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSevkiyatListesi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSevkiyatListesi.Location = new System.Drawing.Point(12, 128);
            this.dgvSevkiyatListesi.Name = "dgvSevkiyatListesi";
            this.dgvSevkiyatListesi.ReadOnly = true;
            this.dgvSevkiyatListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSevkiyatListesi.Size = new System.Drawing.Size(595, 343);
            this.dgvSevkiyatListesi.TabIndex = 4;
            this.dgvSevkiyatListesi.TabStop = false;
            this.dgvSevkiyatListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSevkiyatListesi_CellContentClick);
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdet.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdet.Location = new System.Drawing.Point(360, 45);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(32, 13);
            this.lblAdet.TabIndex = 34;
            this.lblAdet.Text = "Adet";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(363, 60);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(144, 22);
            this.txtAdet.TabIndex = 2;
            // 
            // lblTedarikciAdi
            // 
            this.lblTedarikciAdi.AutoSize = true;
            this.lblTedarikciAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTedarikciAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblTedarikciAdi.Location = new System.Drawing.Point(183, 45);
            this.lblTedarikciAdi.Name = "lblTedarikciAdi";
            this.lblTedarikciAdi.Size = new System.Drawing.Size(74, 13);
            this.lblTedarikciAdi.TabIndex = 32;
            this.lblTedarikciAdi.Text = "Tedarikçi Adı";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(186, 61);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(144, 22);
            this.txtTedarikciAdi.TabIndex = 1;
            // 
            // lblKartelaAdi
            // 
            this.lblKartelaAdi.AutoSize = true;
            this.lblKartelaAdi.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKartelaAdi.ForeColor = System.Drawing.Color.Maroon;
            this.lblKartelaAdi.Location = new System.Drawing.Point(9, 45);
            this.lblKartelaAdi.Name = "lblKartelaAdi";
            this.lblKartelaAdi.Size = new System.Drawing.Size(64, 13);
            this.lblKartelaAdi.TabIndex = 30;
            this.lblKartelaAdi.Text = "Kartela Adı";
            // 
            // txtKartelaAdi
            // 
            this.txtKartelaAdi.Location = new System.Drawing.Point(12, 61);
            this.txtKartelaAdi.Name = "txtKartelaAdi";
            this.txtKartelaAdi.Size = new System.Drawing.Size(144, 22);
            this.txtKartelaAdi.TabIndex = 0;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.Location = new System.Drawing.Point(451, 477);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(532, 477);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnIade
            // 
            this.btnIade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIade.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIade.Location = new System.Drawing.Point(101, 477);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(75, 23);
            this.btnIade.TabIndex = 5;
            this.btnIade.Text = "Geri İade Et";
            this.btnIade.UseVisualStyleBackColor = true;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::ZorluKartela.Properties.Resources.zorluteks_logo;
            this.label3.Location = new System.Drawing.Point(510, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Hoşgeldiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(109, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "-";
            // 
            // btnIadeNedeni
            // 
            this.btnIadeNedeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIadeNedeni.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIadeNedeni.Location = new System.Drawing.Point(182, 477);
            this.btnIadeNedeni.Name = "btnIadeNedeni";
            this.btnIadeNedeni.Size = new System.Drawing.Size(148, 23);
            this.btnIadeNedeni.TabIndex = 41;
            this.btnIadeNedeni.Text = "İade Nedeni Görüntüle";
            this.btnIadeNedeni.UseVisualStyleBackColor = true;
            this.btnIadeNedeni.Click += new System.EventHandler(this.btnIadeNedeni_Click);
            // 
            // SevkiyatListesi_ForShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(623, 506);
            this.Controls.Add(this.btnIadeNedeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIade);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.lblTedarikciAdi);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.lblKartelaAdi);
            this.Controls.Add(this.txtKartelaAdi);
            this.Controls.Add(this.dgvSevkiyatListesi);
            this.Controls.Add(this.btnTeslimAlindi);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.lblSevkiyatListesi);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SevkiyatListesi_ForShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEVKİYAT LİSTESİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SevkiyatListesi_ForShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSevkiyatListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSevkiyatListesi;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnTeslimAlindi;
        private System.Windows.Forms.DataGridView dgvSevkiyatListesi;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblTedarikciAdi;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.Label lblKartelaAdi;
        private System.Windows.Forms.TextBox txtKartelaAdi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIadeNedeni;
    }
}