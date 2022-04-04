using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Models;

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

    public IList<Person> People { get; set; }

    [BindProperty]
    public Person Person { get; set; }
    public IActionResult OnPost()
    {
        People = _context.Person.ToList();
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _context.Person.Add(Person);
        _context.SaveChanges();
        return RedirectToPage("./Index");
    }
    public void OnGet()
    {
        People = _context.Person.ToList();
    }
}
