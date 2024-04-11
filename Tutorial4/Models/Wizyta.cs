using Tutorial4.Database;

namespace Tutorial4.Models;

public class Wizyta
{
    public int id;
    public String date;
    public Animal animal;
    public String desc;
    public double price;

    public Wizyta(int id, string date, Animal animal, string desc, double price)
    {
        this.id = id;
        this.date = date;
        this.animal = animal;
        this.desc = desc;
        this.price = price;
    }
}