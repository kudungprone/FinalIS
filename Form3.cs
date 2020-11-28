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
using ZXing;

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
            if (string.IsNullOrWhiteSpace(scantb1.Text))
            {
                MessageBox.Show("Vui Lòng Quét Lại QR", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                    scantb1.Clear();
                }
                pictureBox1.Image = Image.FromFile(@"..\..\res\logo.png");
            }
        }

        private void decodeQR()
        {
            try
            {
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                BarcodeReader reader = new BarcodeReader { AutoRotate = true, TryInverted = true };
                Result result = reader.Decode(bitmap);
                string decoded = result.ToString().Trim();
                scantb1.Text = decoded;
            }
            catch (Exception)
            {
                MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp ;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
            }
            decodeQR();
        }
    }
}