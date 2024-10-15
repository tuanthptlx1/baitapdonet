namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//nhap mo ta chi tiet
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Loại 1");
            comboBox1.Items.Add("Loại 2");
            comboBox1.Items.Add("Loại 3");

            // Đặt mục mặc định là không chọn
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.Columns.Add("MaSP", "Mã SP");
            dataGridView1.Columns.Add("Ten", "Tên");
            dataGridView1.Columns.Add("DonGia", "Đơn Giá");
            dataGridView1.Columns.Add("HinhAnh", "Hình Ảnh");
            dataGridView1.Columns.Add("MoTaNgan", "Mô Tả Ngắn");
            dataGridView1.Columns.Add("MoTaChiTiet", "Mô Tả Chi Tiết");
            dataGridView1.Columns.Add("LoaiSP", "Loại SP");
        }

        private void button3_Click(object sender, EventArgs e)//sua
        {
       
                // Kiểm tra xem có sản phẩm nào được chọn không
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Cập nhật thông tin sản phẩm
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    selectedRow.Cells[0].Value = textBox1.Text;
                    selectedRow.Cells[1].Value = textBox2.Text;
                    selectedRow.Cells[2].Value = textBox3.Text;
                    selectedRow.Cells[3].Value = comboBox1.Text;
                    selectedRow.Cells[4].Value = textBox4.Text;
                    selectedRow.Cells[5].Value = textBox5.Text;
                    selectedRow.Cells[6].Value = textBox6.Text;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.");
                }
        

        }

        private void button4_Click(object sender, EventArgs e)//xoa
        {
                // Kiểm tra xem có sản phẩm nào được chọn không
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//nhap du lieu tim kiem
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)//nhap ma sp
        {

        }

        private void button1_Click(object sender, EventArgs e)//lam moi
        {
            
                // Làm mới các trường nhập liệu
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                comboBox1.SelectedIndex = -1;
         

        }

        private void button2_Click(object sender, EventArgs e)//them
        {

          
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                    return;
                }

                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text);


        }

        private void button5_Click(object sender, EventArgs e)//timkiem
        {
            // Lấy từ khóa tìm kiếm từ ô nhập liệu
            string keyword = textBox7.Text.Trim().ToLower(); // textBox7 là nơi bạn nhập từ khóa

            bool found = false; // Biến để theo dõi xem có tìm thấy kết quả hay không

            // Kiểm tra xem từ khóa tìm kiếm có rỗng không
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.");
                return;
            }

            // Duyệt qua tất cả các hàng trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra ô Mã SP và Tên sản phẩm có hợp lệ và có chứa từ khóa không
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains(keyword) ||
                    row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(keyword))
                {
                    // Nếu tìm thấy, chọn hàng đó và đánh dấu tìm thấy
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    // Nếu không khớp, bỏ chọn hàng đó
                    row.Selected = false;
                }
            }

            // Nếu không tìm thấy kết quả, thông báo cho người dùng
            if (!found)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào khớp với từ khóa.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//hien thi du lieu
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    comboBox1.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    textBox6.Text = row.Cells[6].Value.ToString();
                }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//nhap ten sp
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//don gia
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//nhap ten hinh anh
        {

                // Kiểm tra định dạng file hình ảnh
                //if (!textBox4.Text.EndsWith(".jpg") && !textBox4.Text.EndsWith(".png"))
                //{
                //    MessageBox.Show("Tên file hình ảnh phải có định dạng .jpg hoặc .png");
                //}
       

        }

        private void textBox5_TextChanged(object sender, EventArgs e)// nhap mo ta ngan
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)//list loai san pham
        {
            //// Khởi tạo ComboBox cho Loại SP (có thể thêm nhiều loại hơn)
            //comboBox1.Items.Add("Loại 1");
            //comboBox1.Items.Add("Loại 2");
            //comboBox1.Items.Add("Loại 3");
        }
    }
}
