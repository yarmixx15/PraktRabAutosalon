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

namespace WindowsFormsApp3
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            reg regForm = new reg();
            regForm.Show();
        }

        private void FormAuto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection("Data Source=172.16.0.211\\SQLEXPRESS;" +
                                                           "Initial Catalog=user33;Persist Security " +
                                                              "Info=True;User ID=user33;Password=wsruser33");
            sqlConnect.Open();
            SqlCommand sqlQuery = new SqlCommand("SELECT * FROM [dbo].[Autosalon] Where Login='" + TBLogin.Text + "'  AND  Password='" + TBPassword.Text + "'", sqlConnect);

            SqlDataReader sqlQueryReader = null;
            sqlQueryReader = sqlQuery.ExecuteReader();
            if (sqlQueryReader.HasRows)
            {
                sqlQueryReader.Read();

                if ((sqlQueryReader.GetValue(0).ToString() == TBLogin.Text) &&
                    (sqlQueryReader.GetValue(1).ToString() == TBPassword.Text))
                {
                    if (sqlQueryReader.GetValue(2).ToString() == "Manager")
                    {
                        MessageBox.Show("Вы авторизовались за Менеджера");
                    }
                    else if (sqlQueryReader.GetValue(2).ToString() == "Client")
                    {
                        FormUser formU = new FormUser();
                        formU.Show();
                    }
                }
            }
            else MessageBox.Show("Неправильная связка");
        }

        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

