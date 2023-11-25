using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Product;
using WebApplication2.Models.Tract;

namespace WebApplication2.Models.TagsAndHashtage;

public class TageInterfaceModel
{
    [Key]
    public int TageInterfaceId { get; set; }
    public int TageId { get; set; }
    public int ProductId { get; set; }
    public int TractId { get; set; }

    public TageModel TageModel { get; set; }
    public ProductModel ProductModel { get; set; }
    public TractModel TractModel { get; set; }
}