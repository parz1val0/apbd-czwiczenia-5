namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Category { get; set; }
    public int Weight { get; set; }
    public string FurColor { get; set; }

    public Animal(int Id,string FirstName,string Category,int Weight,string FurColor)
    {
        this.Id = Id;
        this.FirstName = FirstName;
        this.Category = Category;
        this.Weight = Weight;
        this.FurColor = FurColor;
    }
}