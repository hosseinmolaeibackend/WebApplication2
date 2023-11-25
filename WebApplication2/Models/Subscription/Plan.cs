using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Subscription;

public class Plan
{
    [Key]
    public int  Id { get; set; }
    public int DayOfMonth { get; set; }
    public decimal Price { get; set; }

  
}