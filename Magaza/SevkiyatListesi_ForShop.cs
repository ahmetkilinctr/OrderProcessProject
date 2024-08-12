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

namespace ZorluKartela.Magaza {
    public partial class SevkiyatListesi_ForShop : Form {
        public SevkiyatListesi_ForShop() {
            InitializeComponent();
        }

        string usernamefromDb = KullaniciGiris.UserName;
        string magazacodefromDb = KullaniciGiris.shopCode;

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

        private void btnTeslimAlindi_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvSevkiyatListesi.SelectedRows.Count > 0 && dgvSevkiyatListesi.SelectedRows[0].Cells[0].Value != null) {
                    if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "False" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "False") {
                        try {
                            SqlCommand command = new SqlCommand("s_update_transfer_received_status", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Id", dgvSevkiyatListesi.CurrentRow.Cells[0].Value);
                            conn.Open();
                            command.ExecuteNonQuery();
                            conn.Close();
                            DialogResult option = MessageBox.Show("Sipariş teslim alındı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch (Exception ex) {
                            MessageBox.Show("Hata Oluştu" + ex.ToString());
                        }

                        try {
                            SqlCommand command = new SqlCommand("s_get_transfers", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Magazausername", this.usernamefromDb.Trim());
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
                            dgvSevkiyatListesi.DataSource = ds.Tables[0];
                            dgvSevkiyatListesi.Columns[7].Visible = false;
                            dgvSevkiyatListesi.Columns[12].Visible = false;
                            dgvSevkiyatListesi.Columns[0].HeaderText = "SİPARİŞ ID";
                            dgvSevkiyatListesi.Columns[1].HeaderText = "SİPARİŞ NO";
                            dgvSevkiyatListesi.Columns[2].HeaderText = "KARGO NO";
                            dgvSevkiyatListesi.Columns[3].HeaderText = "İRSALİYE NO";
                            dgvSevkiyatListesi.Columns[4].HeaderText = "ADET";
                            dgvSevkiyatListesi.Columns[5].HeaderText = "SEVKİYAT TARİHİ";
                            dgvSevkiyatListesi.Columns[6].HeaderText = "KAYIT TARİHİ";
                            dgvSevkiyatListesi.Columns[8].HeaderText = "GÜNCELLEME TARİHİ";
                            dgvSevkiyatListesi.Columns[9].HeaderText = "İADE DURUMU";
                            dgvSevkiyatListesi.Columns[10].HeaderText = "TESLİM DURUMU";
                            dgvSevkiyatListesi.Columns[11].HeaderText = "TEDARİKÇİ ADI";
                            dgvSevkiyatListesi.Columns[13].HeaderText = "KARTELA ADI";
                        } catch (Exception ex) {
                            conn.Close();
                            MessageBox.Show("Hata oluştu." + ex.ToString());
                        }
                    } else if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "False" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "True") {
                        DialogResult option = MessageBox.Show("Ürün zaten teslim alındı.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "True" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "False") {
                        DialogResult option = MessageBox.Show("Ürün geri iade edilmiş.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    DialogResult option = MessageBox.Show("Lütfen önce üzerinde işlem yapılacak bir sevkiyat seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIade_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                if (dgvSevkiyatListesi.SelectedRows.Count > 0 && dgvSevkiyatListesi.SelectedRows[0].Cells[0].Value != null) {
                    if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "False" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "False") {
                        try {
                            SqlCommand command = new SqlCommand("s_update_transfer_returned_status", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Id", dgvSevkiyatListesi.CurrentRow.Cells[0].Value);
                            conn.Open();
                            command.ExecuteNonQuery();
                            conn.Close();
                            DialogResult option = MessageBox.Show("Sipariş iade edilmek üzere geri gönderildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            IadeGerekçesi frmIadeGerekcesi = new IadeGerekçesi();
                            frmIadeGerekcesi.OrderID = (int)dgvSevkiyatListesi.SelectedRows[0].Cells[1].Value;
                            frmIadeGerekcesi.magazaAdi = dgvSevkiyatListesi.SelectedRows[0].Cells[12].Value.ToString();
                            frmIadeGerekcesi.tedarikciAdi = dgvSevkiyatListesi.SelectedRows[0].Cells[11].Value.ToString();
                            frmIadeGerekcesi.kartelaAdi = dgvSevkiyatListesi.SelectedRows[0].Cells[13].Value.ToString();
                            frmIadeGerekcesi.magazaKodu = dgvSevkiyatListesi.SelectedRows[0].Cells[14].Value.ToString();
                            frmIadeGerekcesi.tedarikciKodu = dgvSevkiyatListesi.SelectedRows[0].Cells[15].Value.ToString();
                            frmIadeGerekcesi.sevkiyatAdedi = dgvSevkiyatListesi.SelectedRows[0].Cells[4].Value.ToString();
                            frmIadeGerekcesi.kargoNo = dgvSevkiyatListesi.SelectedRows[0].Cells[2].Value.ToString();
                            frmIadeGerekcesi.irsaliyeNo = dgvSevkiyatListesi.SelectedRows[0].Cells[3].Value.ToString();
                            frmIadeGerekcesi.sevkiyatTarihi = dgvSevkiyatListesi.SelectedRows[0].Cells[5].Value.ToString();
                            frmIadeGerekcesi.iadedurumu = dgvSevkiyatListesi.SelectedRows[0].Cells[9].Value.ToString();
                            frmIadeGerekcesi.teslimdurumu = dgvSevkiyatListesi.SelectedRows[0].Cells[10].Value.ToString();
                            frmIadeGerekcesi.ShowDialog();

                        } catch (Exception ex) {
                            MessageBox.Show("Hata Oluştu" + ex.ToString());
                        }
                        try {
                            SqlCommand command = new SqlCommand("s_get_transfers", conn);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Magazausername", this.usernamefromDb.Trim());
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
                            dgvSevkiyatListesi.DataSource = ds.Tables[0];
                            dgvSevkiyatListesi.Columns[0].Visible = false;
                            dgvSevkiyatListesi.Columns[7].Visible = false;
                            dgvSevkiyatListesi.Columns[12].Visible = false;
                            dgvSevkiyatListesi.Columns[1].HeaderText = "SİPARİŞ NO";
                            dgvSevkiyatListesi.Columns[2].HeaderText = "KARGO NO";
                            dgvSevkiyatListesi.Columns[3].HeaderText = "İRSALİYE NO";
                            dgvSevkiyatListesi.Columns[4].HeaderText = "ADET";
                            dgvSevkiyatListesi.Columns[5].HeaderText = "SEVKİYAT TARİHİ";
                            dgvSevkiyatListesi.Columns[6].HeaderText = "KAYIT TARİHİ";
                            dgvSevkiyatListesi.Columns[8].HeaderText = "GÜNCELLEME TARİHİ";
                            dgvSevkiyatListesi.Columns[9].HeaderText = "İADE DURUMU";
                            dgvSevkiyatListesi.Columns[10].HeaderText = "TESLİM DURUMU";
                            dgvSevkiyatListesi.Columns[11].HeaderText = "TEDARİKÇİ ADI";
                            dgvSevkiyatListesi.Columns[13].HeaderText = "KARTELA ADI";
                        } catch (Exception ex) {
                            conn.Close();
                            MessageBox.Show("Hata oluştu." + ex.ToString());
                        }
                    } else if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "True" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "False") {
                        DialogResult option = MessageBox.Show("Ürün zaten iade edilmiş.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "False" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "True") {
                        DialogResult option = MessageBox.Show("Ürün önceden teslim alınmış.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    DialogResult option = MessageBox.Show("Lütfen önce üzerinde işlem yapılacak bir sevkiyat seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIadeNedeni_Click(object sender, EventArgs e) {
            IadeGerekçesi frmiadegerekcesi = new IadeGerekçesi();
            frmiadegerekcesi.OrderID = (int)dgvSevkiyatListesi.SelectedRows[0].Cells[1].Value;
            frmiadegerekcesi.magazaAdi = dgvSevkiyatListesi.SelectedRows[0].Cells[12].Value.ToString();
            frmiadegerekcesi.tedarikciAdi = dgvSevkiyatListesi.SelectedRows[0].Cells[11].Value.ToString();
            frmiadegerekcesi.kartelaAdi = dgvSevkiyatListesi.SelectedRows[0].Cells[13].Value.ToString();
            frmiadegerekcesi.magazaKodu = dgvSevkiyatListesi.SelectedRows[0].Cells[14].Value.ToString();
            frmiadegerekcesi.tedarikciKodu = dgvSevkiyatListesi.SelectedRows[0].Cells[15].Value.ToString();
            frmiadegerekcesi.sevkiyatAdedi = dgvSevkiyatListesi.SelectedRows[0].Cells[4].Value.ToString();
            frmiadegerekcesi.kargoNo = dgvSevkiyatListesi.SelectedRows[0].Cells[2].Value.ToString();
            frmiadegerekcesi.irsaliyeNo = dgvSevkiyatListesi.SelectedRows[0].Cells[3].Value.ToString();
            frmiadegerekcesi.sevkiyatTarihi = dgvSevkiyatListesi.SelectedRows[0].Cells[5].Value.ToString();
            frmiadegerekcesi.iadedurumu = dgvSevkiyatListesi.SelectedRows[0].Cells[9].Value.ToString();
            frmiadegerekcesi.teslimdurumu = dgvSevkiyatListesi.SelectedRows[0].Cells[10].Value.ToString();
            frmiadegerekcesi.ShowDialog();
        }

        private void btnFiltrele_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    if (string.IsNullOrWhiteSpace(txtKartelaAdi.Text) && string.IsNullOrWhiteSpace(txtTedarikciAdi.Text) && string.IsNullOrWhiteSpace(txtAdet.Text)) {
                        SqlCommand command = new SqlCommand("s_get_transfers", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Magazausername", this.usernamefromDb.Trim());
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
                        dgvSevkiyatListesi.DataSource = ds.Tables[0];
                    } else {
                        SqlCommand command2 = new SqlCommand("s_filter_transfers", conn);
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.Parameters.AddWithValue("@Magazacode", this.magazacodefromDb.Trim());
                        command2.Parameters.AddWithValue("@Kartelaadi", txtKartelaAdi.Text.ToString().Trim());
                        command2.Parameters.AddWithValue("@Tedarikciadi", txtTedarikciAdi.Text.ToString().Trim());
                        command2.Parameters.AddWithValue("@Adet", txtAdet.Text.ToString().Trim());
                        SqlDataAdapter sda2 = new SqlDataAdapter(command2);
                        DataSet ds2 = new DataSet();
                        try {
                            conn.Open();
                            sda2.Fill(ds2);
                            dgvSevkiyatListesi.DataSource = ds2.Tables[0];
                        } catch (SqlException se) {
                            DialogResult option = MessageBox.Show("Lütfen adet sorgusu için bir sayı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAdet.Clear();
                        } finally {
                            conn.Close();
                        }
                    }
                } catch (SqlException ex) {
                    conn.Close();
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
        }

        private void SevkiyatListesi_ForShop_Load(object sender, EventArgs e) {
            label4.Text = KullaniciGiris.Shopname;
            btnIadeNedeni.Enabled = false;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_transfers", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Magazausername", this.usernamefromDb.Trim());
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
                    dgvSevkiyatListesi.DataSource = ds.Tables[0];
                    dgvSevkiyatListesi.Columns[0].Visible = false;
                    dgvSevkiyatListesi.Columns[7].Visible = false;
                    dgvSevkiyatListesi.Columns[12].Visible = false;
                    dgvSevkiyatListesi.Columns[1].HeaderText = "SİPARİŞ NO";
                    dgvSevkiyatListesi.Columns[2].HeaderText = "KARGO NO";
                    dgvSevkiyatListesi.Columns[3].HeaderText = "İRSALİYE NO";
                    dgvSevkiyatListesi.Columns[4].HeaderText = "ADET";
                    dgvSevkiyatListesi.Columns[5].HeaderText = "SEVKİYAT TARİHİ";
                    dgvSevkiyatListesi.Columns[6].HeaderText = "KAYIT TARİHİ";
                    dgvSevkiyatListesi.Columns[8].HeaderText = "GÜNCELLEME TARİHİ";
                    dgvSevkiyatListesi.Columns[9].HeaderText = "İADE DURUMU";
                    dgvSevkiyatListesi.Columns[10].HeaderText = "TESLİM DURUMU";
                    dgvSevkiyatListesi.Columns[11].HeaderText = "TEDARİKÇİ ADI";
                    dgvSevkiyatListesi.Columns[13].HeaderText = "KARTELA ADI";
                    dgvSevkiyatListesi.Columns[14].HeaderText = "MAĞAZA KODU";
                    dgvSevkiyatListesi.Columns[15].HeaderText = "TEDARİKÇİ KODU";
                } catch (Exception ex) {
                    conn.Close();
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
        }

        private void dgvSevkiyatListesi_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvSevkiyatListesi.CurrentRow.Cells[9].Value.ToString() == "True" && dgvSevkiyatListesi.CurrentRow.Cells[10].Value.ToString() == "False") {
                btnIadeNedeni.Enabled = true;
            } else {
                btnIadeNedeni.Enabled = false;
            }
        }
    }
}




