using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Product;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeProductModel
{
    [Key]
    public int LikeProductId { get; set; }
    public int LikeCount { get; set; }
    public int ProductId { get; set; }
    public ProductModel ProductModel { get; set; }
}