using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClosetRental
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button2, caption: "Clicking continue will not deduct any money!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, caption: "Clicking continue will not deduct any money!");
            int flag = 0;
            if (debitCard.Checked || creditCard.Checked || payPal.Checked || upi.Checked || cod.Checked)
            {
                flag = 1;
            }
            
            if(flag == 1)
            {
                progressBar1.Value = 67;
                var form2 = new Form2();
                form2.Visible= true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select any one payment method!" ,"Warning");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
