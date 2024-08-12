using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorluKartela.Magaza {
    public partial class IadeGerekçesi : Form {
        public IadeGerekçesi() {
            InitializeComponent();
        }

        public int OrderID { get; set; }
        public string magazaAdi { get; set; }
        public string tedarikciAdi { get; set; }
        public string kartelaAdi { get; set; }
        public string magazaKodu { get; set; }
        public string tedarikciKodu { get; set; }
        public string sevkiyatAdedi { get; set; }
        public string kargoNo { get; set; }
        public string irsaliyeNo { get; set; }
        public string sevkiyatTarihi { get; set; }
        public string iadedurumu { get; set; }
        public string teslimdurumu { get; set; }
        public string iadeNedeni { get; set; } 

        private void btnIptal_Click(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("İşlemi iptal etmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {
                this.Hide();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("Hesabınızdan çıkış yapılacak, onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (txtIadeNedeni.Text != "") {
                    try {
                        SqlCommand command = new SqlCommand("s_return_add", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Orderid", this.OrderID);
                        command.Parameters.AddWithValue("@Shopname", txtMagazaAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Suppliername", txtTedarikciAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Kartelaname", txtKartelaAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Shopcode", txtMagazaKodu.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Suppliercode", txtTedarikciKodu.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Count", txtYeniSevkiyatAdet.Text.ToString());
                        command.Parameters.AddWithValue("@Shipperno", txtKargoNo.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Waybillno", txtIrsaliyeNo.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Transferdate", txtSevkiyatTarihi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Reason", txtIadeNedeni.Text.ToString().Trim());
                        command.CommandTimeout = 45;
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
                        DialogResult option = MessageBox.Show("İade gerekçesi ilgili kuruma gönderildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    } catch (Exception ex) {
                        MessageBox.Show("Hata oluştu" + ex.ToString());
                    }
                } else {
                    DialogResult option = MessageBox.Show("Kaydetmek için lütfen iade nedeni alanını doldurunuz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void IadeGerekçesi_Load(object sender, EventArgs e) {
            if (KullaniciGiris.Shopname == "zorlu1x" || KullaniciGiris.status == "3") {
                label16.Text = KullaniciGiris.Shopname;
                txtMagazaAdi.Text = this.magazaAdi;
                txtTedarikciAdi.Text = this.tedarikciAdi;
                txtKartelaAdi.Text = this.kartelaAdi;
                txtMagazaKodu.Text = this.magazaKodu;
                txtTedarikciKodu.Text = this.tedarikciKodu;
                txtYeniSevkiyatAdet.Text = this.sevkiyatAdedi.ToString();
                txtKargoNo.Text = this.kargoNo;
                txtIrsaliyeNo.Text = this.irsaliyeNo;
                txtSevkiyatTarihi.Text = this.sevkiyatTarihi;
                txtIadeNedeni.Text = this.iadeNedeni;
                txtIadeNedeni.Enabled = false;
                btnKaydet.Visible = false;
                btnIptal.Text = "Geri";
            } else {
                label16.Text = KullaniciGiris.Shopname;
                txtMagazaAdi.Text = this.magazaAdi;
                txtTedarikciAdi.Text = this.tedarikciAdi;
                txtKartelaAdi.Text = this.kartelaAdi;
                txtMagazaKodu.Text = this.magazaKodu;
                txtTedarikciKodu.Text = this.tedarikciKodu;
                txtYeniSevkiyatAdet.Text = this.sevkiyatAdedi.ToString();
                txtKargoNo.Text = this.kargoNo;
                txtIrsaliyeNo.Text = this.irsaliyeNo;
                txtSevkiyatTarihi.Text = this.sevkiyatTarihi;
            }

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (this.iadedurumu == "True" && this.teslimdurumu == "False") {
                    txtIadeNedeni.Enabled = false;
                    btnKaydet.Visible = false;
                    btnIptal.Text = "Geri";
                    try {
                        SqlCommand command = new SqlCommand("s_get_returninfo_reason_fortext", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Kargono", this.kargoNo);
                        command.Parameters.AddWithValue("@Irsaliyeno", this.irsaliyeNo);
                        SqlParameter REASON = new SqlParameter("@Reason", SqlDbType.NVarChar, 4000) { Direction = ParameterDirection.Output };
                        command.Parameters.Add(REASON);
                        conn.Open();
                        command.ExecuteNonQuery();
                        txtIadeNedeni.Text = REASON.SqlValue.ToString();
                        conn.Close();
                    } catch (Exception ex) {
                        MessageBox.Show("Hata oluştu" + ex.ToString());
                    }
                }
            }
        }
    }
}

