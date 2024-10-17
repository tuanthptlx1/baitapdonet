using System.Text.RegularExpressions;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nhappass.PasswordChar = '*';
        }

        private void nhapuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhapemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhappass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nhapuser.Text;
            string email = nhapemail.Text;
            string password = nhappass.Text;

            // Kiểm tra dữ liệu có hợp lệ không (ví dụ đơn giản)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng email hợp lệ
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập lại email.", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Mẫu regex để kiểm tra mật khẩu hợp lệ (tối thiểu 8 ký tự, bao gồm ít nhất 1 ký tự đặc biệt)
            string pattern = @"^(?=.*[!@#$%^&*(),.?""{}|<>])[A-Za-z\d!@#$%^&*(),.?""{}|<>]{8,}$";

            // Kiểm tra mật khẩu với regex
            if (!Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Yêu cầu tối thiểu 8 ký tự và phải bao gồm ít nhất 1 ký tự đặc biệt.", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!dongydieukhoan.Checked)
            {
                MessageBox.Show("Bạn phải đồng ý với các điều khoản trước khi đăng ký.");
                return;
            }

            // Thực hiện đăng ký (tùy vào yêu cầu bạn có thể lưu vào cơ sở dữ liệu hoặc xử lý khác)
            MessageBox.Show("Đăng ký thành công!\n" + "Tên: " + username + "\nEmail: " + email + "\nPassword:" + password);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (anhien.Checked)
            {
                // Nếu CheckBox được tích, hiện mật khẩu
                nhappass.PasswordChar = '\0'; // '\0' là ký tự null, sẽ hiện tất cả ký tự
            }
            else
            {
                // Nếu CheckBox không được tích, ẩn mật khẩu
                nhappass.PasswordChar = '*'; // Dấu '*' để ẩn mật khẩu
            }
        }
    }

}
