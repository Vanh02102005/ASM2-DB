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
using System.IO;
using System.Xml.Linq;
namespace asm1_db
{
    public partial class Product_Management : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtProductId;
        private object txtSearch;

        public Product_Management()
        {
            InitializeComponent();
        }
        private void Product_Management_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            if (!gvProduct.Columns.Contains("ImageColumn"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.Name = "ImageColumn";
                imgColumn.HeaderText = "Product Image";
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                gvProduct.Columns.Add(imgColumn);
            }
        }


        private void LoadProductData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Book", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvProduct.DataSource = dt;
                    if (!gvProduct.Columns.Contains("ImageColumn"))
                    {
                        DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                        imgColumn.Name = "ImageColumn";
                        imgColumn.HeaderText = "Book Image";
                        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        gvProduct.Columns.Add(imgColumn);
                    }
                    foreach (DataGridViewRow row in gvProduct.Rows)
                    {
                        string imgPath = row.Cells["BookPhoto"].Value?.ToString();
                        if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                        {
                            row.Cells["ImageColumn"].Value = Image.FromFile(imgPath);
                        }
                        else
                        {
                            row.Cells["ImageColumn"].Value = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Book (BookID, BookName, BookPrice, BookDescription, BookQuantity, BookPhoto) VALUES (@ID, @Name, @Price, @Description, @Quantity, @Photo)", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                        cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Description", txtProductDescription.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txtProductQuantity.Text);
                        cmd.Parameters.AddWithValue("@Photo", txtImagePath.Text);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Product added successfully!");
                    txtProductID.Text = "";
                    txtProductPrice.Text = "";
                    txtProductName.Text = "";
                    txtProductDescription.Text = "";
                    txtProductQuantity.Text = "";
                    txtImagePath.Text = "";
                    LoadProductData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Book SET BookDescription=@Description,BookQuantity=@Quantity, BookName=@Name, BookPrice=@Price, BookPhoto=@Photo WHERE BookID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                        cmd.Parameters.AddWithValue("Description", txtProductDescription.Text);
                        cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtProductQuantity.Text));
                        cmd.Parameters.AddWithValue("@Photo", txtImagePath.Text);

                     int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated product information successfully!");
                            txtProductID.Text = "";
                            txtProductName.Text = "";
                            txtProductPrice.Text = "";
                            txtProductDescription.Text = "";
                            txtProductQuantity.Text = "";
                            LoadProductData();
                        }
                        else
                        {
                            MessageBox.Show("No products found with this ID.");
                        }
                    }
                    LoadProductData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Book WHERE BookID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtProductID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product deleted successfully!");
                    LoadProductData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Book WHERE BookName LIKE @SearchTerm OR CAST(BookID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtProductID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvProduct.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                    pbProductImage.Image = Image.FromFile(ofd.FileName); 
                    if (gvProduct.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = gvProduct.SelectedRows[0];
                        selectedRow.Cells["ProductImage"].Value = txtImagePath.Text;  
                        selectedRow.Cells["ImageColumn"].Value = Image.FromFile(ofd.FileName);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void gvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                string imgPath = txtImagePath.Text;
                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                {
                    pbProductImage.Image = Image.FromFile(imgPath);
                }
                else
                {
                    pbProductImage.Image = null;
                    MessageBox.Show("Image not found at the specified path.");
                }
            }
        }
    }
}
