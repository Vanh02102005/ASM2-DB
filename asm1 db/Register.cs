using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace asm1_db
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Lưu thông tin đăng ký vào file
                string filePath = "customers.txt";

                // Kiểm tra nếu username đã tồn tại
                if (File.Exists(filePath))
                {
                    var existingUsers = File.ReadAllLines(filePath);
                    foreach (var line in existingUsers)
                    {
                        var data = line.Split(',');
                        if (data[0] == username)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                // Ghi thông tin khách hàng mới vào file
                File.AppendAllText(filePath, $"{username},{password}\n");

                MessageBox.Show("Registration successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển đến Form3 (Customer Management)
                Customer formcustomer = new Customer();
                formcustomer.Show();
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
