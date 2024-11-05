using System.ComponentModel;

namespace bai5_11
{
    public partial class Form1 : Form
    {
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        private List<DichVu> danhSachDichVu = new List<DichVu>();
        private List<DichVu> dichVuDaChon = new List<DichVu>(); // Danh sách dịch vụ đã chọn
        private int maKhachHangCounter = 1; // Mã tự tăng cho khách hàng
        //public Label lblTenKhachHang { get; set; }


        public Form1()
        {
            InitializeComponent();
            InitializeServices();
            CapNhatDanhSachKhachHang();
            CapNhatDanhSachDichVu();

        }
        public class KhachHang
        {
            public int MaKhachHang { get; set; }
            public string TenKhachHang { get; set; }
            public string SoDienThoai { get; set; }
            public string DiaChi { get; set; }
        }

        public class DichVu
        {
            public int MaDichVu { get; set; }
            public string TenDichVu { get; set; }
            public decimal GiaTien { get; set; }
        }
        private void InitializeServices()
        {
            danhSachDichVu.Add(new DichVu { MaDichVu = 1, TenDichVu = "Gội đầu", GiaTien = 100000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 2, TenDichVu = "Massage", GiaTien = 200000 });

            danhSachDichVu.Add(new DichVu { MaDichVu = 3, TenDichVu = "Cắt tóc", GiaTien = 100000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 4, TenDichVu = "VIP", GiaTien = 1000000 });
            // Thêm dịch vụ khác nếu cần
        }

        // Cập nhật danh sách khách hàng trong DataGridView
        private void CapNhatDanhSachKhachHang()
        {
            dataGridView1.DataSource = null; // Xóa nguồn dữ liệu cũ
            dataGridView1.DataSource = new BindingList<KhachHang>(danhSachKhachHang); // Sử dụng BindingList để cập nhật
        }
        private void CapNhatDanhSachDichVu()
        {
            dataGridView2.DataSource = null; // Xóa nguồn dữ liệu cũ
            dataGridView2.DataSource = new BindingList<DichVu>(danhSachDichVu); // Sử dụng BindingList để cập nhật
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//bang thong tin khach hang
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//bang dich vu da chon
        {

        }

        private void button1_Click(object sender, EventArgs e)//them
        {
            Customer customerForm = new Customer();
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                // Tạo khách hàng mới từ dữ liệu nhập
                KhachHang khachHangMoi = new KhachHang
                {
                    MaKhachHang = maKhachHangCounter++, // Tăng mã khách hàng
                    TenKhachHang = customerForm.TenKhachHang,
                    SoDienThoai = customerForm.SoDienThoai,
                    DiaChi = customerForm.DiaChi
                };

                danhSachKhachHang.Add(khachHangMoi);
                CapNhatDanhSachKhachHang(); // Cập nhật lại danh sách
            }
        }

        private void button2_Click(object sender, EventArgs e)//sua
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index; // Lấy chỉ số khách hàng được chọn
                KhachHang khachHang = danhSachKhachHang[index];

                Customer customerForm = new Customer
                {
                    TenKhachHang = khachHang.TenKhachHang,
                    SoDienThoai = khachHang.SoDienThoai,
                    DiaChi = khachHang.DiaChi
                };

                if (customerForm.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật lại thông tin khách hàng
                    khachHang.TenKhachHang = customerForm.TenKhachHang;
                    khachHang.SoDienThoai = customerForm.SoDienThoai;
                    khachHang.DiaChi = customerForm.DiaChi;

                    CapNhatDanhSachKhachHang(); // Cập nhật lại danh sách
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)//xoa
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index; // Lấy chỉ số khách hàng được chọn
                danhSachKhachHang.RemoveAt(index); // Xóa khách hàng khỏi danh sách
                CapNhatDanhSachKhachHang(); // Cập nhật lại danh sách
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)//tao hoa don
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra xem có hàng nào được chọn không
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index; // Lấy chỉ số hàng được chọn
                KhachHang khachHang = danhSachKhachHang[selectedIndex]; // Lấy thông tin khách hàng

             
                // Tạo hóa đơn
                decimal total = 0;
                listBox1.Items.Clear(); // Xóa danh sách dịch vụ đã chọn

                foreach (DichVu dichVu in dichVuDaChon)
                {
                    total += dichVu.GiaTien; // Cộng dồn giá dịch vụ
                    listBox1.Items.Add(dichVu.TenDichVu); // Thêm tên dịch vụ vào ListBox
                }

                // Hiển thị tổng tiền
                label1.Text = $"Tổng Tiền: {total:C}"; // Hiển thị tổng tiền
                MessageBox.Show($"Tên Khách Hàng: {khachHang.TenKhachHang}\nTổng Tiền: {total:C}",
                       "Thông Tin Hóa Đơn",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để tạo hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//bang dich vu
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var dichVuChon = (DichVu)dataGridView2.SelectedRows[0].DataBoundItem;

                if (!dichVuDaChon.Contains(dichVuChon))
                {
                    dichVuDaChon.Add(dichVuChon);
                    listBox1.Items.Add(dichVuChon.TenDichVu); // Thêm tên dịch vụ vào ListBox
                }
                else
                {
                    MessageBox.Show("Dịch vụ đã được chọn trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
