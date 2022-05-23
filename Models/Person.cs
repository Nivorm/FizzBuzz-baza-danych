using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FizzBuzzWeb.Models;
public class Person
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    public int? Year { get; set; }
    public bool IsLeapYear { get; set; }
    public void CheckIfLeapYear()
    {
        if (this.Year % 4 == 0 && (this.Year % 400 == 0 || this.Year % 100 != 0))
            IsLeapYear = true;
        else
            IsLeapYear = false;
    }
}