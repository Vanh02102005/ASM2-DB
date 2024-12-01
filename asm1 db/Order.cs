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
    public partial class Order : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtOrderId;
        private object txtSearch;
        public Order()
        {
            InitializeComponent();
        }

        private void lbOrderName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();               
                    using (SqlCommand checkCustomerCmd = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE CustomersID = @CustomersID", con))
                    {
                        checkCustomerCmd.Parameters.AddWithValue("@CustomersID", txtCustomersID.Text);
                        int customerExists = (int)checkCustomerCmd.ExecuteScalar();

                        if (customerExists == 0)
                        {
                            MessageBox.Show("Customer ID does not exist.");
                            return;
                        }
                    }
                    using (SqlCommand checkStaffCmd = new SqlCommand("SELECT COUNT(*) FROM Staff WHERE StaffID = @StaffID", con))
                    {
                        checkStaffCmd.Parameters.AddWithValue("@StaffID", txtEmployeeID.Text);
                        int staffExists = (int)checkStaffCmd.ExecuteScalar();

                        if (staffExists == 0)
                        {
                            MessageBox.Show("Employee ID does not exist.");
                            return;
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Orders (OrderID, CustomersID, StaffID, OrderDate, OrderPrice) VALUES (@ID, @CustomersID, @StaffID, @Date, @Price)", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtOrderID.Text); 
                        cmd.Parameters.AddWithValue("@CustomersID",txtCustomersID.Text);
                        cmd.Parameters.AddWithValue("@StaffID", txtEmployeeID.Text);
                        cmd.Parameters.AddWithValue("@Date", txtOrderDate.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtOrderPrice.Text)); 
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã thêm đơn hàng thành công!");
                    txtOrderID.Text = "";
                    txtCustomersID.Text = "";
                    txtEmployeeID.Text = "";
                    txtOrderDate.Text = "";
                    txtOrderPrice.Text = "";              
                    LoadOrderData();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void Order_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }


        private void LoadOrderData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvOrder.DataSource = dt;
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
 
                    int newCustomersID = int.Parse(txtCustomersID.Text);
                    using (SqlCommand checkCustomerCmd = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE CustomersID = @CustomersID", con))
                    {
                        checkCustomerCmd.Parameters.AddWithValue("@CustomersID", newCustomersID);
                        int customerExists = (int)checkCustomerCmd.ExecuteScalar();

                        if (customerExists == 0)
                        {
                            MessageBox.Show("Customer ID does not exist.");  
                            return;  
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("UPDATE [Orders] SET [CustomersID] = @CustomersID, [StaffID] = @StaffID, [OrderDate] = @Date, [OrderPrice] = @Price WHERE [OrderID] = @ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtOrderID.Text));
                        cmd.Parameters.AddWithValue("@CustomersID", newCustomersID);
                        cmd.Parameters.AddWithValue("@StaffID", int.Parse(txtEmployeeID.Text));
                        cmd.Parameters.AddWithValue("@Date", txtOrderDate.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtOrderPrice.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order successfully edited!");
                            txtOrderID.Text = "";
                            txtCustomersID.Text = "";
                            txtEmployeeID.Text = "";
                            txtOrderDate.Text = "";
                            txtOrderPrice.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No order found with the given ID!"); 
                        }
                    }
                    LoadOrderData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }         
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM [Orders] WHERE [OrderID] = @ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtOrderID.Text));

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Order successfully deleted!");                         }
                        else
                        {
                            MessageBox.Show("No order found with the given ID!"); 
                        }
                    }
                    LoadOrderData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Orders WHERE OrderID LIKE @SearchTerm OR CAST(OrderID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtOrderID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvOrder.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbBookID_Click(object sender, EventArgs e)
        {

        }
    }
}
