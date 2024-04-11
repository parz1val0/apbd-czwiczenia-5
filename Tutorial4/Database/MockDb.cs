using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animals.Add(new Animal(1,"NAME1","Category1",12,"black"));
        Animals.Add(new Animal(2,"NAME2","Category2",13,"white"));
        Animals.Add(new Animal(3,"NAME3","Category1",14,"red"));
        Animals.Add(new Animal(4,"NAME4","Category4",15,"green"));
    }
}