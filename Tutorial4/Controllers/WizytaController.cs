using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;
[ApiController]
[Route("[controller]")]
public class WizytaController : ControllerBase
{
    public List<Wizyta> wizyty = StaticData.wizyty;
    [HttpGet("{Animalid}")]
    public List<Wizyta> GetWizytyForAnimal(int id)
    {
        List<Wizyta> wizytyForAnimal = new List<Wizyta>();
        foreach (var wiz in wizyty)
        {
            if (wiz.animal.Id == id)
            {
                Console.WriteLine(wiz.animal);
                wizytyForAnimal.Add(wiz);
            }
        }
        return wizytyForAnimal;
    }
    public class WizytaRequestModel
    {
        
        public string date { get; set; }
        public int AnimalId { get; set; }
        public double price { get; set; }
        public string desc { get; set; }
    }
    [HttpPost]
    public Wizyta PutWizyta([FromBody] WizytaRequestModel model)
    {
        Wizyta an = new Wizyta(wizyty.Count+1, model.date, StaticData.FindAnimal(model.AnimalId), model.desc, model.price);
        wizyty.Add(an);
        return an;
    }
}