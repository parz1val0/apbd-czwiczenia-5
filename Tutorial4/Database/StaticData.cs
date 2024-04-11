using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
       new Animal(1,"NAME1","Category1",12,"black"),
        new Animal(2,"NAME2","Category2",13,"white"),
        new Animal(3,"NAME3","Category1",14,"red"),
        new Animal(4,"NAME4","Category4",15,"green")
    };

    public static List<Wizyta> wizyty = new List<Wizyta>()
    {
        new Wizyta(1,"10.04.2024",StaticData.FindAnimal(1),"ALL good",123.1),
        new Wizyta(2,"10.04.2022",StaticData.FindAnimal(1),"ALL good",12.1),
        new Wizyta(3,"10.04.2023",StaticData.FindAnimal(2),"ALL bad",125.1),
        new Wizyta(4,"10.04.2021",StaticData.FindAnimal(3),"ALL normal",1233.1),
        new Wizyta(5,"10.04.2012",StaticData.FindAnimal(3),"ALL cool",23.1)
    };

    public static Animal FindAnimal(int id)
    {
        return animals.Find(an => an.Id == id);
    }
}