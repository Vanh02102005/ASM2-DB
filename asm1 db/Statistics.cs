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
namespace asm1_db
{
    public partial class Statistics : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtOrderId;
        private object txtSearch;
        public Statistics()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tbQuantity_Click(object sender, EventArgs e)
        {

        }
        private void LoadStatisticsData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM DetailedOrders", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvSatistics.DataSource = dt;
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
                    using (SqlCommand checkOrderCmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE OrderID = @OrderID", con))
                    {                     
                        checkOrderCmd.Parameters.AddWithValue("@OrderID", txtID.Text);
                        int orderExists = (int)checkOrderCmd.ExecuteScalar();
                        if (orderExists == 0)
                        {
                            MessageBox.Show("Order ID does not exist.");
                            return;
                        }
                    }
                    using (SqlCommand checkBookCmd = new SqlCommand("SELECT COUNT(*) FROM Book WHERE BookID = @BookID", con))
                    {
                        checkBookCmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        int bookExists = (int)checkBookCmd.ExecuteScalar();
                        if (bookExists == 0)
                        {
                            MessageBox.Show("Book ID does not exist.");
                            return;
                        }
                    }
                    int quantity = int.Parse(txtQuantity.Text);
                    decimal price = decimal.Parse(txtPrice.Text);

                    if (quantity <= 0)
                    {
                        MessageBox.Show("The number of books must be greater than 0.");
                        return;
                    }

                    if (price < 0)
                    {
                        MessageBox.Show("The price of the book must be greater than 0.");
                        return;
                    }
                    using (SqlCommand checkStockCmd = new SqlCommand("SELECT BookQuantity FROM Book WHERE BookID = @BookID", con))
                    {
                        checkStockCmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        int availableQuantity = (int)checkStockCmd.ExecuteScalar();

                        if (quantity > availableQuantity)
                        {
                            MessageBox.Show($"The entered quantity exceeds the remaining quantity. Currently available {availableQuantity} products in stock.");
                            return;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO DetailedOrders (OrderID, BookID, Quantity, Date, Price) VALUES (@OrderID, @BookID, @Quantity, @Date, @Price)", con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", txtID.Text);
                        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                        cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                        cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand updateStockCmd = new SqlCommand("UPDATE Book SET BookQuantity = BookQuantity - @Quantity WHERE BookID = @BookID", con))
                    {
                        updateStockCmd.Parameters.AddWithValue("@Quantity", quantity);
                        updateStockCmd.Parameters.AddWithValue("@BookID", txtBookID.Text);

                        updateStockCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order details added successfully!");
                    txtID.Text = "";
                    txtBookID.Text = "";
                    txtQuantity.Text = "";
                    txtDate.Text = "";
                    txtPrice.Text = "";
                    LoadStatisticsData();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid input format: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    int quantity = int.Parse(txtQuantity.Text);
                    decimal price = decimal.Parse(txtPrice.Text);
                    using (SqlCommand checkExistsCmd = new SqlCommand("SELECT COUNT(*) FROM DetailedOrders WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        checkExistsCmd.Parameters.AddWithValue("@OrderID", txtID.Text);
                        checkExistsCmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        int exists = (int)checkExistsCmd.ExecuteScalar();
                        if (exists == 0)
                        {
                            MessageBox.Show("Order details do not exist.");
                            return;
                        }
                    }                
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Product quantity must be greater than 0.");
                        return;
                    }

                    if (price < 0)
                    {
                        MessageBox.Show("The price of the book must be greater than 0.");
                        return;
                    }
                    using (SqlCommand checkStockCmd = new SqlCommand("SELECT BookQuantity FROM Book WHERE BookID = @BookID", con))
                    {
                        checkStockCmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        int availableQuantity = (int)checkStockCmd.ExecuteScalar();
                        if (quantity > availableQuantity)
                        {
                            MessageBox.Show($"The entered quantity exceeds the remaining quantity. Currently available {availableQuantity} products in stock.");
                            return;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("UPDATE DetailedOrders SET Quantity = @Quantity, Date = @Date, Price = @Price WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                        cmd.Parameters.AddWithValue("@Date", txtDate.Text);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@OrderID", txtID.Text);
                        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order details successfully edited!");
                    txtID.Text = "";
                    txtBookID.Text = "";
                    txtQuantity.Text = "";
                    txtDate.Text = "";
                    txtPrice.Text = "";
                    LoadStatisticsData();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid input format: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand checkExistsCmd = new SqlCommand("SELECT COUNT(*) FROM DetailedOrders WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        checkExistsCmd.Parameters.AddWithValue("@OrderID", txtID.Text);
                        checkExistsCmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                        int exists = (int)checkExistsCmd.ExecuteScalar();
                        if (exists == 0)
                        {
                            MessageBox.Show("Order details do not exist.");
                            return;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM DetailedOrders WHERE OrderID = @OrderID AND BookID = @BookID", con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", txtID.Text);
                        cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order details successfully deleted!");
                    LoadStatisticsData();
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid input format: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM DetailedOrders WHERE OrderID LIKE @SearchTerm OR CAST(OrderID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvSatistics.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string inputOrderID = txtID.Text.Trim();
                    if (string.IsNullOrWhiteSpace(inputOrderID))
                    {
                        MessageBox.Show("Please enter a valid Order ID.", "Input Error");
                        return;
                    }
                    string query = @"SELECT SUM(ISNULL(do.Price, 0) * ISNULL(do.Quantity, 0)) AS TotalProfit FROM  DetailedOrders do WHERE 
               do.OrderID = @OrderID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", inputOrderID);
                        object result = cmd.ExecuteScalar();
                        decimal totalProfit = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        MessageBox.Show($"Total Profit for Order ID {inputOrderID}: {totalProfit:C}", "Profit Statistics");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating profit: " + ex.Message, "Error");
            }

        }
    }
}
