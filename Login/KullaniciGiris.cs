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
    public partial class KullaniciGiris : Form {

        public static string UserName { get; set; }
        public static string Shopname { get; set; }
        public static string shopCode { get; set; }
        public static string status { get; set; }

        public KullaniciGiris() {
            InitializeComponent();
        }

        string checkresult = "";

        private void btnGiris_Click(object sender, EventArgs e) {
            Boolean boolError = false;
            if (txtKullaniciAdi.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Kullanıcı adı giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSifre.Text.ToString().Trim().Equals("")) {
                boolError = true;
                DialogResult option = MessageBox.Show("Şifre giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    try {
                        SqlCommand command = new SqlCommand("s_get_users", conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", txtKullaniciAdi.Text.ToString().Trim());
                        command.Parameters.AddWithValue("@Password", txtSifre.Text.ToString().Trim());
                        SqlParameter SHOPNAME = new SqlParameter("@Shopname", SqlDbType.NVarChar, 1000) { Direction = ParameterDirection.Output };
                        SqlParameter STATUS = new SqlParameter("@status", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        SqlParameter SHOPCODE= new SqlParameter("@Shopcode",SqlDbType.NVarChar,100) { Direction = ParameterDirection.Output };
                        command.Parameters.Add(STATUS);
                        command.Parameters.Add(SHOPNAME);
                        command.Parameters.Add(SHOPCODE);
                        conn.Open();
                        command.ExecuteNonQuery();
                        checkresult = command.Parameters["@status"].Value.ToString();
                        Shopname = command.Parameters["@Shopname"].Value.ToString();
                        shopCode = command.Parameters["@Shopcode"].Value.ToString();
                        status = command.Parameters["@status"].Value.ToString();
                    } catch (SqlException ex) {
                        MessageBox.Show("Hata oluştu." + ex.ToString());
                    } finally {
                        conn.Close();
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                try {
                    SqlCommand command = new SqlCommand("s_get_username", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", txtKullaniciAdi.Text.ToString().Trim());
                    command.Parameters.AddWithValue("@Password", txtSifre.Text.ToString().Trim());
                    conn.Open();
                    UserName = command.ExecuteScalar().ToString();
                } catch (Exception) {
                    DialogResult option = new DialogResult();
                    option = MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.", "Bilinmeyen Kullanıcı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (option == DialogResult.OK) {
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                        chebxParolaGoster.Checked = false;
                    } else {
                        this.Close();
                        Application.Exit();
                    }
                    return;
                } finally {
                    conn.Close();
                }
            }
            if (checkresult == "1") {
                Zorlu_MainForm frmZorluMain = new Zorlu_MainForm();
                this.Hide();
                frmZorluMain.ShowDialog();
            } else if (checkresult == "2") {
                Magaza_MainForm frmMagazaMain = new Magaza_MainForm();
                this.Hide();
                frmMagazaMain.ShowDialog();
            } else if (checkresult == "3") {
                Tedarikci_MainForm frmTedarikciMain = new Tedarikci_MainForm();
                this.Hide();
                frmTedarikciMain.ShowDialog();
            } else {
                DialogResult option = new DialogResult();
                option = MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.", "Bilinmeyen Kullanıcı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (option == DialogResult.OK) {
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                } else {
                    this.Close();
                    Application.Exit();
                }
            }
        }

        private void KullaniciGiris_Load(object sender, EventArgs e) {
            txtSifre.UseSystemPasswordChar = true;
        }

        private void chebxParolaGoster_CheckedChanged(object sender, EventArgs e) {
            if (chebxParolaGoster.Checked) {
                txtSifre.UseSystemPasswordChar = false;
            } else {
                txtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}


