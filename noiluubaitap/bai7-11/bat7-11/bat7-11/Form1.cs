using SimThe;
using System.Data;

namespace SimThe;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    KetNoi kn = new KetNoi();

    private void Form1_Load(object sender, EventArgs e)
    {
        if (kn.KiemTraKetNoi())
        {
            getData();
            getMangData();
        }
        else
        {
            MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu.");
        }
    }


    // Hiển thị dữ liệu lên DataGridView từ bảng Sim
    public void getData()
    {
        string query = "SELECT * FROM Sim";  // Lấy toàn bộ dữ liệu từ bảng Sim
        DataSet ds = kn.LayDuLieu(query);

        if (ds != null && ds.Tables.Count > 0)
        {
            dgvSim.DataSource = ds.Tables[0];  // Gán dữ liệu vào DataGridView (dgvSim)

            // Cài đặt tên cột cho DataGridView tương ứng với cấu trúc bảng Sim
            dgvSim.Columns["ID"].HeaderText = "Mã Sim";
            dgvSim.Columns["SoSim"].HeaderText = "Số Sim";
            dgvSim.Columns["MangID"].HeaderText = "Mã Mạng";
            dgvSim.Columns["NgayKichHoat"].HeaderText = "Ngày Kích Hoạt";
            dgvSim.Columns["NgayHetHan"].HeaderText = "Ngày Hết Hạn";
        }
        else
        {
            MessageBox.Show("Không có dữ liệu từ bảng Sim để hiển thị.");
        }
    }

    // Hiển thị dữ liệu lên DataGridView từ bảng Mang
    public void getMangData()
    {
        string query = "SELECT * FROM Mang";  // Lấy toàn bộ dữ liệu từ bảng Mang
        DataSet ds = kn.LayDuLieu(query);

        if (ds != null && ds.Tables.Count > 0)
        {
            dgvMang.DataSource = ds.Tables[0];  // Gán dữ liệu vào DataGridView (dgvMang)

            // Cài đặt tên cột cho DataGridView tương ứng với cấu trúc bảng Mang
            dgvMang.Columns["ID"].HeaderText = "Mã Mạng";
            dgvMang.Columns["TenMang"].HeaderText = "Tên Mạng";
        }
        else
        {
            MessageBox.Show("Không có dữ liệu từ bảng Mang để hiển thị.");
        }
    }
    private void cmbSim_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void dgvMang_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)//nut lod du lieu
    {

    }
}

