namespace baitap20_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("MaSinhVien", "Mã Sinh Viên");
            dataGridView1.Columns.Add("Ten", "Tên");
            dataGridView1.Columns.Add("Lop", "Lớp");
           

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để xóa.");
                return;
            }

            // Kiểm tra xem có sản phẩm nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Xác nhận việc xóa sản phẩm
                DialogResult confirmResult = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Xóa hàng được chọn
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    clearInputFields();  // Làm mới các trường nhập liệu sau khi xóa
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

            clearInputFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Cập nhật thông tin sản phẩm
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[0].Value = textBox1.Text;
                selectedRow.Cells[1].Value = textBox2.Text;
                selectedRow.Cells[2].Value = textBox3.Text;


                clearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value?.ToString() ?? "";
                textBox2.Text = row.Cells[1].Value?.ToString() ?? "";
                textBox3.Text = row.Cells[2].Value?.ToString() ?? "";
             
            }
        }
        private void clearInputFields()
        {
            // Làm mới các trường nhập liệu
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//noi nhap timkiem
        {

        }

        private void button5_Click(object sender, EventArgs e)//nut timkiem
        {
            
        }
    }
}
