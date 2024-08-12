using ZorluKartela.Magaza;
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
    public partial class Magaza_MainForm : Form {
        public Magaza_MainForm() {
            InitializeComponent();
        }
        public void closeAnotherForm(Form form) {
            foreach (Form frm in this.MdiChildren) {
                if (frm != form) {
                    frm.Close();
                }
            }
        }

        private void siparişToolStripMenuItem_Click_1(object sender, EventArgs e) {
            SevkiyatListesi_ForShop frmSevkiyatListesi = new SevkiyatListesi_ForShop();
            frmSevkiyatListesi.MdiParent = this;
            frmSevkiyatListesi.Show();
            label3.Visible = false;
            closeAnotherForm(frmSevkiyatListesi);
        }
    }
}
