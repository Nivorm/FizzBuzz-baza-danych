using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FizzBuzzWeb.Models;
public class Person {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar(4)")]
    public string Year { get; set; }
   // [Required]
  //  [MaxLength(100)]
   // [Column(TypeName = "varchar(100)")]
  //  public string Result { get; set; }
}