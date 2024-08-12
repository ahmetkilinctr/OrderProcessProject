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
using System.Data.OleDb;
using System.IO;
using ZorluKartela.ExternalFiles;
using System.Transactions;

namespace ZorluKartela {
    public partial class Tedarikci_TopluSevkiyatYukleme : Form {
        public Tedarikci_TopluSevkiyatYukleme() {
            InitializeComponent();
        }
        private void btnIptal_Click(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("İşlemi iptal etmek istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) {
                this.Hide();
                label3.Visible = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e) {
            DialogResult option = MessageBox.Show("Hesabınızdan çıkış yapılacak, onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes) Application.Exit();
        }

        private void btnDosyaSec_Click(object sender, EventArgs e) {
            OpenFileDialog file = new OpenFileDialog();
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Dosya Seçiniz";
            file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK) {
                string fpath = file.FileName;
                string fname = file.SafeFileName;
                txtDosyaYolu.Text = fpath;
                lblDosyaAdi.Text = fname;
            }
        }

        private void btnYukle_Click(object sender, EventArgs e) {
            try {
                OleDbConnection OleDbconn = null;
                OleDbCommand cmd = new OleDbCommand(); ;
                OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataTable dtExcelData = new DataTable();
                string filePath = txtDosyaYolu.Text;
                string path = filePath;

                if (Path.GetExtension(path) == ".xls") {
                    OleDbconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + "; Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
                } else if (Path.GetExtension(path) == ".xlsx") {
                    OleDbconn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "; Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                }

                OleDbconn.Open();
                cmd.Connection = OleDbconn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [toplu_sevkiyat$]";
                objAdapter1 = new OleDbDataAdapter(cmd);
                objAdapter1.Fill(ds);
                dtExcelData = ds.Tables[0];

                bool orderExist = true;
                int siparisAdedi = 0;
                string tedarikciKodu = string.Empty;
                string magazaAdi = string.Empty;
                string tedarikciAdi = string.Empty;
                string kartelaAdi = string.Empty;
                string magazaKodu = string.Empty;
                int dateComparison = 0;
                string kargoNo = string.Empty;
                string irsaliyeNo = string.Empty;

                using (TransactionScope scope = new TransactionScope()) {
                    using (SqlConnection con = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                        foreach (DataRow row in dtExcelData.Rows) {
                            ExcelTransfers model = new ExcelTransfers();
                            model.ORDERID = Convert.ToInt32(row.ItemArray[0].ToString() != "NULL" ? row.ItemArray[0].ToString() : null);
                            model.SHIPPERNO = row.ItemArray[1].ToString() != "NULL" ? row.ItemArray[1].ToString() : null;
                            model.WAYBILLNO = row.ItemArray[2].ToString() != "NULL" ? row.ItemArray[2].ToString() : null;
                            model.COUNT = Convert.ToInt32(row.ItemArray[3].ToString() != "NULL" ? row.ItemArray[3].ToString() : null);
                            model.TRANSFERDATE = Convert.ToDateTime(row.ItemArray[4].ToString() != "NULL" ? row.ItemArray[4].ToString() : null);
                            model.TRANSFERHOUR = Convert.ToDateTime(row.ItemArray[5].ToString() != "NULL" ? row.ItemArray[5].ToString() : null);
                            model.TRANSFERTIME = Convert.ToDateTime((model.TRANSFERDATE.ToString("MM-dd-yyyy") + " " + model.TRANSFERHOUR.ToString("HH:mm:ss")));
                            model.INSERTDATE = Convert.ToDateTime(DateTime.Now);
                            model.ISACTIVE = Convert.ToBoolean(row.ItemArray[7].ToString() != "NULL" ? row.ItemArray[7].ToString() : null);
                            model.UPDATEDATE = Convert.ToDateTime(DateTime.Now);
                            model.ISRETURNED = Convert.ToBoolean(row.ItemArray[9].ToString() != "NULL" ? row.ItemArray[9].ToString() : null);
                            model.HASRECEIVED = Convert.ToBoolean(row.ItemArray[10].ToString() != "NULL" ? row.ItemArray[10].ToString() : null);
                            model.TEDARIKCIADI = row.ItemArray[11].ToString() != "NULL" ? row.ItemArray[11].ToString() : null;
                            model.MAGAZAADI = row.ItemArray[12].ToString() != "NULL" ? row.ItemArray[12].ToString() : null; ;
                            model.KARTELAADI = row.ItemArray[13].ToString() != "NULL" ? row.ItemArray[13].ToString() : null;
                            model.SHOPCODE = row.ItemArray[14].ToString() != "NULL" ? row.ItemArray[14].ToString() : null;
                            model.SUPPLIERCODE = row.ItemArray[15].ToString() != "NULL" ? row.ItemArray[15].ToString() : null;

                            //to get transfer values to check whether they suits order values or not
                            SqlCommand command = new SqlCommand("s_get_orders_with_id_for_transfercount_comparison", con);
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id", model.ORDERID);
                            SqlParameter ORDERCOUNT = new SqlParameter("@Count", SqlDbType.Int) { Direction = ParameterDirection.Output };
                            SqlParameter TEDARIKCIADI = new SqlParameter("@Tedarikciadi", SqlDbType.NVarChar, 1000) { Direction = ParameterDirection.Output };
                            SqlParameter MAGAZAADI = new SqlParameter("@Magazaadi", SqlDbType.NVarChar, 1000) { Direction = ParameterDirection.Output };
                            SqlParameter KARTELAADI = new SqlParameter("@Kartelaadi", SqlDbType.VarChar, 8000) { Direction = ParameterDirection.Output };
                            SqlParameter MAGAZAKODU = new SqlParameter("@Magazakodu", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                            SqlParameter TEDARIKCIKODU = new SqlParameter("@Tedarikcikodu", SqlDbType.NVarChar, 100) { Direction = ParameterDirection.Output };
                            SqlParameter SIPARISTARIHI = new SqlParameter("@Siparistarihi", SqlDbType.DateTime) { Direction = ParameterDirection.Output };
                            command.Parameters.Add(ORDERCOUNT);
                            command.Parameters.Add(TEDARIKCIADI);
                            command.Parameters.Add(MAGAZAADI);
                            command.Parameters.Add(KARTELAADI);
                            command.Parameters.Add(MAGAZAKODU);
                            command.Parameters.Add(TEDARIKCIKODU);
                            command.Parameters.Add(SIPARISTARIHI);
                            con.Open();
                            command.ExecuteNonQuery();
                            con.Close();

                            //to get transfer shipperno and waybillno to avoid adding same transfer having same shipper no and waybillno
                            SqlCommand command2 = new SqlCommand("s_get_transfer_wayno_for_comparison_in_import_totransfer", con);
                            command2.CommandType = CommandType.StoredProcedure;
                            command2.Parameters.AddWithValue("@Id", model.ORDERID);
                            SqlParameter KARGONO = new SqlParameter("@Kargono", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                            SqlParameter IRSALIYENO = new SqlParameter("@Irsaliyeno", SqlDbType.NVarChar, 250) { Direction = ParameterDirection.Output };
                            command2.Parameters.Add(KARGONO);
                            command2.Parameters.Add(IRSALIYENO);
                            con.Open();
                            command2.ExecuteNonQuery();
                            con.Close();

                            if (!string.IsNullOrEmpty(ORDERCOUNT.Value.ToString())) {
                                siparisAdedi = Convert.ToInt32(ORDERCOUNT.SqlValue.ToString());
                                magazaAdi = MAGAZAADI.SqlValue.ToString();
                                tedarikciAdi = TEDARIKCIADI.SqlValue.ToString();
                                kartelaAdi = KARTELAADI.SqlValue.ToString();
                                magazaKodu = MAGAZAKODU.SqlValue.ToString();
                                tedarikciKodu = TEDARIKCIKODU.SqlValue.ToString();
                                kargoNo = KARGONO.SqlValue.ToString();
                                irsaliyeNo = IRSALIYENO.SqlValue.ToString();
                                dateComparison = DateTime.Compare(model.TRANSFERTIME, DateTime.Parse(SIPARISTARIHI.Value.ToString()));
                                if (model.MAGAZAADI == magazaAdi || model.TEDARIKCIADI == tedarikciAdi || model.KARTELAADI == kartelaAdi || model.SHOPCODE == magazaKodu || model.SUPPLIERCODE == tedarikciKodu) {
                                    if (model.COUNT > siparisAdedi || dateComparison >= 1 || model.SHIPPERNO == kargoNo || model.WAYBILLNO==irsaliyeNo ) {
                                        txtDosyaYolu.Clear();
                                        orderExist = false;
                                    } else {
                                        SqlCommand cmdSQL = new SqlCommand();
                                        cmdSQL.Connection = con;
                                        cmdSQL.CommandType = CommandType.Text;
                                        cmdSQL.CommandText = "INSERT INTO TRANSFERS VALUES(@ORDERID,@SHIPPERNO,@WAYBILLNO,@COUNT,@TRANSFERDATE,@INSERTDATE,@ISACTIVE,@UPDATEDATE,@ISRETURNED,@HASRECEIVED,@TEDARIKCIADI,@MAGAZAADI,@KARTELAADI,@SHOPCODE,@SUPPLIERCODE)";
                                        cmdSQL.Parameters.AddWithValue("@ORDERID", model.ORDERID);
                                        cmdSQL.Parameters.AddWithValue("@SHIPPERNO", model.SHIPPERNO);
                                        cmdSQL.Parameters.AddWithValue("@WAYBILLNO", model.WAYBILLNO);
                                        cmdSQL.Parameters.AddWithValue("@COUNT", model.COUNT);
                                        cmdSQL.Parameters.AddWithValue("@TRANSFERDATE", model.TRANSFERTIME);
                                        cmdSQL.Parameters.AddWithValue("@INSERTDATE", model.INSERTDATE);
                                        cmdSQL.Parameters.AddWithValue("@ISACTIVE", model.ISACTIVE);
                                        cmdSQL.Parameters.AddWithValue("@UPDATEDATE", model.UPDATEDATE);
                                        cmdSQL.Parameters.AddWithValue("@ISRETURNED", model.ISRETURNED);
                                        cmdSQL.Parameters.AddWithValue("@HASRECEIVED", model.HASRECEIVED);
                                        cmdSQL.Parameters.AddWithValue("@TEDARIKCIADI", model.TEDARIKCIADI);
                                        cmdSQL.Parameters.AddWithValue("@MAGAZAADI", model.MAGAZAADI);
                                        cmdSQL.Parameters.AddWithValue("@KARTELAADI", model.KARTELAADI);
                                        cmdSQL.Parameters.AddWithValue("@SHOPCODE", model.SHOPCODE);
                                        cmdSQL.Parameters.AddWithValue("@SUPPLIERCODE", model.SUPPLIERCODE);
                                        con.Open();
                                        cmdSQL.ExecuteNonQuery();
                                        con.Close();
                                    }
                                } else {
                                    txtDosyaYolu.Clear();
                                    orderExist = false;
                                }
                            } else {
                                orderExist = false;
                            }
                        }
                        DialogResult option2 = new DialogResult();
                        if (orderExist) {
                            option2 = MessageBox.Show("Toplu sevkiyat yükleme işlemi başarıyla gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            option2 = MessageBox.Show("Yüklenmeye çalışılan dosya üzerinde herhangibir siparişe ait olmayan sevkiyat bulunuyor ya da bilgiler uyuşmuyor olabilir. Lütfen ilgili dosyayı kontrol ediniz.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtDosyaYolu.Clear();
                        lblDosyaAdi.Text = "";
                    }
                    if (orderExist)
                        scope.Complete();
                    else
                        scope.Dispose();
                }
            } catch (Exception ex) {
                MessageBox.Show("Hata oluştu: " + ex.ToString());
            }
        }

        private void Tedarikci_TopluSevkiyatYukleme_Load(object sender, EventArgs e) {
            label4.Text = KullaniciGiris.Shopname;
        }
    }
}
