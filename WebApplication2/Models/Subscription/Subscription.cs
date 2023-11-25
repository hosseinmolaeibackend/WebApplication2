using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Subscription;

public class Subscription
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
}