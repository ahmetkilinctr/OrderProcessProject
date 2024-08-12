namespace ZorluKartela
{
    partial class Zorlu_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zorlu_MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikçiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mağazaYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartelaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topluSiparişYüklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.iadeBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişOluşturToolStripMenuItem,
            this.tedarikçiYönetimiToolStripMenuItem,
            this.mağazaYönetimiToolStripMenuItem,
            this.kartelaListesiToolStripMenuItem,
            this.topluSiparişYüklemeToolStripMenuItem,
            this.siparişListesiToolStripMenuItem,
            this.iadeBilgisiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(812, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişOluşturToolStripMenuItem
            // 
            this.siparişOluşturToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.siparişOluşturToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.siparişOluşturToolStripMenuItem.Name = "siparişOluşturToolStripMenuItem";
            this.siparişOluşturToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.siparişOluşturToolStripMenuItem.Text = "Sipariş Oluştur";
            this.siparişOluşturToolStripMenuItem.Click += new System.EventHandler(this.siparişOluşturToolStripMenuItem_Click);
            // 
            // tedarikçiYönetimiToolStripMenuItem
            // 
            this.tedarikçiYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tedarikçiYönetimiToolStripMenuItem.Name = "tedarikçiYönetimiToolStripMenuItem";
            this.tedarikçiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(118, 19);
            this.tedarikçiYönetimiToolStripMenuItem.Text = "Tedarikçi Yönetimi";
            this.tedarikçiYönetimiToolStripMenuItem.Click += new System.EventHandler(this.tedarikçiYönetimiToolStripMenuItem_Click);
            // 
            // mağazaYönetimiToolStripMenuItem
            // 
            this.mağazaYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mağazaYönetimiToolStripMenuItem.Name = "mağazaYönetimiToolStripMenuItem";
            this.mağazaYönetimiToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.mağazaYönetimiToolStripMenuItem.Text = "Mağaza Yönetimi";
            this.mağazaYönetimiToolStripMenuItem.Click += new System.EventHandler(this.mağazaYönetimiToolStripMenuItem_Click);
            // 
            // kartelaListesiToolStripMenuItem
            // 
            this.kartelaListesiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kartelaListesiToolStripMenuItem.Name = "kartelaListesiToolStripMenuItem";
            this.kartelaListesiToolStripMenuItem.Size = new System.Drawing.Size(90, 19);
            this.kartelaListesiToolStripMenuItem.Text = "Kartela Listesi";
            this.kartelaListesiToolStripMenuItem.Click += new System.EventHandler(this.kartelaListesiToolStripMenuItem_Click);
            // 
            // topluSiparişYüklemeToolStripMenuItem
            // 
            this.topluSiparişYüklemeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.topluSiparişYüklemeToolStripMenuItem.Name = "topluSiparişYüklemeToolStripMenuItem";
            this.topluSiparişYüklemeToolStripMenuItem.Size = new System.Drawing.Size(136, 19);
            this.topluSiparişYüklemeToolStripMenuItem.Text = "Toplu Sipariş Yükleme";
            this.topluSiparişYüklemeToolStripMenuItem.Click += new System.EventHandler(this.topluSiparişYüklemeToolStripMenuItem_Click);
            // 
            // siparişListesiToolStripMenuItem
            // 
            this.siparişListesiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            this.siparişListesiToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            this.siparişListesiToolStripMenuItem.Click += new System.EventHandler(this.siparişListesiToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::ZorluKartela.Properties.Resources.zorluteks_logo;
            this.label3.Location = new System.Drawing.Point(0, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(812, 405);
            this.label3.TabIndex = 13;
            // 
            // iadeBilgisiToolStripMenuItem
            // 
            this.iadeBilgisiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.iadeBilgisiToolStripMenuItem.Name = "iadeBilgisiToolStripMenuItem";
            this.iadeBilgisiToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.iadeBilgisiToolStripMenuItem.Text = "İade Bilgisi";
            this.iadeBilgisiToolStripMenuItem.Click += new System.EventHandler(this.iadeBilgisiToolStripMenuItem_Click);
            // 
            // Zorlu_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(812, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Zorlu_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZORLU MÜŞTERİ PANELİ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikçiYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mağazaYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartelaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topluSiparişYüklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişListesiToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem iadeBilgisiToolStripMenuItem;
    }
}