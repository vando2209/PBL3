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

namespace QUAN_LI_QUAN_CAPHE
{
    public partial class Form_MatHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=HUMITO\\PHUONGSUGA;Initial Catalog=qlQuanCaFe;Persist Security Info=True;User ID=sa;Password=***********;Encrypt=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadDataSanPham()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from SanPham";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView_MatHang.DataSource = table;
        }
        public Form_MatHang()
        {
            InitializeComponent();
        }

        private void btnmamathang_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemmh_Click(object sender, EventArgs e)
        {

        }

        private void Danh_Click(object sender, EventArgs e)
        {

        }

        private void Form_MatHang_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loadDataSanPham();
        }
        
    }
}
