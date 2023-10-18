using Pass_Keeper.Models;
using Pass_Keeper.Properties;

namespace Pass_Keeper;

public partial class Form2 : Form
{

    Database db = new();
    public Form2()
    {
        InitializeComponent();
        db.LoadPeopleFromJson();
    }

    private void pass_renew_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form3 form3 = new();
        form3.Show();
    }

    private bool isPasswordVisible = false;

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        if (isPasswordVisible)
        {
            pictureBox1.Image = Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            password_box.PasswordChar = '*';
        }
        else
        {
            pictureBox1.Image = Resources.Ionic_Ionicons_Eye_48;
            password_box.PasswordChar = '\0';
        }

        isPasswordVisible = !isPasswordVisible;
    }
    private void sign_in2_Click(object sender, EventArgs e)
    {
        string username_email = email_box.Text;
        string passwordd = password_box.Text;
        if (username_email != null && passwordd != null)
        {
            var signedInPerson = db.loadedPeople.FirstOrDefault(person =>
                person.Email == username_email && person.Password == passwordd);

            if (signedInPerson != null)
            {
                this.Hide();
                Form7 form7 = new Form7(signedInPerson);
                form7.Show();
            }
            else
                MessageBox.Show("Sign-in failed. Check your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        if (e.CloseReason == CloseReason.UserClosing)
            Application.Exit();
    }
}
