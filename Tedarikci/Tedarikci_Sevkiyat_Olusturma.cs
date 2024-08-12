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

namespace ZorluKartela.Tedarikci {

    public partial class Tedarikci_Sevkiyat_Olusturma : Form {

        public string Shopname { get; set; }
        public string Suppliername { get; set; }
        public string Kartelaname { get; set; }
        public int Count { get; set; }
        public int OrderID { get; set; }
        public int kalanadet { get; set; }
        public string magazaKodu { get; set; }
        public string tedarikciKodu { get; set; }
        public DateTime siparisTarihi { get; set; }

        public Tedarikci_Sevkiyat_Olusturma() {
            InitializeComponent();
        }

        int used;
        int countforusage;

        public void loadTransfers() {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                SqlCommand command2 = new SqlCommand("s_get_transfers_for_orderid", conn);
                command2.CommandType = CommandType.StoredProcedure;
                command2.Parameters.AddWithValue("@Orderid", this.OrderID);
                SqlDataAdapter sda = new SqlDataAdapter(command2);
                DataSet ds = new DataSet();
                try {
                    conn.Open();
                    sda.Fill(ds);
                } catch (SqlException se) {
                    MessageBox.Show("Hata oluştu" + se.ToString());
                } finally {
                    conn.Close();
                }
                dgvSevkiyatListesi.DataSource = ds.Tables[0];
                dgvSevkiyatListesi.Columns[0].Visible = false;
                dgvSevkiyatListesi.Columns[7].Visible = false;
                dgvSevkiyatListesi.Columns[11].Visible = false;
                dgvSevkiyatListesi.Columns[1].HeaderText = "SİPARİŞ NO";
                dgvSevkiyatListesi.Columns[2].HeaderText = "KARGO NO";
                dgvSevkiyatListesi.Columns[3].HeaderText = "İRSALİYE NO";
                dgvSevkiyatListesi.Columns[4].HeaderText = "ADET";
                dgvSevkiyatListesi.Columns[5].HeaderText = "SEVKİYAT TARİHİ";
                dgvSevkiyatListesi.Columns[6].HeaderText = "KAYIT TARİHİ";
                dgvSevkiyatListesi.Columns[8].HeaderText = "GÜNCELLEME TARİHİ";
                dgvSevkiyatListesi.Columns[9].HeaderText = "İADE DURUMU";
                dgvSevkiyatListesi.Columns[10].HeaderText = "TESLİM DURUMU";
                dgvSevkiyatListesi.Columns[12].HeaderText = "MAĞAZA ADI";
                dgvSevkiyatListesi.Columns[13].HeaderText = "KARTELA ADI";
                dgvSevkiyatListesi.Columns[14].HeaderText = "MAĞAZA KODU";
                dgvSevkiyatListesi.Columns[15].HeaderText = "TEDARİKÇİ KODU";
            }
        }

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
            Boolean boolError = false;
            if (txtYeniSevkiyatAdet.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Adet bilgisi boş kalamaz, lütfen sevkiyat adedi belirleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtIrsaliyeNo.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("İrsaliye numarası boş kalamaz, lütfen irsaliye numarası girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtKargoNo.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Kargo numarası boş kalamaz, lütfen kargo numarası giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtSevkiyatTarihi.Value == null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen sevkiyat tarihi seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int dateComparison = DateTime.Compare(this.siparisTarihi, DateTime.Parse(dtSevkiyatTarihi.Value.ToString()));
            if (dateComparison < 1) {
                boolError = true;
                DialogResult option = MessageBox.Show("Sevkiyat oluşturmak için lütfen siparişin ulaşması için belirlenen tarihle aynı ya da daha erken bir tarih giriniz.", "Hatalı Bilgi Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    try {
                        int parsedValue;
                        if (!int.TryParse(txtYeniSevkiyatAdet.Text, out parsedValue)) {
                            DialogResult option = MessageBox.Show("Lütfen sevkiyat adedi için bir sayı giriniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtYeniSevkiyatAdet.Clear();
                            return;
                        } else {
                            if (Convert.ToInt32(txtYeniSevkiyatAdet.Text) <= countforusage && txtYeniSevkiyatAdet.Text.ToString() != "0") {
                                SqlCommand command = new SqlCommand("s_transfer_add", conn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@Orderid", this.OrderID);
                                command.Parameters.AddWithValue("@Shipperno", txtKargoNo.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Waybillno", txtIrsaliyeNo.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Count", txtYeniSevkiyatAdet.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Transferdate", dtSevkiyatTarihi.Value.ToString());
                                command.Parameters.AddWithValue("@Isreturned", 0);
                                command.Parameters.AddWithValue("@Hasreceived", 0);
                                command.Parameters.AddWithValue("@Isactive", 1);
                                command.Parameters.AddWithValue("@Tedarikciadi", txtTedarikciAdi.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Magazaadi", txtMagazaAdi.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Kartelaadi", txtKartelaAdi.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Shopcode", txtMagazaKodu.Text.ToString().Trim());
                                command.Parameters.AddWithValue("@Suppliercode", this.tedarikciKodu);
                                command.CommandTimeout = 30;
                                conn.Open();
                                command.ExecuteNonQuery();
                                conn.Close();
                                DialogResult option = MessageBox.Show("Sevkiyat oluşturuldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                try {
                                    SqlCommand command2 = new SqlCommand("s_count_sum", conn);
                                    command2.CommandType = CommandType.StoredProcedure;
                                    command2.Parameters.AddWithValue("@Orderid", this.OrderID);
                                    SqlParameter COUNT = new SqlParameter("@Countsum", SqlDbType.Int) { Direction = ParameterDirection.Output };
                                    command2.Parameters.Add(COUNT);
                                    conn.Open();
                                    command2.ExecuteNonQuery();
                                    txtSevkAdet.Text = COUNT.SqlValue.ToString();
                                    conn.Close();
                                } catch (Exception ex) {
                                    MessageBox.Show("Hata oluştu." + ex.ToString());
                                } finally {
                                    conn.Close();
                                }
                                this.Close();
                            } else if (txtYeniSevkiyatAdet.Text.ToString() == "0") {
                                DialogResult option = MessageBox.Show("Lütfen sıfırdan farklı bir miktar belirleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtYeniSevkiyatAdet.Clear();
                            } else {
                                DialogResult option = MessageBox.Show("Sevkiyat için kalan ürün adedi miktarı " + countforusage + ". Lütfen sevkiyat adedini " + countforusage + " adet ya da daha düşük belirleyiniz.", "Ürün Adet Aşımı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                                if (option == DialogResult.OK) {
                                    txtYeniSevkiyatAdet.Clear();
                                } else {
                                    this.Close();
                                    SiparisListesi_ForZorlu frmSiparisListesi = new SiparisListesi_ForZorlu();
                                    frmSiparisListesi.ShowDialog();
                                }
                            }
                        }
                    } catch (SqlException ex) {
                        conn.Close();
                        MessageBox.Show("Hata oluştu." + ex.ToString());
                    } finally {
                        conn.Close();
                    }
                }
            }
        }

        private void Tedarikci_Sevkiyat_Olusturma_Load(object sender, EventArgs e) {
            label16.Text = KullaniciGiris.Shopname;
            used = Convert.ToInt32(this.Count.ToString()) - Convert.ToInt32(this.kalanadet.ToString());
            countforusage = Convert.ToInt32(this.Count.ToString()) - used;
            txtSevkAdet.Text = used.ToString();

            if (KullaniciGiris.UserName.ToString() == "zorlu") {
                this.Size = new Size(645, 435);
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.StartPosition=FormStartPosition.CenterScreen;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Text = "SİPARİŞ SEVKİYAT BİLGİSİ";
                txtSevkAdet.Text = used.ToString();

            }
            dtSevkiyatTarihi.MinDate = DateTime.Now;
            txtMagazaAdi.Text = this.Shopname;
            txtKartelaAdi.Text = this.Kartelaname;
            txtTedarikciAdi.Text = this.Suppliername;
            txtAdet.Text = this.Count.ToString();
            txtMagazaKodu.Text = this.magazaKodu.ToString();
            txtSiparisTarihi.Text = this.siparisTarihi.ToString();
            this.loadTransfers();
        }

        private void btnSevkiyatSil_Click_1(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvSevkiyatListesi.SelectedRows.Count > 0 && dgvSevkiyatListesi.SelectedRows[0].Cells[0].Value != null && dgvSevkiyatListesi.SelectedRows[0].Cells[10].Value.ToString() == "False") {
                    DialogResult option = MessageBox.Show("Seçilen sevkiyat kaydı silinecektir devam etmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (option == DialogResult.Yes) {
                        try {
                            SqlCommand command = new SqlCommand("s_delete_transfer", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Transferorderid", dgvSevkiyatListesi.CurrentRow.Cells[0].Value);
                            command.Parameters.AddWithValue("@count", dgvSevkiyatListesi.CurrentRow.Cells[4].Value);
                            conn.Open();
                            command.ExecuteNonQuery();
                            conn.Close();
                            DialogResult option2 = MessageBox.Show("Seçilen sevkiyat kaydı başarıyla silindi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        } catch (Exception) {
                            DialogResult option2 = MessageBox.Show("Lütfen geçerli bir sevkiyat seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                        }
                        this.loadTransfers();
                    }
                } else if (dgvSevkiyatListesi.SelectedRows.Count > 0 && dgvSevkiyatListesi.SelectedRows[0].Cells[0].Value != null && dgvSevkiyatListesi.SelectedRows[0].Cells[10].Value.ToString() == "True") {
                    DialogResult option = MessageBox.Show("Müşteri tarafından teslim alınmış kayıtlı bir teslimatı silemezsiniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    DialogResult option = MessageBox.Show("Lütfen silinecek bir sevkiyat seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
