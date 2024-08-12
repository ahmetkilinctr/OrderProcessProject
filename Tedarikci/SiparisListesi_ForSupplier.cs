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
    public partial class SiparisListesi_ForSupplier : Form {
        public SiparisListesi_ForSupplier() {
            InitializeComponent();
        }

        string usernamefromDb = KullaniciGiris.UserName;
        string suppliercodefromDb = KullaniciGiris.shopCode;

        public void loadOrderListwithUserType() {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_orders_with_user_type", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", this.usernamefromDb.Trim());
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
                    dgvSiparisListesi.Columns[1].Visible = false;
                    dgvSiparisListesi.Columns[2].Visible = false;
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
                    dgvSiparisListesi.Columns[3].HeaderText = "MAĞAZA ADI";
                    dgvSiparisListesi.Columns[4].HeaderText = "ADET";
                    dgvSiparisListesi.Columns[5].HeaderText = "KAYIT TARİHİ";
                    dgvSiparisListesi.Columns[7].HeaderText = "GÜNCELLEME TARİHİ";
                    dgvSiparisListesi.Columns[8].HeaderText = "KALAN ADET";
                    dgvSiparisListesi.Columns[12].HeaderText = "SİPARİŞ TARİHİ";
                    dgvSiparisListesi.Columns[13].HeaderText = "KARTELA ADI";
                    dgvSiparisListesi.Columns[19].HeaderText = "MAĞAZA KODU";
                    dgvSiparisListesi.Columns[20].HeaderText = "TEDARİKÇİ KODU";
                } catch (Exception ex) {
                    conn.Close();
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
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
                    frmTedarikciSevkiyatOlusturma.tedarikciKodu=dgvSiparisListesi.SelectedRows[0].Cells[20].Value.ToString();
                    frmTedarikciSevkiyatOlusturma.siparisTarihi = DateTime.Parse(dgvSiparisListesi.SelectedRows[0].Cells[12].Value.ToString());
                    frmTedarikciSevkiyatOlusturma.ShowDialog();
                } else if (dgvSiparisListesi.SelectedRows.Count > 0 && dgvSiparisListesi.SelectedRows[0].Cells[0].Value == null) {
                    DialogResult option = MessageBox.Show("Lütfen sevkiyat oluşturulacak bir sipariş seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    DialogResult option = MessageBox.Show("Lütfen sevkiyat oluşturulacak bir sipariş seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }       

        private void btnFiltre_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {         
                try {
                    if (string.IsNullOrWhiteSpace(txtKartelaAdi.Text) && string.IsNullOrWhiteSpace(txtMagazaAdi.Text) && string.IsNullOrWhiteSpace(txtAdet.Text)) {
                        loadOrderListwithUserType();
                    }
                    else {
                        SqlCommand command2 = new SqlCommand("s_filter_orders_fortedarikci", conn);
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.Parameters.AddWithValue("@Tedarikcicode", this.suppliercodefromDb.Trim());
                        command2.Parameters.AddWithValue("@Kartelaadi", txtKartelaAdi.Text.ToString().Trim());
                        command2.Parameters.AddWithValue("@Magazaadi", txtMagazaAdi.Text.ToString().Trim());
                        command2.Parameters.AddWithValue("@Adet", txtAdet.Text.ToString().Trim());
                        SqlDataAdapter sda2 = new SqlDataAdapter(command2);
                        DataSet ds2 = new DataSet();
                        try {
                            conn.Open();
                            sda2.Fill(ds2);
                            dgvSiparisListesi.DataSource = ds2.Tables[0];
                        } catch (SqlException se) {
                            DialogResult option = MessageBox.Show("Lütfen adet sorgusu için bir sayı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAdet.Clear();
                        } finally {
                            conn.Close();
                        }
                    }
                } catch (Exception) {
                    conn.Close();
                    DialogResult option = MessageBox.Show("Lütfen bir adet sorgusu için bir sayı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAdet.Clear();
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e) {
            this.loadOrderListwithUserType();
        }

        private void SiparisListesi_ForShops_Load(object sender, EventArgs e) {
            label4.Text = KullaniciGiris.Shopname;
            this.loadOrderListwithUserType();
        }       
    }
}