using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClosetRental
{
    public partial class aboutUs : Form
    {
        public aboutUs(String helloMessage)
        {
            InitializeComponent();
            label4.Text = helloMessage;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Screen main = new Main_Screen(label4.Text);
            main.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Changing Font, Please wait!!";
            FontDialog dlg = new FontDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                /*string fontName;
                float fontSize;
                fontName = dlg.Font.Name;
                fontSize = dlg.Font.Size;
                MessageBox.Show(fontName + "    " + fontSize);*/
                label1.Font= dlg.Font;
                label2.Font= dlg.Font;
                label3.Font= dlg.Font;
                label4.Font= dlg.Font;
                richTextBox1.Font= dlg.Font;
                richTextBox2.Font= dlg.Font;
                toolStripStatusLabel1.Text = "Font Changed....";
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
