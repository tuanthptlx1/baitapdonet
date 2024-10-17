using System;
using System.Windows.Forms;

namespace bai_10_10
{
    public partial class Form1 : Form
    {
        private string input = "";       // Chuỗi để lưu số đang nhập
        private string operand1 = "";    // Số thứ nhất
        private string operand2 = "";    // Số thứ hai
        private char operation;          // Phép toán (+, -, *, /)
        private double result = 0.0;     // Kết quả tính toán

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện cho nút số 1
        private void button1_Click(object sender, EventArgs e)
        {
            input += "1"; // Thêm số 1 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 5
        private void button5_Click(object sender, EventArgs e)
        {
            input += "5"; // Thêm số 5 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 7
        private void button7_Click(object sender, EventArgs e)
        {
            input += "7"; // Thêm số 7 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 2
        private void button2_Click(object sender, EventArgs e)
        {
            input += "2"; // Thêm số 2 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 3
        private void button3_Click(object sender, EventArgs e)
        {
            input += "3"; // Thêm số 3 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 4
        private void button4_Click(object sender, EventArgs e)
        {
            input += "4"; // Thêm số 4 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 6
        private void button6_Click(object sender, EventArgs e)
        {
            input += "6"; // Thêm số 6 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 8
        private void button8_Click(object sender, EventArgs e)
        {
            input += "8"; // Thêm số 8 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 9
        private void button9_Click(object sender, EventArgs e)
        {
            input += "9"; // Thêm số 9 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút số 0
        private void button11_Click(object sender, EventArgs e)
        {
            input += "0"; // Thêm số 0 vào chuỗi input
            textBox1.Text = input; // Hiển thị chuỗi số trong TextBox
        }

        // Sự kiện cho nút C (Clear)
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Xóa nội dung TextBox
            input = string.Empty; // Đặt lại chuỗi input
            operand1 = string.Empty; // Xóa số thứ nhất
            operand2 = string.Empty; // Xóa số thứ hai
        }

        // Sự kiện cho nút "="
        private void button12_Click(object sender, EventArgs e)
        {
            operand2 = input; // Lưu số thứ hai
            double num1, num2;

            if (double.TryParse(operand1, out num1) && double.TryParse(operand2, out num2))
            {
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Không thể chia cho 0");
                        }
                        break;
                }
                textBox1.Text = result.ToString(); // Hiển thị kết quả
                input = result.ToString(); // Lưu kết quả để tiếp tục tính toán
            }
        }

        // Sự kiện cho nút "+"
        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Lấy thông tin nút phép toán
            operand1 = input; // Lưu số thứ nhất
            operation = button.Text[0]; // Lấy phép toán (dấu +)
            input = string.Empty; // Đặt lại chuỗi input để nhập số thứ hai
        }

        // Sự kiện cho nút "-"
        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Lấy thông tin nút phép toán
            operand1 = input; // Lưu số thứ nhất
            operation = button.Text[0]; // Lấy phép toán (dấu -)
            input = string.Empty; // Đặt lại chuỗi input để nhập số thứ hai
        }

        // Sự kiện cho nút "*"
        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Lấy thông tin nút phép toán
            operand1 = input; // Lưu số thứ nhất
            operation = button.Text[0]; // Lấy phép toán (dấu *)
            input = string.Empty; // Đặt lại chuỗi input để nhập số thứ hai
        }

        // Sự kiện cho nút "/"
        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // Lấy thông tin nút phép toán
            operand1 = input; // Lưu số thứ nhất
            operation = button.Text[0]; // Lấy phép toán (dấu /)
            input = string.Empty; // Đặt lại chuỗi input để nhập số thứ hai
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
