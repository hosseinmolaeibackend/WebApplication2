using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Product;

public class ProductGalleriesModel
{
    [Key]
    public int ProductGalleriesId { get; set; }
    public string ImageName { get; set; }
    
    public int ProductId { get; set; }
    public ProductModel ProductModel { get; set; }
}