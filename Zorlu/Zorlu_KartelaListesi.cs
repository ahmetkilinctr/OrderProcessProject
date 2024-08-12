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

namespace ZorluKartela {
    public partial class Zorlu_KartelaListesi : Form {
        public Zorlu_KartelaListesi() {
            InitializeComponent();
        }
        public void loadKartela() {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                SqlCommand command = new SqlCommand("s_filter_kartela", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Kartelacode", txtKartelaKodu.Text.ToString().Trim());
                command.Parameters.AddWithValue("@Kartelaname", txtKartelaAdı.Text.ToString().Trim());
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
                dgvKartelaListesi.DataSource = ds.Tables[0];
                dgvKartelaListesi.Columns[0].Visible = false;
                dgvKartelaListesi.Columns[1].Visible = false;
                dgvKartelaListesi.Columns[2].HeaderText = "KARTELA KODU";
                dgvKartelaListesi.Columns[3].HeaderText = "KARTELA ADI";
                dgvKartelaListesi.Columns[4].HeaderText = "KAYIT TARİHİ";
                dgvKartelaListesi.Columns[5].HeaderText = "GÜNCELLENME TARİHİ";
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
            int loopCount = 1;
            Boolean boolError = false;
            if (txtKartelaKodu.Text.ToString().Trim().Equals("") && txtKartelaAdı.Text.ToString().Trim() != null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen kartela kodunu boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtKartelaKodu.Text.ToString().Trim() != null && txtKartelaAdı.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen kartela adını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtKartelaKodu.Text.ToString().Trim().Equals("") && txtKartelaAdı.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen kartela kodu ve kartela adı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                for (int i = 0; i < dgvKartelaListesi.Rows.Count; i++) {
                    if (dgvKartelaListesi.Rows[i].Cells[3].Value != null) {
                        if (txtKartelaKodu.Text != dgvKartelaListesi.Rows[i].Cells[2].Value.ToString()) {
                            loopCount++;
                            if (loopCount == dgvKartelaListesi.Rows.Count) {
                                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                                    try {
                                        SqlCommand command = new SqlCommand("kartela_add", conn);
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.Parameters.AddWithValue("@ISACTIVE", 1);
                                        command.Parameters.AddWithValue("@KARTELACODE", txtKartelaKodu.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@KARTELANAME", txtKartelaAdı.Text.ToString().Trim());
                                        command.Parameters.AddWithValue("@R_STATUS", true);
                                        command.Parameters.AddWithValue("@R_STATUS_TXT", SqlDbType.VarChar);
                                        command.CommandTimeout = 45;
                                        conn.Open();
                                        command.ExecuteNonQuery();
                                        conn.Close();
                                        DialogResult option = MessageBox.Show("Kayıt başarıyla eklendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtKartelaAdı.Clear();
                                        txtKartelaKodu.Clear();
                                    } catch (Exception ex) {
                                        conn.Close();
                                        MessageBox.Show("Hata oluştu." + ex.ToString());
                                    }

                                    SqlCommand command2 = new SqlCommand("s_get_kartela", conn);
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
                                    dgvKartelaListesi.DataSource = ds.Tables[0];
                                    dgvKartelaListesi.Columns[0].Visible = false;
                                    dgvKartelaListesi.Columns[1].Visible = false;
                                    dgvKartelaListesi.Columns[2].HeaderText = "KARTELA KODU";
                                    dgvKartelaListesi.Columns[3].HeaderText = "KARTELA ADI";
                                    dgvKartelaListesi.Columns[4].HeaderText = "KAYIT TARİHİ";
                                    dgvKartelaListesi.Columns[5].HeaderText = "GÜNCELLENME TARİHİ";
                                }
                            } else {
                                continue;
                            }
                        } else {
                            DialogResult option = MessageBox.Show("Aynı koda sahip bir kartela mevcut. Lütfen tekrar deneyin.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void btnKayıtGuncelle_Click(object sender, EventArgs e) {
            if (txtKartelaKodu.Text != "" && txtKartelaAdı.Text != "") {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    try {
                        SqlCommand command = new SqlCommand("s_update_kartela", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        command.Parameters.AddWithValue("@Kartelaid", dgvKartelaListesi.CurrentRow.Cells[0].Value.ToString());
                        command.Parameters.AddWithValue("@Kartelacode", txtKartelaKodu.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Kartelaname", txtKartelaAdı.Text.ToString().Trim());
                        command.ExecuteNonQuery();
                        DialogResult option = MessageBox.Show("Kayıt başarıyla güncellendi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtKartelaKodu.Clear();
                        txtKartelaAdı.Clear();
                        conn.Close();
                        this.loadKartela();
                    } catch (SqlException ex) {
                        MessageBox.Show("Hata oluştu." + ex.ToString());
                    }
                }
            } else {
                DialogResult option = MessageBox.Show("Lütfen güncellenecek bir kartela seçiniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKayıtSil_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvKartelaListesi.SelectedRows.Count > 0 && dgvKartelaListesi.SelectedRows[0].Cells[0].Value != null) {
                    DialogResult option = MessageBox.Show("Seçilen kartela kaydı silinecektir devam etmek istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (option == DialogResult.Yes) {
                        try {
                            SqlCommand command = new SqlCommand("s_delete_kartela", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Kartelaid", dgvKartelaListesi.CurrentRow.Cells[0].Value);
                            command.CommandTimeout = 30;
                            conn.Open();
                            command.ExecuteNonQuery();
                            conn.Close();
                            DialogResult option2 = MessageBox.Show("Kayıt silme işlemi gerçekleşti.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtKartelaAdı.Clear();
                            txtKartelaKodu.Clear();
                            this.loadKartela();
                        } catch (SqlException ex) {
                            conn.Close();
                            MessageBox.Show("Hata oluştu." + ex.ToString());
                        }
                    }
                } else {
                    DialogResult option = MessageBox.Show("Lütfen silinecek bir kartela seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSorgula_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                this.loadKartela();
            }
        }

        private void Zorlu_KartelaListesi_Load(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                this.loadKartela();
                KullaniciGiris isim = new KullaniciGiris();
                label4.Text = KullaniciGiris.Shopname;
            }
        }

        private void dgvKartelaListesi_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_kartela_fortext", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Kartelaid", dgvKartelaListesi.CurrentRow.Cells[0].Value);
                    SqlParameter KARTELACODE = new SqlParameter("@Kartelacode", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    SqlParameter KARTELANAME = new SqlParameter("@Kartelaname", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(KARTELACODE);
                    command.Parameters.Add(KARTELANAME);
                    conn.Open();
                    command.ExecuteNonQuery();
                    txtKartelaKodu.Text = KARTELACODE.SqlValue.ToString();
                    txtKartelaAdı.Text = KARTELANAME.SqlValue.ToString();
                    if (txtKartelaAdı.Text == "Null") {
                        txtKartelaAdı.Clear();
                        txtKartelaKodu.Clear();
                    }
                    conn.Close();
                } catch (SqlException ex) {
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
        }
    }
}

