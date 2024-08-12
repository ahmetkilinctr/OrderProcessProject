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
using ZorluKartela.Models;

namespace ZorluKartela {
    public partial class Zorlu_TopluSiparisYukleme : Form {
        public Zorlu_TopluSiparisYukleme() {
            InitializeComponent();
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
                cmd.CommandText = "SELECT * FROM [toplu_siparis$]";
                objAdapter1 = new OleDbDataAdapter(cmd);
                objAdapter1.Fill(ds);
                dtExcelData = ds.Tables[0];
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.CONN_STR)) {
                    foreach (DataRow row in dtExcelData.Rows) {

                        ExcelOrders model = new ExcelOrders();
                        model.KARTELAID = Convert.ToInt32(row.ItemArray[0].ToString() != "NULL" ? row.ItemArray[0].ToString() : null);
                        model.SUPPLIERNAME = row.ItemArray[1].ToString() != "NULL" ? row.ItemArray[1].ToString() : null;
                        model.SHOPNAME = row.ItemArray[2].ToString() != "NULL" ? row.ItemArray[2].ToString() : null;
                        model.COUNT = Convert.ToInt32(row.ItemArray[3].ToString() != "NULL" ? row.ItemArray[3].ToString() : null);
                        model.INSERTDATE = Convert.ToDateTime(DateTime.Now);
                        model.ISACTIVE = Convert.ToBoolean(row.ItemArray[5].ToString() != "NULL" ? row.ItemArray[5].ToString() : null);
                        model.UPDATEDATE = Convert.ToDateTime(DateTime.Now);
                        model.REMAINCOUNT = Convert.ToInt32(row.ItemArray[7].ToString());
                        model.ORDERSTATE = Convert.ToInt32(row.ItemArray[8].ToString() != "NULL" ? row.ItemArray[8].ToString() : null);
                        model.SHOPID = Convert.ToInt32(row.ItemArray[9].ToString() != "NULL" ? row.ItemArray[9].ToString() : null);
                        model.SUPPLIERID = Convert.ToInt32(row.ItemArray[10].ToString() != "NULL" ? row.ItemArray[10].ToString() : null);
                        model.ORDERHOUR = Convert.ToDateTime(row.ItemArray[12].ToString() != "NULL" ? row.ItemArray[12].ToString() : null);
                        model.ORDERDATE = Convert.ToDateTime(row.ItemArray[11].ToString() != "NULL" ? row.ItemArray[11].ToString() : null);
                        model.ORDERTIME = Convert.ToDateTime((model.ORDERDATE.ToString("MM-dd-yyyy") + " " + model.ORDERHOUR.ToString("HH:mm:ss")));
                        model.MAGAZAADI = row.ItemArray[2].ToString() != "NULL" ? row.ItemArray[2].ToString() : null;
                        model.TEDARIKCIADI = row.ItemArray[14].ToString() != "NULL" ? row.ItemArray[14].ToString() : null;
                        model.URUNADI = row.ItemArray[18].ToString() != "NULL" ? row.ItemArray[18].ToString() : null;
                        model.URUNKODU = "NULL";
                        model.URUNGRUBU = "NULL";
                        model.KARTELADI = row.ItemArray[18].ToString() != "NULL" ? row.ItemArray[18].ToString() : null;
                        model.SHOPCODE = row.ItemArray[19].ToString() != "NULL" ? row.ItemArray[19].ToString() : null;
                        model.SUPPLIERCODE = row.ItemArray[20].ToString() != "NULL" ? row.ItemArray[20].ToString() : null;

                        SqlCommand cmdSQL = new SqlCommand();
                        cmdSQL.Connection = con;
                        cmdSQL.CommandType = CommandType.Text;
                        cmdSQL.CommandText = "INSERT INTO ORDERS VALUES(@KARTELAID,@SUPPLIERNAME,@SHOPNAME,@COUNT,@INSERTDATE,@ISACTIVE,@UPDATEDATE,@REMAINCOUNT,@ORDERSTATE,@SHOPID,@SUPPLIERID,@OrderDate,@MAGAZAADI,@TEDARIKCIADI,@URUNADI,@URUNKODU,@URUNGRUBU,@KARTELAADI,@SHOPCODE,@SUPPLIERCODE)";
                        cmdSQL.Parameters.AddWithValue("@KARTELAID", model.KARTELAID);
                        cmdSQL.Parameters.AddWithValue("@SUPPLIERNAME", model.SUPPLIERNAME);
                        cmdSQL.Parameters.AddWithValue("@SHOPNAME", model.SHOPNAME);
                        cmdSQL.Parameters.AddWithValue("@COUNT", model.COUNT);
                        cmdSQL.Parameters.AddWithValue("@INSERTDATE", model.INSERTDATE);
                        cmdSQL.Parameters.AddWithValue("@ISACTIVE", model.ISACTIVE);
                        cmdSQL.Parameters.AddWithValue("@UPDATEDATE", model.UPDATEDATE);
                        cmdSQL.Parameters.AddWithValue("@REMAINCOUNT", model.COUNT);
                        cmdSQL.Parameters.AddWithValue("@ORDERSTATE", model.ORDERSTATE);
                        cmdSQL.Parameters.AddWithValue("@SHOPID", model.SHOPID);
                        cmdSQL.Parameters.AddWithValue("@SUPPLIERID", model.SUPPLIERID);
                        cmdSQL.Parameters.AddWithValue("@OrderDate", model.ORDERTIME);
                        cmdSQL.Parameters.AddWithValue("@MAGAZAADI", model.MAGAZAADI);
                        cmdSQL.Parameters.AddWithValue("@TEDARIKCIADI", model.TEDARIKCIADI);
                        cmdSQL.Parameters.AddWithValue("@URUNADI", model.URUNADI);
                        cmdSQL.Parameters.AddWithValue("@URUNKODU", model.URUNKODU);
                        cmdSQL.Parameters.AddWithValue("@URUNGRUBU", model.URUNGRUBU);
                        cmdSQL.Parameters.AddWithValue("@KARTELAADI", model.KARTELADI);
                        cmdSQL.Parameters.AddWithValue("@SHOPCODE", model.SHOPCODE);
                        cmdSQL.Parameters.AddWithValue("@SUPPLIERCODE", model.SUPPLIERCODE);
                        con.Open();
                        cmdSQL.ExecuteNonQuery();
                        con.Close();
                        DialogResult option = MessageBox.Show("Toplu sipariş yükleme işlemi başarıyla gerçekleştirildi.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Hata oluştu" + ex.ToString());
            }
        }

        private void Zorlu_TopluSiparisYukleme_Load(object sender, EventArgs e) {
            label4.Text = KullaniciGiris.Shopname;
        }
    }
}
