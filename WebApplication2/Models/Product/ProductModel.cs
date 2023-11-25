using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.TagsAndHashtage;

namespace WebApplication2.Models.Product;

public class ProductModel
{
    [Key]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Write {0}")]
    [Display(Name = "ProductTitle")]
    public string ProductTitle { get; set; }
    [Required(ErrorMessage = "Write {0}")]
    [Display(Name = "ProductDescription")]
    public string ProductDescription { get; set; }
    public string ProductImage { get; set; }
    public DateTime ProductCreat { get; set; }
    [Required(ErrorMessage = "Write {0}")]
    [Display(Name = "ProductPrice")]
    public decimal ProductPrice { get; set; }
    [Required(ErrorMessage = "Write {0}")]
    [Display(Name = "ProductCount")]
    public int ProductCount { get; set; }

    public ICollection<CommentProductModel> CommentProductModels { get; set; }
    public ICollection<LikeProductModel> LikeProductModels { get; set; }
    public ICollection<ProductGalleriesModel> ProductGalleriesModels { get; set; }
    public ICollection<TageInterfaceModel> TageInterfaces { get; set; }
}