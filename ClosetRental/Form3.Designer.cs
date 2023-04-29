namespace ClosetRental
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cod = new System.Windows.Forms.RadioButton();
            this.upi = new System.Windows.Forms.RadioButton();
            this.payPal = new System.Windows.Forms.RadioButton();
            this.creditCard = new System.Windows.Forms.RadioButton();
            this.debitCard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(167, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(608, 43);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Value = 33;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Payment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(278, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cod);
            this.panel1.Controls.Add(this.upi);
            this.panel1.Controls.Add(this.payPal);
            this.panel1.Controls.Add(this.creditCard);
            this.panel1.Controls.Add(this.debitCard);
            this.panel1.Location = new System.Drawing.Point(35, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 357);
            this.panel1.TabIndex = 21;
            // 
            // cod
            // 
            this.cod.AutoSize = true;
            this.cod.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod.Location = new System.Drawing.Point(87, 282);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(193, 27);
            this.cod.TabIndex = 28;
            this.cod.TabStop = true;
            this.cod.Text = "Pay on Delivery";
            this.cod.UseVisualStyleBackColor = true;
            // 
            // upi
            // 
            this.upi.AutoSize = true;
            this.upi.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upi.Location = new System.Drawing.Point(87, 225);
            this.upi.Name = "upi";
            this.upi.Size = new System.Drawing.Size(72, 27);
            this.upi.TabIndex = 27;
            this.upi.TabStop = true;
            this.upi.Text = "UPI";
            this.upi.UseVisualStyleBackColor = true;
            // 
            // payPal
            // 
            this.payPal.AutoSize = true;
            this.payPal.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payPal.Location = new System.Drawing.Point(87, 168);
            this.payPal.Name = "payPal";
            this.payPal.Size = new System.Drawing.Size(104, 27);
            this.payPal.TabIndex = 26;
            this.payPal.TabStop = true;
            this.payPal.Text = "PayPal";
            this.payPal.UseVisualStyleBackColor = true;
            // 
            // creditCard
            // 
            this.creditCard.AutoSize = true;
            this.creditCard.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCard.Location = new System.Drawing.Point(87, 110);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(156, 27);
            this.creditCard.TabIndex = 25;
            this.creditCard.TabStop = true;
            this.creditCard.Text = "Credit Card";
            this.creditCard.UseVisualStyleBackColor = true;
            // 
            // debitCard
            // 
            this.debitCard.AutoSize = true;
            this.debitCard.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitCard.Location = new System.Drawing.Point(87, 52);
            this.debitCard.Name = "debitCard";
            this.debitCard.Size = new System.Drawing.Size(147, 27);
            this.debitCard.TabIndex = 24;
            this.debitCard.TabStop = true;
            this.debitCard.Text = "Debit Card";
            this.debitCard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "Select a Payment Mode:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 102);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 716);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton cod;
        private System.Windows.Forms.RadioButton upi;
        private System.Windows.Forms.RadioButton payPal;
        private System.Windows.Forms.RadioButton creditCard;
        private System.Windows.Forms.RadioButton debitCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}