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

namespace QuanLyDoanHoi
{
    public partial class Frm_SinhVien_Update : Form
    {
        SqlConnection cn;
        string cnStr;
        DataSet ds;
        DataTable SinhVien;
        public Frm_SinhVien_Update()
        {
            InitializeComponent();
        }

        private void Frm_SinhVien_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QLyDoanHoi; Integrated security = true";
            cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM SINHVIEN";
            dataGridView1.DataSource = GetCustomerDataset(sql).Tables[0];

            txt_ID.DataBindings.Add("Text", SinhVien, "MSSV");
            txt_HoSV.DataBindings.Add("Text", SinhVien, "HoSV");
            txt_TenSV.DataBindings.Add("Text", SinhVien, "TenSV");
            txt_Class.DataBindings.Add("Text", SinhVien, "MaChiDoan");

            dataGridView1.DataSource = GetCustomerDataset("SELECT * FROM SinhVien").Tables[0];
        }
        public DataSet GetCustomerDataset(string sql)
        {
            try
            {
               SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable db = new DataTable();
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
       
       
    }
}
