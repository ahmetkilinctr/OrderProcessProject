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
    public partial class Zorlu_SiparisOlustur : Form {
        public Zorlu_SiparisOlustur() {
            InitializeComponent();
        }

        public string tedarikciKodu { get; set; }

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
            if (cbxMagazaAdi.SelectedItem == null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen mağaza seçiniz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbxKartela.SelectedItem == null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen kartela seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbxTedarikci.SelectedItem == null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen tedarikçi seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtSiparisTarihi.Value == null) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen sipariş tarihi seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAdet.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Lütfen adet belirleyiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int parsedValue;
            if (!int.TryParse(txtAdet.Text, out parsedValue)) {
                DialogResult option = MessageBox.Show("Lütfen adedi belirlemek için sadece rakam girin", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdet.Clear();
                return;
            }
            if (int.Parse(txtAdet.Text) == 0) {
                DialogResult option = MessageBox.Show("Lütfen 0'dan farklı bir adet giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdet.Clear();
                return;
            } else {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    try {
                        SqlCommand command = new SqlCommand("s_orders_add", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Shopname", cbxMagazaAdi.GetItemText(cbxMagazaAdi.SelectedItem));
                        command.Parameters.AddWithValue("@Kartelaname", cbxKartela.GetItemText(cbxKartela.SelectedItem));
                        command.Parameters.AddWithValue("@Suppliername", cbxTedarikci.GetItemText(cbxTedarikci.SelectedItem));
                        command.Parameters.AddWithValue("@Adet", txtAdet.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Orderdate", dtSiparisTarihi.Value.ToString());
                        command.Parameters.AddWithValue("@Username", cbxTedarikci.GetItemText(cbxTedarikci.SelectedItem));
                        command.Parameters.AddWithValue("@Shopcode", lblMagazaKoduFill.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Isactive", 1);
                        command.Parameters.AddWithValue("@Suppliercode", this.tedarikciKodu);
                        command.Parameters.AddWithValue("@R_STATUS", true);
                        command.Parameters.AddWithValue("@R_STATUS_TXT", SqlDbType.VarChar);
                        command.CommandTimeout = 45;
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
                        DialogResult option = MessageBox.Show("Sipariş oluşturuldu.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdet.Clear();
                        dtSiparisTarihi.Value = DateTime.Now;
                    } catch (Exception ex) {
                        conn.Close();
                        MessageBox.Show("Hata oluştu." + ex.ToString());
                    }
                }
            }
        }

        private void Zorlu_SiparisOlustur_Load(object sender, EventArgs e) {
            dtSiparisTarihi.MinDate = DateTime.Now;
            label4.Text = KullaniciGiris.Shopname;
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                SqlCommand command = new SqlCommand("s_fillgview_shops", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter("s_fillgview_shops", conn);
                DataSet ds = new DataSet();
                try {
                    conn.Open();
                    sda.Fill(ds);
                    command.ExecuteNonQuery();
                } catch (SqlException se) {
                    MessageBox.Show("Hata oluştu" + se.ToString());
                } finally {
                    conn.Close();
                }
                cbxMagazaAdi.DataSource = ds.Tables[0];
                cbxMagazaAdi.DisplayMember = "SHOPNAME";
                cbxMagazaAdi.ValueMember = "SHOPNAME";
                cbxMagazaAdi.SelectedIndex = 0;

                SqlCommand command2 = new SqlCommand("s_get_kartela", conn);
                command2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda2 = new SqlDataAdapter("s_get_kartela", conn);
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
                cbxKartela.DataSource = ds2.Tables[0];
                cbxKartela.DisplayMember = ds2.Tables[0].Columns[3].ToString();

                SqlCommand command3 = new SqlCommand("s_get_tedarikci", conn);
                command3.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda3 = new SqlDataAdapter("s_get_tedarikci", conn);
                DataSet ds3 = new DataSet();
                try {
                    conn.Open();
                    sda3.Fill(ds3);
                    command3.ExecuteNonQuery();
                } catch (SqlException se3) {
                    MessageBox.Show("Hata oluştu" + se3.ToString());
                } finally {
                    conn.Close();
                }
                cbxTedarikci.DataSource = ds3.Tables[0];
                cbxTedarikci.DisplayMember = ds3.Tables[0].Columns[1].ToString();
            }
        }

        private void cbxMagazaAdi_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbxMagazaAdi.SelectedIndex >= 0) {
                if (!string.IsNullOrEmpty(cbxMagazaAdi.GetItemText(cbxMagazaAdi.SelectedItem))) {
                    using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                        try {
                            SqlCommand command4 = new SqlCommand("s_getmagaza_tofilllabel", conn);
                            command4.CommandType = CommandType.StoredProcedure;
                            command4.Parameters.AddWithValue("@SHOPNAME", cbxMagazaAdi.GetItemText(cbxMagazaAdi.SelectedItem));
                            SqlParameter SHOPCODE = new SqlParameter("@SHOPCODE", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                            SqlParameter COMPANYNAME = new SqlParameter("@COMPANYNAME", SqlDbType.NVarChar, 1000) { Direction = ParameterDirection.Output };
                            SqlParameter EMAIL = new SqlParameter("@EMAIL", SqlDbType.VarChar, 250) { Direction = ParameterDirection.Output };
                            SqlParameter ADDRESS = new SqlParameter("@ADDRESS", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output };
                            SqlParameter CITYID = new SqlParameter("@CITYID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                            SqlParameter PHONE = new SqlParameter("@PHONE", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                            SqlParameter MANAGER = new SqlParameter("@MANAGER", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                            SqlParameter ROLLWARE = new SqlParameter("@ROLLWARE", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                            SqlParameter TAXOFFICE = new SqlParameter("@TAXOFFICE", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                            SqlParameter TAXNO = new SqlParameter("@TAXNO", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                            command4.Parameters.Add(SHOPCODE);
                            command4.Parameters.Add(COMPANYNAME);
                            command4.Parameters.Add(EMAIL);
                            command4.Parameters.Add(ADDRESS);
                            command4.Parameters.Add(CITYID);
                            command4.Parameters.Add(PHONE);
                            command4.Parameters.Add(MANAGER);
                            command4.Parameters.Add(ROLLWARE);
                            command4.Parameters.Add(TAXOFFICE);
                            command4.Parameters.Add(TAXNO);
                            conn.Open();
                            command4.ExecuteNonQuery();
                            lblMagazaKoduFill.Text = SHOPCODE.SqlValue.ToString();
                            lblSirketAdıFill.Text = COMPANYNAME.SqlValue.ToString();
                            lblEPostaFill.Text = EMAIL.SqlValue.ToString();
                            lblAdresFill.Text = ADDRESS.SqlValue.ToString();
                            lblSehirFill.Text = CITYID.SqlValue.ToString();
                            lblTelefonFill.Text = PHONE.SqlValue.ToString();
                            lblMagazaMuduruFill.Text = MANAGER.SqlValue.ToString();
                            lblRollwareFill.Text = ROLLWARE.SqlValue.ToString();
                            lblVergiDairesiFill.Text = TAXOFFICE.SqlValue.ToString();
                            lblVergiNoFill.Text = SHOPCODE.SqlValue.ToString();
                            conn.Close();
                        } catch (Exception ex) {
                            conn.Close();
                            MessageBox.Show("Hata oluştu." + ex.ToString());
                        }
                    }
                }
            }
        }

        private void cbxTedarikci_SelectedIndexChanged(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_tedarikcicode_for_orders_column", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Suppliername", cbxTedarikci.GetItemText(cbxTedarikci.SelectedItem));
                    SqlParameter SUPPLIERCODE = new SqlParameter("@Suppliercode", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(SUPPLIERCODE);
                    conn.Open();
                    command.ExecuteNonQuery();
                    this.tedarikciKodu = SUPPLIERCODE.SqlValue.ToString();
                    conn.Close();
                } catch (Exception ex) {
                    conn.Close();
                    MessageBox.Show("Hata oluştu." + ex.ToString());
                }
            }
        }
    }
}
