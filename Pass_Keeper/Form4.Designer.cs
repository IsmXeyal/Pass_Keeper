namespace Pass_Keeper
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            submit = new Button();
            verify_code = new TextBox();
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
            panel1.TabIndex = 4;
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
            // submit
            // 
            submit.BackColor = Color.MidnightBlue;
            submit.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            submit.ForeColor = SystemColors.ControlLight;
            submit.Location = new Point(50, 385);
            submit.Name = "submit";
            submit.Size = new Size(257, 50);
            submit.TabIndex = 11;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // verify_code
            // 
            verify_code.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            verify_code.ForeColor = Color.Black;
            verify_code.Location = new Point(50, 269);
            verify_code.Name = "verify_code";
            verify_code.Size = new Size(257, 31);
            verify_code.TabIndex = 10;
            verify_code.KeyUp += verify_code_KeyUp;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(81, 631);
            label3.Name = "label3";
            label3.Size = new Size(186, 21);
            label3.TabIndex = 12;
            label3.Text = "a product by Product Design LLC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 251);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 19;
            label4.Text = "Code";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(359, 661);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(submit);
            Controls.Add(verify_code);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot password activate code";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button submit;
        private TextBox verify_code;
        private Label label3;
        private Label label4;
    }
}