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

namespace ZorluKartela {
    public partial class Zorlu_MagazaYonetimi : Form {
        public Zorlu_MagazaYonetimi() {
            InitializeComponent();
        }
        public int CityId { get; set; }

        public void loadMagaza() {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                SqlCommand command2 = new SqlCommand("s_fillgview_shops", conn);
                command2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter("s_fillgview_shops", conn);
                DataSet ds = new DataSet();
                try {
                    conn.Open();
                    sda.Fill(ds);
                    command2.ExecuteNonQuery();
                } catch (SqlException ex) {
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                } finally {
                    conn.Close();
                }
                dgvMagazalar.DataSource = ds.Tables[0];
                dgvMagazalar.Columns[0].Visible = false;
                dgvMagazalar.Columns[3].Visible = false;
                dgvMagazalar.Columns[4].Visible = false;
                dgvMagazalar.Columns[5].Visible = false;
                dgvMagazalar.Columns[6].Visible = false;
                dgvMagazalar.Columns[10].Visible = false;
                dgvMagazalar.Columns[11].Visible = false;
                dgvMagazalar.Columns[12].Visible = false;
                dgvMagazalar.Columns[13].Visible = false;
                dgvMagazalar.Columns[14].Visible = false;
                dgvMagazalar.Columns[15].Visible = false;
                dgvMagazalar.Columns[16].Visible = false;
                dgvMagazalar.Columns[17].Visible = false;
                dgvMagazalar.Columns[18].Visible = false;
                dgvMagazalar.Columns[1].HeaderText = "MAĞAZA ADI";
                dgvMagazalar.Columns[2].HeaderText = "KULLANICI ADI";
                dgvMagazalar.Columns[7].HeaderText = "KAYIT TARİHİ";
                dgvMagazalar.Columns[8].HeaderText = "GÜNCELLENME TARİHİ";
                dgvMagazalar.Columns[9].HeaderText = "MAGAZA KODU";
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

        private void btnMagazaEkle_Click(object sender, EventArgs e) {
            Boolean boolError = false;
            int loopCount = 1;
            if (txtShopName.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen mağaza ismini boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtKullaniciAdi.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen kullanıcı adını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSifre.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen şifreyi boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEPosta.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen emaili boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAdres.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen adresi boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbxSehir.SelectedItem == null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen şehir seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtFirmaAdi.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen firma adını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMagazaMuduru.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen mağaza müdürü belirtiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtVergiDairesi.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen vergi dairesi adını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtVergiNo.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen vergi no kısmını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTelefon.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen telefon numarasını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMagazaKodu.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen mağaza kodunu boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtRollware.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen rollware kodunu boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                for (int k = 0; k < dgvMagazalar.Rows.Count; k++) {
                    if (dgvMagazalar.Rows[k].Cells[3].Value != null) {
                        if (txtShopName.Text != dgvMagazalar.Rows[k].Cells[1].Value.ToString() && txtKullaniciAdi.Text != dgvMagazalar.Rows[k].Cells[2].Value.ToString() && txtMagazaKodu.Text != dgvMagazalar.Rows[k].Cells[9].Value.ToString()) {
                            loopCount++;
                            if (loopCount == dgvMagazalar.Rows.Count) {
                                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                                    try {
                                        SqlCommand command = new SqlCommand("s_shop_add", conn);
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.AddWithValue("@SHOPNAME", txtShopName.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@USERNAME", txtKullaniciAdi.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@PASSWORD", txtSifre.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@ISZORLU", 0);
                                        command.Parameters.AddWithValue("@ISSUPPLIER", 0);
                                        command.Parameters.AddWithValue("@ISACTIVE", 1);
                                        command.Parameters.AddWithValue("@SHOPCODE", txtMagazaKodu.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@EMAIL", txtEPosta.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@CITYID", this.CityId);
                                        command.Parameters.AddWithValue("@ADDRESS", txtAdres.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@COMPANYNAME", txtFirmaAdi.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@MANAGER", txtMagazaMuduru.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@PHONE", txtTelefon.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@ROLLWARECODE", txtRollware.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@TAXNO", txtVergiNo.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@TAXOFFICE", txtVergiDairesi.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@R_STATUS", true);
                                        command.Parameters.AddWithValue("@R_STATUS_TXT", SqlDbType.VarChar);
                                        command.CommandTimeout = 45;
                                        conn.Open();
                                        command.ExecuteNonQuery();
                                        conn.Close();
                                        DialogResult option = MessageBox.Show("Kayıt başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtShopName.Clear();
                                        txtKullaniciAdi.Clear();
                                        txtSifre.Clear();
                                        txtMagazaKodu.Clear();
                                        txtEPosta.Clear();
                                        txtAdres.Clear();
                                        txtFirmaAdi.Clear();
                                        txtMagazaMuduru.Clear();
                                        txtTelefon.Clear();
                                        txtVergiDairesi.Clear();
                                        txtRollware.Clear();
                                        txtVergiNo.Clear();
                                    } catch (Exception ex) {
                                        conn.Close();
                                        MessageBox.Show("Hata oluştu." + ex.ToString());
                                    }
                                    this.loadMagaza();
                                }
                            } else {
                                continue;
                            }
                        } else {
                            if (txtShopName.Text == dgvMagazalar.Rows[k].Cells[1].Value.ToString()) {
                                DialogResult option = MessageBox.Show("Aynı isme sahip bir mağaza mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (txtKullaniciAdi.Text == dgvMagazalar.Rows[k].Cells[2].Value.ToString()) {
                                DialogResult option = MessageBox.Show("Aynı kullanıcı adına sahip bir mağaza mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (txtMagazaKodu.Text == dgvMagazalar.Rows[k].Cells[9].Value.ToString()) {
                                DialogResult option = MessageBox.Show("Aynı koda sahip bir mağaza mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e) {
            if (txtShopName.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtMagazaKodu.Text != "" && txtEPosta.Text != "" && txtAdres.Text != "" && txtFirmaAdi.Text != "" && txtMagazaMuduru.Text != "" && txtVergiDairesi.Text != "" && txtTelefon.Text != "" && txtVergiNo.Text != "") {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    try {
                        SqlCommand command = new SqlCommand("s_update_magaza", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", dgvMagazalar.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@Shopname", txtShopName.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Username", txtKullaniciAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Password", txtSifre.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Shopcode", txtMagazaKodu.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Email", txtEPosta.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Cityid", this.CityId);
                        command.Parameters.AddWithValue("@Address", txtAdres.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Companyname", txtFirmaAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Manager", txtMagazaMuduru.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Taxoffice", txtVergiDairesi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Phone", txtTelefon.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Rollware", txtRollware.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Taxno", txtVergiNo.Text.ToString().Trim());
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
                        DialogResult option = MessageBox.Show("Kayıt başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtShopName.Clear();
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                        txtMagazaKodu.Clear();
                        txtEPosta.Clear();
                        txtAdres.Clear();
                        txtFirmaAdi.Clear();
                        txtMagazaMuduru.Clear();
                        txtVergiDairesi.Clear();
                        txtTelefon.Clear();
                        txtRollware.Clear();
                        txtVergiNo.Clear();
                        this.loadMagaza();
                    } catch (SqlException ex) {
                        MessageBox.Show("Hata oluştu." + ex.ToString());
                    }
                }
            } else {
                DialogResult option = MessageBox.Show("Boş alanlar var, lütfen tekrar deneyiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvMagazalar.SelectedRows.Count > 0 && dgvMagazalar.SelectedRows[0].Cells[0].Value != null) {
                    SqlCommand cmd = new SqlCommand("s_check_magaza_exist_or_not", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Magazakodu", dgvMagazalar.SelectedRows[0].Cells[9].Value.ToString());
                    SqlParameter CODE = new SqlParameter("@IsExist", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(CODE);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(CODE.SqlValue.ToString())) {
                        DialogResult option = MessageBox.Show("Bu mağaza üzerinde gerçekleşen bir sevkiyat bulunduğu için silinemez.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    } else {
                        DialogResult option = MessageBox.Show("Seçilen mağaza kaydı silinecektir devam etmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (option == DialogResult.Yes) {
                            try {
                                SqlCommand command = new SqlCommand("s_delete_magaza_bychecking_exist_or_not", conn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@Shopcode", dgvMagazalar.CurrentRow.Cells[9].Value);
                                command.CommandTimeout = 30;
                                command.ExecuteNonQuery();
                                conn.Close();
                                DialogResult option2 = MessageBox.Show("Kayıt silme işlemi gerçekleşti.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtShopName.Clear();
                                txtKullaniciAdi.Clear();
                                txtSifre.Clear();
                                txtMagazaKodu.Clear();
                                txtEPosta.Clear();
                                txtAdres.Clear();
                                txtFirmaAdi.Clear();
                                txtMagazaMuduru.Clear();
                                txtTelefon.Clear();
                                txtVergiDairesi.Clear();
                                txtRollware.Clear();
                                txtVergiNo.Clear();
                                this.loadMagaza();
                            } catch (SqlException ex) {
                                conn.Close();
                                MessageBox.Show("Hata oluştu." + ex.ToString());
                            }
                        }
                    }
                } else {
                    DialogResult option = MessageBox.Show("Lütfen silinecek bir mağaza seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                SqlCommand command = new SqlCommand("s_filter_magaza", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Magazaname", txtfMagazaAdi.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Magazausername", txtfKullaniciAdi.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Shopcode", txtfMagazaKodu.Text.ToString().Trim());
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
                dgvMagazalar.DataSource = ds.Tables[0];
            }
        }

        private void Zorlu_MagazaYonetimi_Load(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                this.loadMagaza();
                label7.Text = KullaniciGiris.Shopname;

                SqlCommand command2 = new SqlCommand("get_city", conn);
                command2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda2 = new SqlDataAdapter("get_city", conn);
                DataSet ds2 = new DataSet();
                try {
                    conn.Open();
                    sda2.Fill(ds2);
                    command2.ExecuteNonQuery();
                } catch (SqlException se2) {
                    MessageBox.Show("Hata oluştu" + se2.ToString());
                } finally {
                    conn.Close();
                }
                cbxSehir.DataSource = ds2.Tables[0];
                cbxSehir.DisplayMember = ds2.Tables[0].Columns[1].ToString();
                cbxSehir.ValueMember = ds2.Tables[0].Columns[0].ToString();
                this.CityId = Convert.ToInt32(cbxSehir.SelectedValue);
            }
        }

        private void dgvMagazalar_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_magaza_fortext", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", dgvMagazalar.CurrentRow.Cells[0].Value);
                    SqlParameter SHOPNAME = new SqlParameter("@Shopname", SqlDbType.NVarChar, 1000) { Direction = ParameterDirection.Output };
                    SqlParameter USERNAME = new SqlParameter("@Username", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter PASSWORD = new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter SHOPCODE = new SqlParameter("@Shopcode", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter EMAIL = new SqlParameter("@Email", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter ADDRESS = new SqlParameter("@Address", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter COMPANYNAME = new SqlParameter("@Companyname", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter MANAGER = new SqlParameter("@Manager", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter PHONE = new SqlParameter("@Phone", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter TAXOFFICE = new SqlParameter("@Taxoffice", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter ROLLWARE = new SqlParameter("@Rollware", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    SqlParameter TAXNO = new SqlParameter("@Taxno", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(SHOPNAME);
                    command.Parameters.Add(USERNAME);
                    command.Parameters.Add(PASSWORD);
                    command.Parameters.Add(SHOPCODE);
                    command.Parameters.Add(EMAIL);
                    command.Parameters.Add(ADDRESS);
                    command.Parameters.Add(COMPANYNAME);
                    command.Parameters.Add(MANAGER);
                    command.Parameters.Add(PHONE);
                    command.Parameters.Add(TAXOFFICE);
                    command.Parameters.Add(ROLLWARE);
                    command.Parameters.Add(TAXNO);
                    conn.Open();
                    command.ExecuteNonQuery();
                    txtShopName.Text = SHOPNAME.SqlValue.ToString();
                    txtKullaniciAdi.Text = USERNAME.SqlValue.ToString();
                    txtSifre.Text = PASSWORD.SqlValue.ToString();
                    txtMagazaKodu.Text = SHOPCODE.SqlValue.ToString();
                    txtEPosta.Text = EMAIL.SqlValue.ToString();
                    txtAdres.Text = ADDRESS.SqlValue.ToString();
                    txtFirmaAdi.Text = COMPANYNAME.SqlValue.ToString();
                    txtMagazaMuduru.Text = MANAGER.SqlValue.ToString();
                    txtTelefon.Text = PHONE.SqlValue.ToString();
                    txtVergiDairesi.Text = TAXOFFICE.SqlValue.ToString();
                    txtRollware.Text = ROLLWARE.SqlValue.ToString();
                    txtVergiNo.Text = TAXNO.SqlValue.ToString();

                    if (txtShopName.Text == "Null") {
                        txtShopName.Clear();
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                        txtMagazaKodu.Clear();
                        txtEPosta.Clear();
                        txtAdres.Clear();
                        txtFirmaAdi.Clear();
                        txtMagazaMuduru.Clear();
                        txtTelefon.Clear();
                        txtVergiDairesi.Clear();
                        txtRollware.Clear();
                        txtVergiNo.Clear();
                    }
                    conn.Close();
                } catch (Exception ex) {
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
        }
    }
}
