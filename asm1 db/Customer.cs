using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace asm1_db
{
    public partial class Customer : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomers;
        private object ex;
        private object txtCustomerId;
        private object txtSearch;

        public Customer()
        {
            InitializeComponent();
        }

        private void lbCustomer_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        private void gvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvCustomer.DataSource = dt;

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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Customers (CustomersID, CustomersEmail, CustomersName, CustomersAddress, CustomersPhone) VALUES (@ID, @Email, @Name, @Address, @Phone)", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.ExecuteNonQuery();

                    }
                    MessageBox.Show("Customer added successfully!");
                    txtID.Text = "";
                    txtEmail.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";

                    LoadCustomerData();
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE Customers SET CustomersEmail=@Email, CustomersName=@Name, CustomersAddress=@Address, CustomersPhone=@Phone WHERE CustomersID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated customer information successfully!");
                            txtID.Text = "";
                            txtEmail.Text = "";
                            txtName.Text = "";
                            txtAddress.Text = "";
                            txtPhone.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No customers found with this ID.");
                        }
                    }
                    LoadCustomerData();
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
                    cmd = new SqlCommand("DELETE FROM Customers WHERE CustomersID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully!");
                    LoadCustomerData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void BtnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Customers WHERE CustomersName LIKE @SearchTerm OR CAST(CustomersID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvCustomer.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }   
}
