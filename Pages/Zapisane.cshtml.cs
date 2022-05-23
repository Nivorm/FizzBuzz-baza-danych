using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Models;
namespace FizzBuzzWeb.Pages
{
    public class ZapisaneModel : PageModel
    {
        public Person Person { get; set; }
        public PersonData PersonData = new PersonData(); 

        public void OnGet()
        {

            var Data2 = HttpContext.Session.GetString("Data2");
            if (Data2 != null)
                PersonData =
                JsonConvert.DeserializeObject <PersonData> (Data2);

            HttpContext.Session.SetString("Data2",
               JsonConvert.SerializeObject(PersonData));

        }
    }
}
