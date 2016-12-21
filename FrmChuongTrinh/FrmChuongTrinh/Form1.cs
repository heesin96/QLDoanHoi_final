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
using System.Configuration;

namespace FrmChuongTrinh
{
    public partial class FrmChuongTrinh : Form
    {
        SqlConnection cn;
        string cnStr;
        DataSet ds;
        DataTable ChuongTrinh;

        public FrmChuongTrinh()
        {
            InitializeComponent();
        }

        private void FrmChuongTrinh_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = QLyDoanHoi; Integrated security = true";
            cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM ChuongTrinh";
            dgvChuongTrinh.DataSource = GetChuongTrinhDataset().Tables[0];

        }

        public DataSet GetChuongTrinhDataset()
        {
            try
            {
                string sql = " SELECT * FROM ChuongTrinh";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cn.Close();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            //insert
            string ins = "INSERT INTO ChuongTrinh (MaChuongTrinh,TenCT,CapDoCT,ThoiGianBD) VALUES (@MaCT,@Ten,@CapDo,@ThoiGian)";
            SqlCommand cmd = new SqlCommand(ins, cn);
            cmd.Parameters.Add("@MaCT", SqlDbType.NChar, 10, "MaChuongTrinh");
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "TenCT");
            cmd.Parameters.Add("@CapDo", SqlDbType.NVarChar, 50, "CapDoCT");
            cmd.Parameters.Add("@ThoiGian", SqlDbType.NVarChar, 50, "ThoiGianBD");
            da.InsertCommand = cmd;

            //delete
            string del = "DELETE FROM ChuongTrinh WHERE MaChuongTrinh = @MaCT";
            SqlCommand cmd1 = new SqlCommand(del, cn);
            cmd1.Parameters.Add("@MaCT", SqlDbType.NChar, 10, "MaChuongTrinh");
            da.DeleteCommand = cmd1;

            //update
            string upd = "UPDATE ChuongTrinh SET TenCT = @Ten,CapDoCT = @CapDo,ThoiGianBD = @ThoiGian WHERE MaChuongTrinh = @MaCT";
            SqlCommand cmd2 = new SqlCommand(upd, cn);
            cmd2.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "TenCT");
            cmd2.Parameters.Add("@CapDo", SqlDbType.NVarChar, 50, "CapDoCT");
            cmd2.Parameters.Add("@ThoiGian", SqlDbType.NVarChar, 50, "ThoiGianBD");
            da.UpdateCommand = cmd2;


            da.Update(ds);
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }


        

    }
}
