using Pass_Keeper.Models;
using Pass_Keeper.Properties;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Pass_Keeper;

public partial class Form5 : Form
{
    private string sourceForm;
    public string? F_name { get; set; }
    public string? L_name { get; set; }
    public string? Email_ { get; set; }

    Database db = new();
    public Form5(string source)
    {
        InitializeComponent();
        db.LoadPeopleFromJson();
        this.sourceForm = source;
        if (source == "Form6")
        {
            update.Text = "Confirm";
            Text = "Register password";
            label4.Text = "Password";
        }
    }

    Color originalColor = Color.Black;
    private string originalNew_passText = string.Empty;

    private void new_pass_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (!Regex.IsMatch(new_pass.Text, @"^[A-Z][A-Za-z0-9_]{7,}$"))
            {
                new_pass.ForeColor = Color.Red;
                MessageBox.Show("Invalid password format. Password must start with an uppercase letter and be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new_pass.Text = string.Empty;
                new_pass.ForeColor = originalColor;
            }
            else
            {
                new_pass.ForeColor = Color.Green;
                originalNew_passText = new_pass.Text;
            }
        }
    }
    private void new_pass_TextChanged(object sender, EventArgs e)
    {
        if (new_pass.Text != originalNew_passText)
            new_pass.ForeColor = originalColor;
    }

    private void confirm_pass_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (new_pass.Text == confirm_pass.Text)
            {
                confirm_pass.ForeColor = Color.Green;
            }
            else
            {
                confirm_pass.ForeColor = Color.Red;
                MessageBox.Show("Password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirm_pass.Text = string.Empty;
                confirm_pass.ForeColor = originalColor;
            }
        }
    }

    private void confirm_Click(object sender, EventArgs e)
    {
        if (sourceForm == "Form6")
        {
            db.LoadPerson();
            string pass = new_pass.Text;

            Person person = new()
            {
                First_name = F_name,
                Last_name = L_name,
                Email = Email_,
                Password = pass
            };

            try
            {
                this.Hide();
                Form4 form4 = new("Form5", person);

                Random random = new Random();
                int regCode = random.Next(100000, 1000000);
                string regmessage = $"\t\t\t\t Attention!!\nDo not share this registration code with anyone! => {regCode}";

                Notification notification = new($"Register Code", regmessage, "PassKeeper");

                Thread thread = new(() => NetWork.SendNotification(Email_, notification))
                {
                    IsBackground = false
                };
                thread.Start();

                form4.Regcode = regCode.ToString();
                form4.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing JSON file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else if (sourceForm == "Form4")
        {
            var selectedMail = db.loadedPeople.Find(person => person.Email == Email_);

            if (selectedMail != null)
            {
                selectedMail.Password = new_pass.Text;

                string updatedJsonStr = JsonSerializer.Serialize(db.loadedPeople, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(db.personFile, updatedJsonStr);
                ShowConfirmationScreen();
            }
        }
    }

    private bool isPasswordVisible = false;

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        if (isPasswordVisible)
        {
            pictureBox1.Image = Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            new_pass.PasswordChar = '*';
        }
        else
        {
            pictureBox1.Image = Resources.Ionic_Ionicons_Eye_48;
            new_pass.PasswordChar = '\0';
        }

        isPasswordVisible = !isPasswordVisible;
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        if (isPasswordVisible)
        {
            pictureBox2.Image = Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            confirm_pass.PasswordChar = '*';
        }
        else
        {
            pictureBox2.Image = Resources.Ionic_Ionicons_Eye_48;
            confirm_pass.PasswordChar = '\0';
        }

        isPasswordVisible = !isPasswordVisible;
    }

    private void ShowConfirmationScreen()
    {
        Label confirmationLabel = new Label
        {
            BackColor = Color.DarkGreen,
            Text = "Registration is successfully done!!",
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(60, 190),
            Size = new Size(240, 180),
            Font = new Font("Arial", 14, FontStyle.Bold),
        };

        Button go_sign_in = new()
        {
            BackColor = Color.DarkGreen,
            Text = "Go to sign in page..",
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(60, 400),
            Size = new Size(240, 40),
            Font = new Font("Arial", 12, FontStyle.Bold),
        };

        this.Controls.Add(confirmationLabel);
        this.Controls.Add(go_sign_in);

        confirmationLabel.BringToFront();
        go_sign_in.BringToFront();

        confirmationLabel.Visible = true;
        go_sign_in.Visible = true;

        new_pass.Enabled = false;
        confirm_pass.Enabled = false;
        update.Enabled = false;
        pictureBox1.Enabled = false;
        pictureBox2.Enabled = false;
        label4.Enabled = false;
        label5.Enabled = false;
        panel1.Enabled = false;

        go_sign_in.Click += (sender, e) =>
        {
            this.Hide();
            Form2 form2 = new();
            form2.Show();
        };
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        if (e.CloseReason == CloseReason.UserClosing)
        {
            Application.Exit();
        }
    }

}
