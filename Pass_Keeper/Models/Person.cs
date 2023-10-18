using System.Text.RegularExpressions;

namespace Pass_Keeper.Models;

public class Person
{
    private string? _first_name;
    private string? _last_name;
    private string? _email;
    private string? _password;

    public string? First_name
    {
        get => _first_name;
        set
        {
            if (Regex.IsMatch(value, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                _first_name = value;
            }
            else
            {
                MessageBox.Show("Invalid First Name format. It should start with an uppercase letter and have at least 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public string? Last_name
    {
        get => _last_name;
        set
        {
            if (Regex.IsMatch(value, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                _last_name = value;
            }
            else
            {
                MessageBox.Show("Invalid Surname format. It should start with an uppercase letter and have at least 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public string? Email
    {
        get => _email;
        set
        {
            if (Regex.IsMatch(value, @"^[A-Za-z0-9._%+-]+@gmail\.com$"))
            {
                _email = value;
            }
            else
            {
                MessageBox.Show("Email must be a valid Gmail address (e.g., example@gmail.com).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }

    public string? Password
    {
        get => _password;
        set
        {
            if (Regex.IsMatch(value, @"^[A-Z][A-Za-z0-9_]{7,}$"))
            {
                _password = value;
            }
            else
            {
                MessageBox.Show("Invalid password format. Password must start with an uppercase letter and be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    public Person() { }
    public Person(string name, string surname, string email, string pass)
    {
        First_name = name;
        Last_name = surname;
        Email = email;
        Password = pass;
    }
}