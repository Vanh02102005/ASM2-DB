using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
namespace asm1_db
{
    public partial class Employee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        private object gvCustomer;
        private object ex;
        private object txtEmployeeId;
        private object txtSearch;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }


        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    gvEmployee.DataSource = dt;
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
                    string hashedPassword = HashPassword(txtPassword.Text);
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Staff (StaffID, StaffEmail, StaffName, StaffAddress, StaffPhone, StaffUserName, StaffPassword, StaffPosition) VALUES (@ID, @Email, @Name, @Address, @Phone, @Username, @Password, @Position)", con))
                    {

                        cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@PassWord", hashedPassword);
                        cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Employee added successfully!");
                    txtEmployeeID.Text = "";
                    txtEmployeeEmail.Text = "";
                    txtEmployeeName.Text = "";
                    txtEmployeeAddress.Text = "";
                    txtEmployeePhone.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    cbPosition.SelectedIndex = -1; 

                    LoadEmployeeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Staff SET StaffUsername=@UserName, StaffPassword=@Password, StaffEmail=@Email, StaffName=@Name, StaffAddress=@Address,StaffPosition=@Position, StaffPhone=@Phone WHERE StaffID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                        cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                        cmd.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                        cmd.Parameters.AddWithValue("Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Position", cbPosition.Text);
                        string hashedPassword = HashPassword(txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated employee information successfully!");
                            txtEmployeeID.Text = "";
                            txtEmployeeEmail.Text = "";
                            txtEmployeeName.Text = "";
                            txtEmployeeAddress.Text = "";
                            txtEmployeePhone.Text = "";
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            cbPosition.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("No employees found with this ID.");
                        }
                    }
                    LoadEmployeeData();
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
                    cmd = new SqlCommand("DELETE FROM Staff WHERE StaffID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee deleted successfully!");
                    LoadEmployeeData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT * FROM Staff WHERE StaffName LIKE @SearchTerm OR CAST(StaffID AS NVARCHAR) LIKE @SearchTerm";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm", "%" + txtEmployeeID.Text + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        gvEmployee.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=VANH0210;Initial Catalog=testAsm1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Staff SET StaffPassword=@Password WHERE StaffID=@ID", con))
                    {
                        cmd.Parameters.AddWithValue("@ID", txtEmployeeID.Text);
                        string hashedPassword = HashPassword(txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!");
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("No employees found with this ID.");
                        }
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
