namespace Pass_Keeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            email_box2 = new TextBox();
            send_code = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(81, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 52);
            panel1.TabIndex = 3;
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
            // email_box2
            // 
            email_box2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email_box2.ForeColor = Color.Black;
            email_box2.Location = new Point(50, 246);
            email_box2.Name = "email_box2";
            email_box2.Size = new Size(257, 31);
            email_box2.TabIndex = 7;
            email_box2.KeyUp += email_box2_KeyUp;
            // 
            // send_code
            // 
            send_code.BackColor = Color.MidnightBlue;
            send_code.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            send_code.ForeColor = SystemColors.ControlLight;
            send_code.Location = new Point(50, 355);
            send_code.Name = "send_code";
            send_code.Size = new Size(257, 50);
            send_code.TabIndex = 9;
            send_code.Text = "Send code";
            send_code.UseVisualStyleBackColor = false;
            send_code.Click += send_code_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(84, 631);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 10;
            label3.Text = "a product by Product Design LLC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 228);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 19;
            label4.Text = "E-mail";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(359, 661);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(send_code);
            Controls.Add(email_box2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot password send code";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox email_box2;
        private Button send_code;
        private Label label3;
        private Label label4;
    }
}