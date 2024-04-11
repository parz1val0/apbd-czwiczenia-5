using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    
    private List<Animal> animals = StaticData.animals;
    [HttpGet]
    public List<Animal> GetAnimals()
    {
        return animals;
    }
    
    [HttpDelete("{id}")]
    public List<Animal> DeleteAnimal(int id)
    {
        animals.RemoveAt(id-1);
        
        return animals;
    }

    [HttpGet("{id}")]
    public Animal GetAnimal(int id)
    {
        foreach (var an in animals)
        {
            if (an.Id == id)
                return an;
        }
        throw  new Exception("No such animal");
    }
    public class AnimalRequestModel
    {
        public string FirstName { get; set; }
        public string Category { get; set; }
        public int Weight { get; set; }
        public string FurColor { get; set; }
    }

    [HttpPost]
    public Animal PutAnimal([FromBody] AnimalRequestModel model)
    {
        Animal an = new Animal(animals.Count+1, model.FirstName, model.Category, model.Weight, model.FurColor);
        animals.Add(an);
        return an;
    }
    [HttpPut("{id}")]
    public Animal UpdateAnimal([FromBody] AnimalRequestModel model,int id)
    {
        foreach (var ani in animals)
        {
            if (ani.Id == id)
            {
                ani.FirstName = model.FirstName;
                ani.Category = model.Category;
                ani.Weight = model.Weight;
                ani.FurColor = model.FurColor;
                return ani;
            }
        }
        throw  new Exception("No such animal");
    }
}