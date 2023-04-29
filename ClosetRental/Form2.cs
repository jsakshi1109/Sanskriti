using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClosetRental
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = (int)numericUpDown1.Value;
            int total = 2000 * q;
            String t = total.ToString();
            label5.Text ="Total: Rs." + t;

            String am = q.ToString();
            name.Text = am + " × Pastel themed Heavy Lehanga";
            nameAmount.Text = "Rs. " + t;

            int tax = total * 12 / 100;
            taxAmount.Text = "Rs. " + tax;

            int TotalAmount = total + tax + 100;
            totalAmount.Text = "Rs. " +  TotalAmount.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        { 
            progressBar1.Value = 100;
            MessageBox.Show("Congratulations, Your order is confirmed! ");
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(310,478); // Desired hovered size
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(100,180); // Back to original size
        }
    }
}
