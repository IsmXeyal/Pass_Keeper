namespace Pass_Keeper
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            submit = new Button();
            name = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            last_name = new TextBox();
            email_c = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // submit
            // 
            submit.BackColor = Color.MidnightBlue;
            submit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            submit.ForeColor = SystemColors.ControlLight;
            submit.Location = new Point(50, 451);
            submit.Name = "submit";
            submit.Size = new Size(257, 50);
            submit.TabIndex = 14;
            submit.Text = "Next";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // name
            // 
            name.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            name.ForeColor = Color.Black;
            name.Location = new Point(50, 217);
            name.Name = "name";
            name.Size = new Size(257, 31);
            name.TabIndex = 13;
            name.TextChanged += name_TextChanged;
            name.KeyUp += name_KeyUp;
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
            // label3
            // 
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(95, 631);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 17;
            label3.Text = "a product by Product Design LLC";
            // 
            // last_name
            // 
            last_name.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            last_name.ForeColor = Color.Black;
            last_name.Location = new Point(50, 296);
            last_name.Name = "last_name";
            last_name.Size = new Size(257, 31);
            last_name.TabIndex = 18;
            last_name.TextChanged += last_name_TextChanged;
            last_name.KeyUp += last_name_KeyUp;
            // 
            // email_c
            // 
            email_c.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email_c.ForeColor = Color.Black;
            email_c.Location = new Point(50, 381);
            email_c.Name = "email_c";
            email_c.Size = new Size(257, 31);
            email_c.TabIndex = 19;
            email_c.TextChanged += email_c_TextChanged;
            email_c.KeyUp += email_c_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 199);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 20;
            label4.Text = "First name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 278);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 21;
            label5.Text = "Last name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGray;
            label6.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(50, 363);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 22;
            label6.Text = "E-mail";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 661);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(email_c);
            Controls.Add(last_name);
            Controls.Add(label3);
            Controls.Add(submit);
            Controls.Add(name);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private TextBox name;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox last_name;
        private TextBox email_c;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}