using System;
using System.Windows.Forms;

namespace Andrea_Bushner_Unit2_IT481
{
    public partial class Form1 : Form
    {
        DB database;
        private string user;
        private string password;
        private string server;
        private string database_name;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);
            button5.Click += new EventHandler(button5_Click);
            button6.Click += new EventHandler(button6_Click);
            button7.Click += new EventHandler(button7_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            password = textBox2.Text;
            server = textBox3.Text;
            database_name = textBox4.Text;

            database = new DB("Server = " + server + "\\SQLEXPRESS01;" +
                       "Trusted_Connection=true;" +
                       "Database = " + database_name + ";" +
                       "User Id = " + user + ";" +
                       "Password = " + password + ";"
                       );

            MessageBox.Show("Connection information sent");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company Names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string names = database.getCustomerID();
            MessageBox.Show(names, "Customer ID");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastName();
            MessageBox.Show(names, "Employee Last Name");
        }
    }
}
