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

namespace FinalIS
{
    public partial class Form3 : Form
    {
        private String cnn = @"Data Source=DESKTOP-L84GB5T\SQLEXPRESS;Initial Catalog=IS;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void scanbtt1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cnn);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "SELECT * FROM QR WHERE Hashid='" + scantb1.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            scantext1.Text = reader[1].ToString();
                            scantext2.Text = reader[2].ToString();
                            scantext3.Text = reader[3].ToString();
                            scantext4.Text = reader[4].ToString();
                        }
                    }
                }
                con.Close();
            }
        }
    }
}