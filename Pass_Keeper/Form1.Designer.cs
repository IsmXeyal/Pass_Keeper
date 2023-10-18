namespace Pass_Keeper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            sign_in = new Button();
            register = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(81, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 52);
            panel1.TabIndex = 1;
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
            // sign_in
            // 
            sign_in.BackColor = Color.MidnightBlue;
            sign_in.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            sign_in.ForeColor = SystemColors.ControlLight;
            sign_in.Location = new Point(103, 229);
            sign_in.Name = "sign_in";
            sign_in.Size = new Size(156, 48);
            sign_in.TabIndex = 2;
            sign_in.Text = "Sign in";
            sign_in.UseVisualStyleBackColor = false;
            sign_in.Click += sign_in_Click;
            // 
            // register
            // 
            register.BackColor = Color.MidnightBlue;
            register.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            register.ForeColor = SystemColors.ControlLight;
            register.Location = new Point(103, 302);
            register.Name = "register";
            register.Size = new Size(156, 48);
            register.TabIndex = 3;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(95, 631);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 4;
            label3.Text = "a product by Product Design LLC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(359, 661);
            Controls.Add(label3);
            Controls.Add(register);
            Controls.Add(sign_in);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button sign_in;
        private Button register;
        private Label label3;
    }
}