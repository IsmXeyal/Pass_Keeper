namespace Pass_Keeper
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            namee = new TextBox();
            l_namee = new TextBox();
            emailll = new TextBox();
            passs = new TextBox();
            photo = new PictureBox();
            edit = new Label();
            ff_name = new Label();
            ll_name = new Label();
            emaill = new Label();
            label5 = new Label();
            change1 = new Button();
            change2 = new Button();
            change3 = new Button();
            change4 = new Button();
            pictureBox1 = new PictureBox();
            sign_out = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(80, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 52);
            panel1.TabIndex = 13;
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
            // namee
            // 
            namee.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            namee.ForeColor = Color.Blue;
            namee.Location = new Point(24, 277);
            namee.Name = "namee";
            namee.Size = new Size(248, 31);
            namee.TabIndex = 14;
            // 
            // l_namee
            // 
            l_namee.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            l_namee.ForeColor = Color.Blue;
            l_namee.Location = new Point(24, 357);
            l_namee.Name = "l_namee";
            l_namee.Size = new Size(248, 31);
            l_namee.TabIndex = 15;
            l_namee.KeyUp += LastName_KeyUp;
            // 
            // emailll
            // 
            emailll.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailll.ForeColor = Color.Blue;
            emailll.Location = new Point(24, 435);
            emailll.Name = "emailll";
            emailll.Size = new Size(248, 31);
            emailll.TabIndex = 16;
            // 
            // passs
            // 
            passs.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passs.ForeColor = Color.Blue;
            passs.Location = new Point(24, 516);
            passs.Name = "passs";
            passs.PasswordChar = '*';
            passs.Size = new Size(223, 31);
            passs.TabIndex = 17;
            // 
            // photo
            // 
            photo.Image = Properties.Resources.download;
            photo.Location = new Point(127, 98);
            photo.Name = "photo";
            photo.Size = new Size(90, 90);
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
            photo.TabIndex = 18;
            photo.TabStop = false;
            // 
            // edit
            // 
            edit.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            edit.Location = new Point(156, 191);
            edit.Name = "edit";
            edit.Size = new Size(34, 19);
            edit.TabIndex = 19;
            edit.Text = "Edit";
            edit.TextAlign = ContentAlignment.MiddleCenter;
            edit.Click += edit_Click;
            // 
            // ff_name
            // 
            ff_name.BackColor = Color.Transparent;
            ff_name.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            ff_name.Location = new Point(24, 249);
            ff_name.Name = "ff_name";
            ff_name.Size = new Size(89, 25);
            ff_name.TabIndex = 20;
            ff_name.Text = "First name";
            // 
            // ll_name
            // 
            ll_name.BackColor = Color.Transparent;
            ll_name.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            ll_name.Location = new Point(24, 329);
            ll_name.Name = "ll_name";
            ll_name.Size = new Size(89, 25);
            ll_name.TabIndex = 21;
            ll_name.Text = "Last name";
            ll_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emaill
            // 
            emaill.BackColor = Color.Transparent;
            emaill.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            emaill.Location = new Point(24, 407);
            emaill.Name = "emaill";
            emaill.Size = new Size(89, 25);
            emaill.TabIndex = 22;
            emaill.Text = "Email";
            emaill.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 488);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 23;
            label5.Text = "Password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // change1
            // 
            change1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            change1.ForeColor = Color.Navy;
            change1.Location = new Point(278, 277);
            change1.Name = "change1";
            change1.Size = new Size(72, 33);
            change1.TabIndex = 24;
            change1.Text = "change";
            change1.UseVisualStyleBackColor = true;
            change1.Click += change1_Click;
            // 
            // change2
            // 
            change2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            change2.ForeColor = Color.Navy;
            change2.Location = new Point(278, 357);
            change2.Name = "change2";
            change2.Size = new Size(72, 33);
            change2.TabIndex = 25;
            change2.Text = "change";
            change2.UseVisualStyleBackColor = true;
            change2.Click += change2_Click;
            // 
            // change3
            // 
            change3.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            change3.ForeColor = Color.Navy;
            change3.Location = new Point(278, 435);
            change3.Name = "change3";
            change3.Size = new Size(72, 33);
            change3.TabIndex = 26;
            change3.Text = "change";
            change3.UseVisualStyleBackColor = true;
            change3.Click += change3_Click;
            // 
            // change4
            // 
            change4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            change4.ForeColor = Color.Navy;
            change4.Location = new Point(278, 516);
            change4.Name = "change4";
            change4.Size = new Size(72, 33);
            change4.TabIndex = 27;
            change4.Text = "change";
            change4.UseVisualStyleBackColor = true;
            change4.Click += change4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            pictureBox1.Location = new Point(244, 516);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sign_out
            // 
            sign_out.BackColor = Color.MidnightBlue;
            sign_out.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sign_out.ForeColor = SystemColors.ControlLight;
            sign_out.Location = new Point(83, 612);
            sign_out.Name = "sign_out";
            sign_out.Size = new Size(178, 37);
            sign_out.TabIndex = 29;
            sign_out.Text = "Sign out";
            sign_out.UseVisualStyleBackColor = false;
            sign_out.Click += sign_out_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 661);
            Controls.Add(sign_out);
            Controls.Add(pictureBox1);
            Controls.Add(change4);
            Controls.Add(change3);
            Controls.Add(change2);
            Controls.Add(change1);
            Controls.Add(label5);
            Controls.Add(emaill);
            Controls.Add(ll_name);
            Controls.Add(ff_name);
            Controls.Add(edit);
            Controls.Add(photo);
            Controls.Add(passs);
            Controls.Add(emailll);
            Controls.Add(l_namee);
            Controls.Add(namee);
            Controls.Add(panel1);
            ForeColor = Color.Blue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Landing Profile";
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)photo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox namee;
        private TextBox l_namee;
        private TextBox emailll;
        private TextBox passs;
        private PictureBox photo;
        private Label edit;
        private Label ff_name;
        private Label ll_name;
        private Label emaill;
        private Label label5;
        private Button change1;
        private Button change2;
        private Button change3;
        private Button change4;
        private PictureBox pictureBox1;
        private Button sign_out;
        private OpenFileDialog openFileDialog1;
    }
}