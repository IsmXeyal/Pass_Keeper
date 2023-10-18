using Pass_Keeper.Models;
namespace Pass_Keeper;

public partial class Form3 : Form
{
    Database db = new Database();
    private Person currentPerson;
    public Form3()
    {
        InitializeComponent();
        db.LoadPeopleFromJson();
    }

    private void email_box2_KeyUp(object sender, KeyEventArgs e)
    {
        string enteredEmail = email_box2.Text.Trim();
        bool emailExists = db.loadedPeople.Any(person => person.Email == enteredEmail);
        send_code.Enabled = emailExists;
    }

    private void send_code_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        int regCode = random.Next(100000, 1000000);

        string regmessage = $"\t\t\t\t Attention!!\nDo not share this registration code with anyone! => {regCode}";

        Notification notification = new($"Register Code", regmessage, "PassKeeper");

        Thread thread = new(() => NetWork.SendNotification(email_box2.Text, notification))
        {
            IsBackground = false
        };
        thread.Start();

        this.Hide();
        Form4 form4 = new("Form3", currentPerson);
        form4.Email2 = email_box2.Text;
        form4.Regcode = regCode.ToString();
        form4.Show();
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
