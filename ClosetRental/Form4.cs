using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ClosetRental
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                Control item = panel1.Controls[(panel1.Controls.Count - 1) - i];
                if (((item) as System.Windows.Forms.CheckBox).Checked)
                {
                    count++;
                }
            }


            int flag = 0;
            if (count == 1) 
            {
                flag = 1;
            }
            else if(count == 0) {
                MessageBox.Show("Select at least one address!", "Warning");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You have selected Multiple Address." +
                    " Do you wish to continue?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    flag = 1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    flag = 0;
                }
            }

            if (flag == 1)
            {
                progressBar1.Value = 33;
                var form3 = new Form3();
                form3.Visible = true;
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
