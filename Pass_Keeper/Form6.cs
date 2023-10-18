using Pass_Keeper.Models;
using System.Text.RegularExpressions;

namespace Pass_Keeper;

public partial class Form6 : Form
{
    Database db = new();
    public Form6()
    {
        InitializeComponent();
        db.LoadPeopleFromJson();
    }

    Color originalColor = Color.Black;
    private string originalNameText = string.Empty;
    private string originalLastNameText = string.Empty;
    private string originalEmailText = string.Empty;

    private void name_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string f_name = name.Text;

            if (!Regex.IsMatch(f_name, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                name.ForeColor = Color.Red;
                MessageBox.Show("Invalid Name format. It should start with an uppercase letter and have at least 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                name.Text = string.Empty;
                name.ForeColor = originalColor;
            }
            else
            {
                name.ForeColor = Color.Green;
                originalNameText = name.Text;
            }
        }
    }

    private void name_TextChanged(object sender, EventArgs e)
    {
        if (name.Text != originalNameText)
            name.ForeColor = originalColor;
    }

    private void last_name_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string l_name = last_name.Text;

            if (!Regex.IsMatch(l_name, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                last_name.ForeColor = Color.Red;
                MessageBox.Show("Invalid Surname format. It should start with an uppercase letter and have at least 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                last_name.Text = string.Empty;
                last_name.ForeColor = originalColor;
            }
            else
            {
                last_name.ForeColor = Color.Green;
                originalLastNameText = last_name.Text;
            }
        }
    }

    private void last_name_TextChanged(object sender, EventArgs e)
    {
        if (last_name.Text != originalLastNameText)
            last_name.ForeColor = originalColor;
    }

    private void email_c_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string email = email_c.Text;

            if (!Regex.IsMatch(email, @"^[A-Za-z0-9._%+-]+@gmail\.com$"))
            {
                email_c.ForeColor = Color.Red;
                MessageBox.Show("Email must be a valid Gmail address (e.g., example@gmail.com).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email_c.Text = string.Empty;
                email_c.ForeColor = originalColor;
            }
            else
            {
                email_c.ForeColor = Color.Green;
                originalEmailText = email_c.Text;
            }
        }
    }

    private void email_c_TextChanged(object sender, EventArgs e)
    {
        if (email_c.Text != originalEmailText)
            email_c.ForeColor = originalColor;
    }

    private void submit_Click(object sender, EventArgs e)
    {
        bool isNameValid = Regex.IsMatch(name.Text, @"^[A-Z][a-zA-Z]{2,}$");
        bool isLastNameValid = Regex.IsMatch(last_name.Text, @"^[A-Z][a-zA-Z]{2,}$");
        bool isEmailValid = Regex.IsMatch(email_c.Text, @"^[A-Za-z0-9._%+-]+@gmail\.com$");

        if (!isNameValid || !isLastNameValid || !isEmailValid)
        {
            MessageBox.Show("Please correct the input in the fields before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (IsUserExists(name.Text, last_name.Text, email_c.Text))
        {
            MessageBox.Show("A user with the same name, last name, and email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        this.Hide();
        Form5 form5 = new("Form6");
        form5.F_name = name.Text;
        form5.L_name = last_name.Text;
        form5.Email_ = email_c.Text;
        form5.Show();
    }

    private bool IsUserExists(string firstName, string lastName, string email)
    {
        foreach (var person in db.loadedPeople)
        {
            if (person.First_name == firstName && person.Last_name == lastName && person.Email == email)
            {
                return true;
            }
        }
        return false;
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
