using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5_11
{
    public partial class Customer : Form
    {
        public string TenKhachHang
        {
            get => textBox1.Text; // textBox1 là TextBox nhập tên khách hàng
            set => textBox1.Text = value;
        }

        public string SoDienThoai
        {
            get => textBox2.Text; // textBox2 là TextBox nhập số điện thoại
            set => textBox2.Text = value;
        }

        public string DiaChi
        {
            get => textBox3.Text; // textBox3 là TextBox nhập địa chỉ
            set => textBox3.Text = value;
        }
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//nhap tenkhach
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//nhap tensdt
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//nhap diachi
        {

        }
    }
}
