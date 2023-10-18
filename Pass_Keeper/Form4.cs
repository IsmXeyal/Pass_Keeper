using Pass_Keeper.Models;
using System;
using System.Text.Json;

namespace Pass_Keeper;

public partial class Form4 : Form
{
    private Person person;

    Database db = new();

    private string source_Form;
    public string? Email2 { get; set; }
    public string Regcode { get; set; }
    public Form4(string source, Person person)
    {
        InitializeComponent();
        db.LoadPeopleFromJson();
        this.source_Form = source;
        this.person = person;
        if (source == "Form5")
            Text = "Confirm register code";
        this.person = person;
    }

    private bool verificationCodeIsValid = false;

    private void verify_code_KeyUp(object sender, KeyEventArgs e)
    {
        string enteredCode = verify_code.Text.Trim();

        if (enteredCode == Regcode.ToString())
        {
            verificationCodeIsValid = true;
            verify_code.Enabled = false;
        }
        else
        {
            verificationCodeIsValid = false;
        }

        submit.Enabled = verificationCodeIsValid;
    }

    private void submit_Click(object sender, EventArgs e)
    {
        if (source_Form == "Form3")
        {
            this.Hide();
            Form5 form5 = new("Form4");
            form5.Email_ = Email2;
            form5.Show();
        }
        else if (source_Form == "Form5")
        {
            db.LoadPerson();
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

            verify_code.Enabled = false;
            submit.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            panel1.Enabled = false;

            db.People.Add(person);
            string jsonstr = JsonSerializer.Serialize(db.People, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(db.personFile, jsonstr);

            go_sign_in.Click += (sender, e) =>
            {
                this.Hide();
                Form2 form2 = new();
                form2.Show();
            };
        }
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
