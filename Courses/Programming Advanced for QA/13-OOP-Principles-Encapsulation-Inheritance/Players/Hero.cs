namespace Players;

public class Hero
{
    public string Username;

    public int Level;

    public Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    public override string ToString()
    {
        string output = $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";

        return output;
    }
}
