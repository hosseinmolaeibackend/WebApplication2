using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels;

public class ProductViewModel
{
    [Required(ErrorMessage = "Name for {0}")]
    [MaxLength(50)]
    [DisplayName("Product Name")]
    public string ProductName  { get; set; }
    
    [Required(ErrorMessage = "Please {0} Complete")]
    [MaxLength(80)]
    [DisplayName("Product Title")]
    public string ProductTitle  { get; set; }
    
    [Required(ErrorMessage = "Please {0} Complete")]
    [MaxLength(500)]
    [DisplayName("Product Description")]
    public string ProductDescription  { get; set; }
    
    [Required(ErrorMessage = "Please {0} Complete")]
    [Range(0,1000)]
    [DisplayName("Product Price")]
    public decimal ProductPrice  { get; set; }
    
    [Required]
    [DisplayName("Product Date Create")]
    public DateTime ProductCreat  { get; set; }
    
    public IFormFile ProductImage  { get; set; }
}