using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QUAN_LI_QUAN_CAPHE
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_QuenMatKhau quenmk = new Form_QuenMatKhau();
            quenmk.ShowDialog();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            
                Form_QuanLiTrangChu a = new Form_QuanLiTrangChu();
                this.Hide();
                a.Show();
                //this.Show();
            
        }

        private void Form_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon dong phan mem?", "Thong bao", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
