namespace ZorluKartela
{
    partial class Tedarikci_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedarikci_MainForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.topluSevkiyatYüklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.iadeBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topluSevkiyatYüklemeToolStripMenuItem,
            this.siparişListesiToolStripMenuItem,
            this.iadeBilgisiToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(812, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // topluSevkiyatYüklemeToolStripMenuItem
            // 
            this.topluSevkiyatYüklemeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.topluSevkiyatYüklemeToolStripMenuItem.Name = "topluSevkiyatYüklemeToolStripMenuItem";
            this.topluSevkiyatYüklemeToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.topluSevkiyatYüklemeToolStripMenuItem.Text = "Toplu Sevkiyat Yükleme";
            this.topluSevkiyatYüklemeToolStripMenuItem.Click += new System.EventHandler(this.topluSevkiyatYüklemeToolStripMenuItem_Click);
            // 
            // siparişListesiToolStripMenuItem
            // 
            this.siparişListesiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.siparişListesiToolStripMenuItem.Name = "siparişListesiToolStripMenuItem";
            this.siparişListesiToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.siparişListesiToolStripMenuItem.Text = "Sipariş Listesi";
            this.siparişListesiToolStripMenuItem.Click += new System.EventHandler(this.siparişListesiToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::ZorluKartela.Properties.Resources.zorluteks_logo;
            this.label3.Location = new System.Drawing.Point(0, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(812, 403);
            this.label3.TabIndex = 12;
            // 
            // iadeBilgisiToolStripMenuItem
            // 
            this.iadeBilgisiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.iadeBilgisiToolStripMenuItem.Name = "iadeBilgisiToolStripMenuItem";
            this.iadeBilgisiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.iadeBilgisiToolStripMenuItem.Text = "İade Bilgisi";
            this.iadeBilgisiToolStripMenuItem.Click += new System.EventHandler(this.iadeBilgisiToolStripMenuItem_Click);
            // 
            // Tedarikci_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Tedarikci_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEDARİKÇİ MÜŞTERİ PANELİ";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem topluSevkiyatYüklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişListesiToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem iadeBilgisiToolStripMenuItem;
    }
}