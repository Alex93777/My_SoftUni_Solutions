namespace ExerciseOopHierarchy;

public abstract class MenuItem
{
    // Това е абстрактен клас който е като шаблон и в него описваме как изглежда всеки един артикул от менюто

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public MenuItem(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Description} - ${this.Price}";
    }
}
