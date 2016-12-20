using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmMain
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            FrmChinh f = new FrmChinh();
            f.ShowDialog();
            InitializeComponent();  
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPass.Text == "123456")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
