namespace Animals.Models;

public abstract class Animal
{
    private string name;                        //Fields

    private string favoriteFood;

    protected Animal(string name, string favoriteFood)                  //Create Constructor
    {
        this.name = name;
        this.favoriteFood = favoriteFood;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.name} and my fovourite food is {this.favoriteFood}";
    }
}
