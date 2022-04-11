using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Models;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages;

public class IndexModel : PageModel
{
    private readonly PeopleContext _context;

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
    {
        _logger = logger;
        _context = context;
    }

    public List<Person> People { get; set; }

    public List<Person> PeopleData = new();

    [BindProperty]
    public Person Person { get; set; }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            People = _context.Person.ToList();
            Person.Date = DateTime.Now;
            

            var data = HttpContext.Session.GetString("data");
            if (data != null)
            
                PeopleData = JsonConvert.DeserializeObject<List<Person>>(data);
            
            PeopleData.Add(Person);
            People.Add(Person);
            HttpContext.Session.SetString("data", JsonConvert.SerializeObject(PeopleData));
            
            _context.Person.Add(Person);
            _context.SaveChanges();
            return Page();
        }
        return Page();
    }
    public void OnGet()
    {
        People = _context.Person.ToList();
    }
}
