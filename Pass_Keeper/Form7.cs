using Pass_Keeper.Models;
using Pass_Keeper.Properties;
using System.Drawing.Drawing2D;
using System.Text.Json;

namespace Pass_Keeper;
public partial class Form7 : Form
{
    private Person currentPerson;
    Database db = new();
    public Form7(Person person)
    {
        InitializeComponent();
        GraphicsPath gp = new GraphicsPath();
        gp.AddEllipse(0, 0, photo.Width, photo.Height);
        Region rg = new Region(gp);
        photo.Region = rg;
        currentPerson = person;
        db.LoadPeopleFromJson();
    }

    private void Form7_Load(object sender, EventArgs e)
    {
        namee.Text = currentPerson.First_name;
        namee.Enabled = false;
        l_namee.Text = currentPerson.Last_name;
        l_namee.Enabled = false;
        emailll.Text = currentPerson.Email;
        emailll.Enabled = false;
        passs.Text = currentPerson.Password;
        passs.Enabled = false;
    }

    private void edit_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "JPEG Images|*.jpg;*.jpeg";
        openFileDialog1.Title = "Select a JPEG Image";

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string selectedImagePath = openFileDialog1.FileName;
            Image selectedImage = Image.FromFile(selectedImagePath);

            photo.SizeMode = PictureBoxSizeMode.Zoom;
            photo.Image = selectedImage;
        }
    }

    private void change1_Click(object sender, EventArgs e)
    {
        namee.Enabled = true;
        namee.KeyUp += NameTextBox_KeyUp;
    }

    private void NameTextBox_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var selectedPerson = db.loadedPeople.FirstOrDefault(person =>
                person.Email == emailll.Text && person.Password == passs.Text);

            if (selectedPerson != null)
            {
                selectedPerson.First_name = namee.Text;
                string updatedJsonStr = JsonSerializer.Serialize(db.loadedPeople, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(db.personFile, updatedJsonStr);
            }
            namee.Enabled = false;
        }
    }

    private void change2_Click(object sender, EventArgs e)
    {
        l_namee.Enabled = true;
        l_namee.KeyUp += LastName_KeyUp;
    }

    private void LastName_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var selectedPerson = db.loadedPeople.FirstOrDefault(person =>
                person.Email == emailll.Text && person.Password == passs.Text);

            if (selectedPerson != null)
            {
                selectedPerson.Last_name = l_namee.Text;
                string updatedJsonStr = JsonSerializer.Serialize(db.loadedPeople, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(db.personFile, updatedJsonStr);
            }
            l_namee.Enabled = false;
        }
    }

    private void change3_Click(object sender, EventArgs e)
    {
        emailll.Enabled = true;
        emailll.KeyUp += Email_KeyUp;
    }

    private void Email_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var selectedPerson = db.loadedPeople.FirstOrDefault(person =>
                person.First_name == namee.Text && person.Password == passs.Text);

            if (selectedPerson != null)
            {
                selectedPerson.Email = emailll.Text;
                string updatedJsonStr = JsonSerializer.Serialize(db.loadedPeople, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(db.personFile, updatedJsonStr);
            }
            emailll.Enabled = false;
        }
    }

    private void change4_Click(object sender, EventArgs e)
    {
        passs.Enabled = true;
        passs.KeyUp += Pass_KeyUp;
    }

    private void Pass_KeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var selectedPerson = db.loadedPeople.FirstOrDefault(person =>
                person.First_name == namee.Text && person.Email == emailll.Text);

            if (selectedPerson != null)
            {
                selectedPerson.Password = passs.Text;
                string updatedJsonStr = JsonSerializer.Serialize(db.loadedPeople, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(db.personFile, updatedJsonStr);
            }
            passs.Enabled = false;
        }
    }

    private bool isPasswordVisible = false;

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        if (isPasswordVisible)
        {
            pictureBox1.Image = Resources.Aniket_Suvarna_Box_Bxs_hide_48;
            passs.PasswordChar = '*';
        }
        else
        {
            pictureBox1.Image = Resources.Ionic_Ionicons_Eye_48;
            passs.PasswordChar = '\0';
        }

        isPasswordVisible = !isPasswordVisible;
    }

    private void sign_out_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form1 form1 = new();
        form1.Show();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        if (e.CloseReason == CloseReason.UserClosing)
            Application.Exit();
    }
}
