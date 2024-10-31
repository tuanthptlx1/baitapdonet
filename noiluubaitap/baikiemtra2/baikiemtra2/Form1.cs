using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace baikiemtra2
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        private List<Product> cart = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            DisplayProducts();
            SetupListView();
        }
        private void LoadProducts()
        {
            // Giả lập một danh sách sản phẩm
            products.Add(new Product { Name = "Giày Thể Thao", Price = 500000, Quantity = 10  });
            products.Add(new Product { Name = "Giày Da", Price = 700000, Quantity = 5  });
            products.Add(new Product { Name = "Dép Lê", Price = 200000, Quantity = 20  });
        }
        private void SetupListView()
        {
            // Thiết lập các cột trong ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Tên sản phẩm", 150);
            listView1.Columns.Add("Giá", 100);
            listView1.Columns.Add("Số lượng", 80);
            listView1.SmallImageList = imageList3; // Giả định bạn đã thêm ảnh vào imageList1
        }

        private void DisplayProducts()
        {
            listView1.Items.Clear();
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem();
                item.Text = product.Name;
                item.SubItems.Add(product.Price.ToString("C"));
                item.SubItems.Add(product.Quantity.ToString());
                item.ImageIndex = 0; // Giả định bạn đã thêm ảnh vào ImageList của ListView
                listView1.Items.Add(item);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                Product selectedProduct = products[index];

                if (selectedProduct.Quantity > 0)
                {
                    cart.Add(new Product { Name = selectedProduct.Name, Price = selectedProduct.Price, Quantity = 1 });
                    selectedProduct.Quantity -= 1;
                    DisplayCart();
                    DisplayProducts();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã hết hàng!");
                }
            }

        }
        private void DisplayCart()
        {
            listBox1.Items.Clear();
            decimal total = 0;
            foreach (var item in cart)
            {
                listBox1.Items.Add($"{item.Name} - {item.Price:C} x {item.Quantity}");
                total += item.Price * item.Quantity;
            }
            label3.Text = $"Tổng tiền: {total:C}";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                int index = listBox1.SelectedIndex;
                cart.RemoveAt(index);
                DisplayCart();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cart.Count > 0)
            {
                MessageBox.Show("Thanh toán thành công!");
                cart.Clear();
                DisplayCart();
            }
            else
            {
                MessageBox.Show("Giỏ hàng trống!");
            }
        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public Image Image { get; set; } // Thêm thuộc tính Image

            public override string ToString()
            {
                return $"{Name} - Giá: {Price:C} - SL: {Quantity}";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
