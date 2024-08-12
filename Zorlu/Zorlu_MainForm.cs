using ZorluKartela.Zorlu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorluKartela {
    public partial class Zorlu_MainForm : Form {
        public Zorlu_MainForm() {
            InitializeComponent();
        }

        public void closeAnotherForm(Form form) {
            foreach (Form frm in this.MdiChildren) {
                if (frm != form) {
                    frm.Close();
                }
            }
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e) {
            Zorlu_SiparisOlustur frmSiparisOlustur = new Zorlu_SiparisOlustur();
            frmSiparisOlustur.MdiParent = this;
            frmSiparisOlustur.Show();
            label3.Visible = false;
            closeAnotherForm(frmSiparisOlustur);
        }

        private void tedarikçiYönetimiToolStripMenuItem_Click(object sender, EventArgs e) {
            Zorlu_TedarikciYonetimi frmTedarikciYonetimi = new Zorlu_TedarikciYonetimi();
            frmTedarikciYonetimi.MdiParent = this;
            frmTedarikciYonetimi.Show();
            label3.Visible = false;
            closeAnotherForm(frmTedarikciYonetimi);
        }

        private void mağazaYönetimiToolStripMenuItem_Click(object sender, EventArgs e) {
            Zorlu_MagazaYonetimi frmMagazaYonetimi = new Zorlu_MagazaYonetimi();
            frmMagazaYonetimi.MdiParent = this;
            frmMagazaYonetimi.Show();
            label3.Visible = false;
            closeAnotherForm(frmMagazaYonetimi);
        }

        private void kartelaListesiToolStripMenuItem_Click(object sender, EventArgs e) {
            Zorlu_KartelaListesi frmKartelaListesi = new Zorlu_KartelaListesi();
            frmKartelaListesi.MdiParent = this;
            frmKartelaListesi.Show();
            label3.Visible = false;
            closeAnotherForm(frmKartelaListesi);
        }

        private void topluSiparişYüklemeToolStripMenuItem_Click(object sender, EventArgs e) {
            Zorlu_TopluSiparisYukleme frmTopluSiparis = new Zorlu_TopluSiparisYukleme();
            frmTopluSiparis.MdiParent = this;
            frmTopluSiparis.Show();
            label3.Visible = false;
            closeAnotherForm(frmTopluSiparis);
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e) {
            SiparisListesi_ForZorlu frmSiparisListesi = new SiparisListesi_ForZorlu();
            frmSiparisListesi.MdiParent = this;
            frmSiparisListesi.Show();
            label3.Visible = false;
            closeAnotherForm(frmSiparisListesi);
        }

        private void iadeBilgisiToolStripMenuItem_Click(object sender, EventArgs e) {
            Zorlu_IadeBilgisi frmIadeBilgisi = new Zorlu_IadeBilgisi();
            frmIadeBilgisi.MdiParent = this;
            frmIadeBilgisi.Show();
            label3.Visible = false;
            closeAnotherForm(frmIadeBilgisi);
        }
    }
}

