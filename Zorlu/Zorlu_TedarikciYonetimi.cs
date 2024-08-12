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
using System.Text.RegularExpressions;

namespace ZorluKartela {
    public partial class Zorlu_TedarikciYonetimi : Form {
        public Zorlu_TedarikciYonetimi() {
            InitializeComponent();
        }

        public void loadTedarikci() {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                SqlCommand command = new SqlCommand("s_filter_tedarikci", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Tedarikciname", txtTedarikciAdi.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Tedarikciusername", txtKullaniciAdi.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Tedarikcicode", txtTedarikciKodu.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Tedarikcimail", txtEPosta.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Password", txtSifre.Text.ToString().Trim());
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
                dgvTedarikciListesi.DataSource = ds.Tables[0];
                dgvTedarikciListesi.Columns[0].Visible = false;
                dgvTedarikciListesi.Columns[3].Visible = false;
                dgvTedarikciListesi.Columns[4].Visible = false;
                dgvTedarikciListesi.Columns[5].Visible = false;
                dgvTedarikciListesi.Columns[6].Visible = false;
                dgvTedarikciListesi.Columns[8].Visible = false;
                dgvTedarikciListesi.Columns[11].Visible = false;
                dgvTedarikciListesi.Columns[12].Visible = false;
                dgvTedarikciListesi.Columns[13].Visible = false;
                dgvTedarikciListesi.Columns[14].Visible = false;
                dgvTedarikciListesi.Columns[15].Visible = false;
                dgvTedarikciListesi.Columns[16].Visible = false;
                dgvTedarikciListesi.Columns[17].Visible = false;
                dgvTedarikciListesi.Columns[18].Visible = false;
                dgvTedarikciListesi.Columns[1].HeaderText = "TEDARİKÇİ ADI";
                dgvTedarikciListesi.Columns[2].HeaderText = "KULLANICI ADI";
                dgvTedarikciListesi.Columns[7].HeaderText = "KAYIT TARİHİ";
                dgvTedarikciListesi.Columns[9].HeaderText = "TEDARİKÇİ KODU";
                dgvTedarikciListesi.Columns[10].HeaderText = "EMAIL";
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
            int loopCount = 1;
            if (txtTedarikciAdi.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen tedarikçi adını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtKullaniciAdi.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen kullanıcı adını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtSifre.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen şifreyi boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTedarikciKodu.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen tedarikçi kodunu boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtEPosta.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen eposta adresini boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string metin = Convert.ToString(txtEPosta.Text);
            int i = metin.IndexOf("@com");
            if (i == -1) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen mail formatına uygun bir mail adresi giriniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                for (int k = 0; k < dgvTedarikciListesi.Rows.Count; k++) {
                    if (dgvTedarikciListesi.Rows[k].Cells[3].Value != null) {
                        if (txtTedarikciAdi.Text != dgvTedarikciListesi.Rows[k].Cells[1].Value.ToString() && txtKullaniciAdi.Text != dgvTedarikciListesi.Rows[k].Cells[2].Value.ToString() && txtTedarikciKodu.Text != dgvTedarikciListesi.Rows[k].Cells[9].Value.ToString()) {
                            loopCount++;
                            if (loopCount == dgvTedarikciListesi.Rows.Count) {
                                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                                    try {
                                        SqlCommand command = new SqlCommand("s_tedarikci_add", conn);
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.AddWithValue("@SHOPNAME", txtTedarikciAdi.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@USERNAME", txtKullaniciAdi.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@PASSWORD", txtSifre.Text.ToString().Trim());//Helper.Helper.Md5(txtSifre.Text.ToString().Trim()));
                                        command.Parameters.AddWithValue("@ISZORLU", 0);
                                        command.Parameters.AddWithValue("@ISSUPPLIER", 1);
                                        command.Parameters.AddWithValue("@ISACTIVE", 0);
                                        command.Parameters.AddWithValue("@SHOPCODE", txtTedarikciKodu.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@EMAIL", txtEPosta.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@CITYID", 4);
                                        command.Parameters.AddWithValue("@ADDRESS", txtTedarikciKodu.Text.ToString().Trim() + " adresi");
                                        command.Parameters.AddWithValue("@COMPANYNAME", txtTedarikciKodu.Text.ToString().Trim() + " sirketi");
                                        command.Parameters.AddWithValue("@MANAGER", txtTedarikciKodu.Text.ToString().Trim() + " yöneticisi");
                                        command.Parameters.AddWithValue("@PHONE", txtTedarikciKodu.Text.ToString().Trim() + " telefon numarası");
                                        command.Parameters.AddWithValue("@ROLLWARECODE", txtTedarikciKodu.Text.ToString().Trim() + " irsaliye numarası");
                                        command.Parameters.AddWithValue("@TAXNO", txtTedarikciKodu.Text.ToString().Trim() + " vergi numarası");
                                        command.Parameters.AddWithValue("@TAXOFFICE", txtTedarikciKodu.Text.ToString().Trim() + " vergi dairesi");
                                        command.Parameters.AddWithValue("@R_STATUS", true);
                                        command.Parameters.AddWithValue("@R_STATUS_TXT", SqlDbType.VarChar);
                                        command.CommandTimeout = 30;
                                        conn.Open();
                                        command.ExecuteNonQuery();
                                        conn.Close();
                                        DialogResult option = MessageBox.Show("Kayıt başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtTedarikciAdi.Clear();
                                        txtKullaniciAdi.Clear();
                                        txtSifre.Clear();
                                        txtTedarikciKodu.Clear();
                                        txtEPosta.Clear();
                                    } catch (Exception ex) {
                                        conn.Close();
                                        MessageBox.Show(ex.ToString());
                                    }
                                    this.loadTedarikci();
                                }
                            } else {
                                continue;
                            }
                        } else {
                            if (txtTedarikciAdi.Text == dgvTedarikciListesi.Rows[k].Cells[1].Value.ToString()) {
                                DialogResult option = MessageBox.Show("Aynı isme sahip bir tedarikçi mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (txtKullaniciAdi.Text == dgvTedarikciListesi.Rows[k].Cells[2].Value.ToString()) {
                                DialogResult option = MessageBox.Show("Aynı kullanıcı adına sahip bir tedarikçi mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } else if (txtTedarikciKodu.Text == dgvTedarikciListesi.Rows[k].Cells[9].Value.ToString()) {
                                DialogResult option = MessageBox.Show("Aynı koda sahip bir tedarikçi mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e) {
            if (txtTedarikciAdi.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtTedarikciKodu.Text != "" && txtEPosta.Text != "") {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    try {
                        SqlCommand command = new SqlCommand("s_update_tedarikci", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        command.Parameters.AddWithValue("@Id", dgvTedarikciListesi.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@Shopname", txtTedarikciAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Username", txtKullaniciAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Password", txtSifre.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Shopcode", txtTedarikciKodu.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Email", txtEPosta.Text.ToString().Trim());
                        command.ExecuteNonQuery();
                        DialogResult option = MessageBox.Show("Kayıt başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        txtTedarikciKodu.Clear();
                        txtTedarikciAdi.Clear();
                        txtSifre.Clear();
                        txtEPosta.Clear();
                        txtKullaniciAdi.Clear();
                        this.loadTedarikci();
                    } catch (SqlException ex) {
                        MessageBox.Show("Hata oluştu." + ex.ToString());
                    }
                }
            } else {
                DialogResult option = MessageBox.Show("Lütfen güncellenecek tedarikçi seçiniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvTedarikciListesi.SelectedRows.Count > 0 && dgvTedarikciListesi.SelectedRows[0].Cells[0].Value != null) {
                    SqlCommand cmd = new SqlCommand("s_check_tedarikci_exist_or_not", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Suppliercode", dgvTedarikciListesi.SelectedRows[0].Cells[9].Value.ToString());
                    SqlParameter CODE = new SqlParameter("@IsExist", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(CODE);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    if (Convert.ToBoolean(CODE.SqlValue.ToString())) {
                        DialogResult option = MessageBox.Show("Bu tedarikçi üzerinde gerçekleşen bir sevkiyat bulunduğu için silinemez.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    } else {
                        DialogResult option = MessageBox.Show("Seçilen tedarikçi kaydı silinecektir devam etmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (option == DialogResult.Yes) {
                            try {
                                SqlCommand command = new SqlCommand("s_delete_tedarikci", conn);
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@Id", dgvTedarikciListesi.CurrentRow.Cells[0].Value);
                                command.CommandTimeout = 30;
                                command.ExecuteNonQuery();
                                conn.Close();
                                DialogResult option2 = MessageBox.Show("Kayıt silme işlemi gerçekleşti.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtTedarikciKodu.Clear();
                                txtTedarikciAdi.Clear();
                                txtSifre.Clear();
                                txtEPosta.Clear();
                                txtKullaniciAdi.Clear();

                                SqlCommand command2 = new SqlCommand("s_get_tedarikci", conn);
                                command2.CommandType = CommandType.StoredProcedure;
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
                                dgvTedarikciListesi.DataSource = ds.Tables[0];
                                dgvTedarikciListesi.Columns[0].Visible = false;
                                dgvTedarikciListesi.Columns[3].Visible = false;
                                dgvTedarikciListesi.Columns[4].Visible = false;
                                dgvTedarikciListesi.Columns[5].Visible = false;
                                dgvTedarikciListesi.Columns[6].Visible = false;
                                dgvTedarikciListesi.Columns[8].Visible = false;
                                dgvTedarikciListesi.Columns[11].Visible = false;
                                dgvTedarikciListesi.Columns[12].Visible = false;
                                dgvTedarikciListesi.Columns[13].Visible = false;
                                dgvTedarikciListesi.Columns[14].Visible = false;
                                dgvTedarikciListesi.Columns[15].Visible = false;
                                dgvTedarikciListesi.Columns[16].Visible = false;
                                dgvTedarikciListesi.Columns[17].Visible = false;
                                dgvTedarikciListesi.Columns[18].Visible = false;
                                dgvTedarikciListesi.Columns[1].HeaderText = "TEDARİKÇİ ADI";
                                dgvTedarikciListesi.Columns[2].HeaderText = "KULLANICI ADI";
                                dgvTedarikciListesi.Columns[7].HeaderText = "KAYIT TARİHİ";
                                dgvTedarikciListesi.Columns[9].HeaderText = "TEDARİKÇİ KODU";
                                dgvTedarikciListesi.Columns[10].HeaderText = "EMAIL";
                            } catch (SqlException ex) {
                                conn.Close();
                                MessageBox.Show("Hata oluştu." + ex.ToString());
                            }
                        }
                    }
                } else {
                    DialogResult option = MessageBox.Show("Lütfen silinecek bir tedarikçi seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                this.loadTedarikci();
            }
        }

        private void Zorlu_TedarikciYonetimi_Load(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                this.loadTedarikci();
                label8.Text = KullaniciGiris.Shopname;
            }
        }

        private void dgvTedarikciListesi_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_tedarikci_fortext", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", dgvTedarikciListesi.CurrentRow.Cells[0].Value);
                    SqlParameter SHOPNAME = new SqlParameter("@Shopname", SqlDbType.NVarChar, 1000) { Direction = ParameterDirection.Output };
                    SqlParameter USERNAME = new SqlParameter("@Username", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter PASSWORD = new SqlParameter("@Password", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter SHOPCODE = new SqlParameter("@Shopcode", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter EMAIL = new SqlParameter("@Email", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(SHOPNAME);
                    command.Parameters.Add(USERNAME);
                    command.Parameters.Add(PASSWORD);
                    command.Parameters.Add(SHOPCODE);
                    command.Parameters.Add(EMAIL);
                    conn.Open();
                    command.ExecuteNonQuery();
                    txtTedarikciAdi.Text = SHOPNAME.SqlValue.ToString();
                    txtKullaniciAdi.Text = USERNAME.SqlValue.ToString();
                    txtSifre.Text = PASSWORD.SqlValue.ToString();
                    txtTedarikciKodu.Text = SHOPCODE.SqlValue.ToString();
                    txtEPosta.Text = EMAIL.SqlValue.ToString();

                    if (txtTedarikciAdi.Text == "Null") {
                        txtTedarikciAdi.Clear();
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                        txtTedarikciKodu.Clear();
                        txtEPosta.Clear();
                    }
                    conn.Close();
                } catch (Exception ex) {
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
        }
    }
}
