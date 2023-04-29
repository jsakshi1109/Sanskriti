using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClosetRental
{
    public partial class Form1 : Form
    {
        private char ch;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                String gender = null;
                int flag = 0;
                if (radioButton1.Checked)
                {
                    gender = radioButton1.Text;
                    flag = 1;
                }
                else if (radioButton2.Checked)
                {
                    gender = radioButton2.Text;
                    flag = 1;
                }
                else if (radioButton3.Checked)
                {
                    gender = radioButton3.Text;
                    flag = 1;
                }

                
                    if (password.TextLength == 0 || cpassword.TextLength == 0)
                    {
                        MessageBox.Show("Enter Password!");
                        flag = 0;
                    }
                    if (password.Text != cpassword.Text)
                    {
                        MessageBox.Show("Password Does not Match!!");
                        flag = 0;
                    }
                    if (email.TextLength == 0)
                    {
                        MessageBox.Show("Enter EMail!");
                        flag = 0;
                    }
                    else if (email.TextLength > 0)
                    {
                        Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]
                    {1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                        bool isValid = regex.IsMatch(email.Text.Trim());
                        if (!isValid)
                        {
                            MessageBox.Show("Invalid Email.");
                            flag = 0;
                        }
                    }

                

                if (text_box1.TextLength == 0)
                {
                    MessageBox.Show("Enter Name!");
                    flag = 0;
                }
                else if (text_box1.TextLength > 0)
                {
                    Regex regex = new Regex("^[a-zA-Z]+$");
                    bool isValid = regex.IsMatch(text_box1.Text.Trim());
                    if (!isValid)
                    {
                        MessageBox.Show("Only Letters are allowed in Name.");
                        flag = 0;
                    }

                }
                if (!maskedTextBox1.MaskFull)
                {
                    MessageBox.Show("Invalid Mobile Number!");
                    flag = 0;
                }


                if (checkBox1.Checked)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                    MessageBox.Show("Agree to Terms and Conditions!!");
                }

                if (flag == 1)
                {
                    /*String name = text_box1.Text;
                    BackColor = Color.FloralWhite;
                    label9.Text = "Account Successfully Created!";
                    label9.Text = label9.Text + "\n\nName : " + name;
                    label9.Text = label9.Text + "\nGender : " + gender;
                    label9.Text = label9.Text + "\nDate of Birth: " + dateTimePicker1.Text;
                    label9.Text = label9.Text + "\nEmail : " + email.Text;
                    label9.Text = label9.Text + "\nPhone Number : " + maskedTextBox1.Text;*/

                    Main_Screen main = new Main_Screen("Welcome, " + text_box1.Text);
                    main.Visible = true;
                    this.Hide();

                }
                else
                {
                    label9.Text = "Details incorrect, try again!";
                }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void cpassword_TextChanged(object sender, EventArgs e)
        {
            cpassword.PasswordChar = '*';
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void mobilenumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
