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
using System.Security.Cryptography;
using ZXing.QrCode;
using ZXing;

namespace FinalIS
{
    public partial class Form2 : Form
    {
        private String cnn = @"Data Source=DESKTOP-L84GB5T\SQLEXPRESS;Initial Catalog=IS;Integrated Security=True";
        /*  private string firstname, lastname, department;
          private int age;*/

        public Form2()
        {
            InitializeComponent();
        }

        private void Createbtt_Click(object sender, EventArgs e)
        {
            var hashid1 = createhash();
            SqlConnection con = new SqlConnection(cnn);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "insert into QR(LastName,FirstName,Age,Department,HashID)values('" + textBox2.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + hashid1 + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            var qr = new ZXing.BarcodeWriter();
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 250,
                Height = 250,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            qr.Options = options;
            qr.Format = ZXing.BarcodeFormat.QR_CODE;
            var result = new Bitmap(qr.Write(hashid1));
            pictureBox1.Image = result;
        }

        private void savebtt_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Image not found", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.CreatePrompt = true;
                save.OverwritePrompt = true;
                save.FileName = "QR";
                save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.Image.Save(save.FileName);
                    /* save.InitialDirectory = Environment.GetFolderPath
                                 (Environment.SpecialFolder.Desktop);*/
                }
            }
        }

        private string createhash()
        {
            var seed1 = textBox1.Text.ToString();
            var seed2 = textBox4.Text.ToString();
            string plainData = seed1 + seed2;
            string hashid = ComputeSha256Hash(plainData);

            return hashid;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}