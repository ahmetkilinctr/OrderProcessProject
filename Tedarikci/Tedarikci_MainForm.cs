using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZorluKartela.Zorlu;
using ZorluKartela.Tedarikci;

namespace ZorluKartela {
    public partial class Tedarikci_MainForm : Form {
        public Tedarikci_MainForm() {
            InitializeComponent();
        }

        public void closeAnotherForm(Form form) {
            foreach (Form frm in this.MdiChildren) {
                if (frm != form) {
                    frm.Close();
                }
            }
            return;
        }

        private void topluSevkiyatYüklemeToolStripMenuItem_Click(object sender, EventArgs e) {
            Tedarikci_TopluSevkiyatYukleme frmTedarikciTopluSevkiyat = new Tedarikci_TopluSevkiyatYukleme();
            frmTedarikciTopluSevkiyat.MdiParent = this;
            frmTedarikciTopluSevkiyat.Show();
            label3.Visible = false;
            closeAnotherForm(frmTedarikciTopluSevkiyat);
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e) {
            SiparisListesi_ForSupplier frmSiparisListesi = new SiparisListesi_ForSupplier();
            frmSiparisListesi.MdiParent = this;
            frmSiparisListesi.Show();
            label3.Visible = false;
            closeAnotherForm(frmSiparisListesi);
        }

        private void iadeBilgisiToolStripMenuItem_Click(object sender, EventArgs e) {
            Tedarikci_IadeBilgisi frmIadeBilgisi = new Tedarikci_IadeBilgisi();
            frmIadeBilgisi.MdiParent = this;
            frmIadeBilgisi.Show();
            label3.Visible = false;
            closeAnotherForm(frmIadeBilgisi);
        }
    }
}
