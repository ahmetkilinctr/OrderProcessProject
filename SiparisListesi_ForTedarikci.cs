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
using KullaniciGiris.Tedarikci;

namespace KullaniciGiris {
    public partial class SiparisListesi_ForTedarikci : Form {
        public SiparisListesi_ForTedarikci() {
            InitializeComponent();
        }
        string usernamefromDb = KullaniciGiris.UserName;

        public void fncLoad() {//function for filter datagridview(when textboxes are empty, it works like getting all records,thats why it is used for siparis listesi load too.
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_filter_orders", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Shopname", txtMagazaAdi.Text.ToString().Trim());
                    command.Parameters.AddWithValue("@Kartelaname", txtKartelaAdi.Text.ToString().Trim());
                    command.Parameters.AddWithValue("@Suppliername", txtTedarikciAdi.Text.ToString().Trim());
                    command.Parameters.AddWithValue("@Count", txtAdet.Text.ToString().Trim());

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();

                    try {
                        conn.Open();
                        sda.Fill(ds);
                    } catch (SqlException se) {
                        MessageBox.Show("Hata oluştu" + se.ToString());
                    } finally {
                        conn.Close();
                    }
                    dgvSiparisListesi.DataSource = ds.Tables[0];
                } catch (SqlException ex) {
                    conn.Close();
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
            string userNameFromDb = KullaniciGiris.UserName;
        }

        private void SiparisListesi_ForTedarikci_Load(object sender, EventArgs e) {
            //ONCE SIPARIS OLUSTUR EKRANINDA GIZLI LABEL YARAT, SONRA TEDARIKCIFORFILLLABEL ADINDA AYNI MAGAZAYA TIKLANDIGINDA LABEL DOLMASI GIBI PROCEDURE YARAT, ALINAN KULLANICI ADI DEGERI LABEL A YAZILDIKTAN SONRA, ORDERS TABLOSUNDAKI TEDARIKCI ADI KISMINA EKLENECEK.ALINAN BU DEGER SIPARISLISTESI_FORTEDARIKCI FORMUNDA OKUNACAK. 
        }

        private void btnFiltre_Click(object sender, EventArgs e) {
            this.fncLoad();

        }

        private void btnSevkiyatBilgisi_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvSiparisListesi.SelectedRows.Count > 0 && dgvSiparisListesi.SelectedRows[0].Cells[0].Value != null) {
                    Tedarikci_Sevkiyat_Olusturma frmTedarikciSevkiyatOlusturma = new Tedarikci_Sevkiyat_Olusturma();
                    frmTedarikciSevkiyatOlusturma.OrderID = (int)dgvSiparisListesi.SelectedRows[0].Cells[0].Value;
                    frmTedarikciSevkiyatOlusturma.Shopname = dgvSiparisListesi.SelectedRows[0].Cells[3].Value.ToString();
                    frmTedarikciSevkiyatOlusturma.Suppliername = dgvSiparisListesi.SelectedRows[0].Cells[2].Value.ToString();
                    frmTedarikciSevkiyatOlusturma.Kartelaname = dgvSiparisListesi.SelectedRows[0].Cells[18].Value.ToString();
                    frmTedarikciSevkiyatOlusturma.Count = (int)dgvSiparisListesi.SelectedRows[0].Cells[4].Value;

                    frmTedarikciSevkiyatOlusturma.ShowDialog();
                } else if (dgvSiparisListesi.SelectedRows.Count > 0 && dgvSiparisListesi.SelectedRows[0].Cells[0].Value == null) {
                    MessageBox.Show("Sevkiyat oluşturulacak bir sipariş bulunmamaktadır.");
                } else {
                    MessageBox.Show("Lütfen sevkiyat oluşturulacak bir sipariş seçiniz.");
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("Hesabınızdan çıkış yapılacak, onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) Application.Exit();
        }
    }
}
