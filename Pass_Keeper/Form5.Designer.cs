namespace Pass_Keeper
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            update = new Button();
            new_pass = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            confirm_pass = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.BackColor = Color.MidnightBlue;
            update.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            update.ForeColor = SystemColors.ControlLight;
            update.Location = new Point(50, 388);
            update.Name = "update";
            update.Size = new Size(257, 50);
            update.TabIndex = 14;
            update.Text = "Update password";
            update.UseVisualStyleBackColor = false;
            update.Click += confirm_Click;
            // 
            // new_pass
            // 
            new_pass.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            new_pass.ForeColor = Color.Black;
            new_pass.Location = new Point(50, 217);
            new_pass.Name = "new_pass";
            new_pass.PasswordChar = '*';
            new_pass.Size = new Size(235, 31);
            new_pass.TabIndex = 13;
            new_pass.TextChanged += new_pass_TextChanged;
            new_pass.KeyUp += new_pass_KeyUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(81, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 52);
            panel1.TabIndex = 12;
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
            // confirm_pass
            // 
            confirm_pass.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_pass.ForeColor = Color.Black;
            confirm_pass.Location = new Point(50, 311);
            confirm_pass.Name = "confirm_pass";
            confirm_pass.PasswordChar = '*';
            confirm_pass.Size = new Size(235, 31);
            confirm_pass.TabIndex = 15;
            confirm_pass.KeyUp += confirm_pass_KeyUp;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(81, 631);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 16;
            label3.Text = "a product by Product Design LLC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 199);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 17;
            label4.Text = "New password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 293);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 18;
            label5.Text = "Confirm password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            pictureBox1.Location = new Point(281, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            pictureBox2.Location = new Point(281, 311);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 661);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(confirm_pass);
            Controls.Add(update);
            Controls.Add(new_pass);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a new password";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update;
        private TextBox new_pass;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox confirm_pass;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}