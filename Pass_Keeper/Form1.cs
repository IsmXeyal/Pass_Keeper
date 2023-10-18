namespace Pass_Keeper;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void sign_in_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form2 form2 = new();
        form2.Show();
    }

    private void register_Click(object sender, EventArgs e)
    {
        this.Hide();
        Form6 form6 = new();
        form6.Show();
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