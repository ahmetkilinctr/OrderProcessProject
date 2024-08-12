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
using ZorluKartela.Tedarikci;

namespace ZorluKartela {
    public partial class SiparisListesi_ForZorlu : Form {
        public SiparisListesi_ForZorlu() {
            InitializeComponent();
        }

        public void loadOrders() {
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
                        dgvSiparisListesi.DataSource = ds.Tables[0];
                    } catch (SqlException) {
                        DialogResult option = MessageBox.Show("Lütfen adet sorgusu için bir sayı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAdet.Clear();
                    } finally {
                        conn.Close();
                    }
                } catch (SqlException ex) {
                    conn.Close();
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
                dgvSiparisListesi.Columns[1].Visible = false;
                dgvSiparisListesi.Columns[6].Visible = false;
                dgvSiparisListesi.Columns[9].Visible = false;
                dgvSiparisListesi.Columns[10].Visible = false;
                dgvSiparisListesi.Columns[11].Visible = false;
                dgvSiparisListesi.Columns[13].Visible = false;
                dgvSiparisListesi.Columns[14].Visible = false;
                dgvSiparisListesi.Columns[15].Visible = false;
                dgvSiparisListesi.Columns[16].Visible = false;
                dgvSiparisListesi.Columns[17].Visible = false;
                dgvSiparisListesi.Columns[0].HeaderText = "SİPARİŞ NO";
                dgvSiparisListesi.Columns[2].HeaderText = "TEDARİKÇİ ADI";
                dgvSiparisListesi.Columns[3].HeaderText = "MAĞAZA ADI";
                dgvSiparisListesi.Columns[4].HeaderText = "ADET";
                dgvSiparisListesi.Columns[5].HeaderText = "KAYIT TARİHİ";
                dgvSiparisListesi.Columns[7].HeaderText = "GÜNCELLEME TARİHİ";
                dgvSiparisListesi.Columns[8].HeaderText = "KALAN ADET";
                dgvSiparisListesi.Columns[12].HeaderText = "SİPARİŞ TARİHİ";
                dgvSiparisListesi.Columns[13].HeaderText = "KARTELA ADI";
                dgvSiparisListesi.Columns[19].HeaderText = "MAĞAZA KODU";
                dgvSiparisListesi.Columns[20].HeaderText = "TEDARİKÇİ KODU";
            }
            string userNameFromDb = KullaniciGiris.UserName;
        }

        private void btnCikis_Click(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("Hesabınızdan çıkış yapılacak, onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) Application.Exit();
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
                    frmTedarikciSevkiyatOlusturma.kalanadet = (int)dgvSiparisListesi.SelectedRows[0].Cells[8].Value;
                    frmTedarikciSevkiyatOlusturma.magazaKodu = dgvSiparisListesi.SelectedRows[0].Cells[19].Value.ToString();
                    frmTedarikciSevkiyatOlusturma.siparisTarihi = DateTime.Parse(dgvSiparisListesi.SelectedRows[0].Cells[12].Value.ToString());
                    frmTedarikciSevkiyatOlusturma.ShowDialog();
                } else if (dgvSiparisListesi.SelectedRows.Count > 0 && dgvSiparisListesi.SelectedRows[0].Cells[0].Value == null) {
                    DialogResult option = MessageBox.Show("Lütfen sevkiyat bilgisi almak için bir sipariş seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    DialogResult option = MessageBox.Show("Lütfen sevkiyat bilgisi almak için bir sipariş seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSiparisSil_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvSiparisListesi.SelectedRows.Count > 0 && dgvSiparisListesi.SelectedRows[0].Cells[0].Value != null) {
                    DialogResult option = MessageBox.Show("Seçilen sipariş kaydı silinecektir devam etmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (option == DialogResult.Yes) {
                        try {
                            SqlCommand command = new SqlCommand("s_delete_orders", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Orderid", dgvSiparisListesi.CurrentRow.Cells[0].Value);
                            command.CommandTimeout = 30;
                            conn.Open();
                            command.ExecuteNonQuery();
                            conn.Close();
                            DialogResult option2 = MessageBox.Show("Kayıt silme işlemi gerçekleşti.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.loadOrders();
                        } catch (SqlException) {
                            conn.Close();
                            MessageBox.Show("Bu sipariş üzerinde bekleyen bir veya birden fazla sevkiyat bulunduğu için silme işlemi başarısız.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                } else {
                    MessageBox.Show("Lütfen silinecek bir sipariş seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e) {
            this.loadOrders();
        }

        private void SiparisListesi_Load(object sender, EventArgs e) {
            label4.Text = KullaniciGiris.Shopname;
            this.loadOrders();
        }
    }
}



