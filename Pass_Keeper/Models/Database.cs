using System.Text.Json;

namespace Pass_Keeper.Models;

public class Database
{
    public List<Person>? People { get; set; }
    public Database()
    {
        People = new List<Person>();
    }

    public string personFile = "../../../People.json";

    public void LoadPerson()
    {
        try
        {
            string jsontxt = File.ReadAllText(personFile);
            var list = JsonSerializer.Deserialize<List<Person>>(jsontxt);
            foreach (var item in list)
            {
                People.Add(item);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public List<Person> loadedPeople = new List<Person>();
    public void LoadPeopleFromJson()
    {
        try
        {
            string jsonStr = File.ReadAllText(personFile);
            loadedPeople = JsonSerializer.Deserialize<List<Person>>(jsonStr);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading data: " + ex.Message);
        }
    }
}
