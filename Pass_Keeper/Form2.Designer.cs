namespace Pass_Keeper
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            email_box = new TextBox();
            sign_in2 = new Button();
            password_box = new TextBox();
            pass_renew = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(81, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 52);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(82, 41);
            label1.TabIndex = 0;
            label1.Text = "Pass";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(76, 2);
            label2.Name = "label2";
            label2.Size = new Size(119, 41);
            label2.TabIndex = 1;
            label2.Text = "Keeper";
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(81, 631);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 5;
            label3.Text = "a product by Product Design LLC";
            // 
            // email_box
            // 
            email_box.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email_box.ForeColor = Color.Black;
            email_box.Location = new Point(50, 217);
            email_box.Name = "email_box";
            email_box.Size = new Size(257, 31);
            email_box.TabIndex = 6;
            // 
            // sign_in2
            // 
            sign_in2.BackColor = Color.MidnightBlue;
            sign_in2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sign_in2.ForeColor = SystemColors.ControlLight;
            sign_in2.Location = new Point(50, 410);
            sign_in2.Name = "sign_in2";
            sign_in2.Size = new Size(257, 50);
            sign_in2.TabIndex = 8;
            sign_in2.Text = "Sign in";
            sign_in2.UseVisualStyleBackColor = false;
            sign_in2.Click += sign_in2_Click;
            // 
            // password_box
            // 
            password_box.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_box.ForeColor = Color.Black;
            password_box.Location = new Point(50, 318);
            password_box.Name = "password_box";
            password_box.PasswordChar = '*';
            password_box.Size = new Size(220, 31);
            password_box.TabIndex = 9;
            // 
            // pass_renew
            // 
            pass_renew.Font = new Font("Calibri", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            pass_renew.ForeColor = Color.Black;
            pass_renew.Location = new Point(95, 473);
            pass_renew.Name = "pass_renew";
            pass_renew.Size = new Size(159, 21);
            pass_renew.TabIndex = 10;
            pass_renew.Text = "Forgot password? renew it!";
            pass_renew.Click += pass_renew_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 199);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 18;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 300);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 19;
            label5.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            pictureBox1.Location = new Point(273, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 661);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pass_renew);
            Controls.Add(password_box);
            Controls.Add(sign_in2);
            Controls.Add(email_box);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox email_box;
        private Button sign_in2;
        private TextBox password_box;
        private Label pass_renew;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}