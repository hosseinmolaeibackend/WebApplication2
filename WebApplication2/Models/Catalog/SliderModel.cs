using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models.Catalog;

public class SliderModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(180)]
    public string TitleSlider { get; set; } 
    [Required]
    [MaxLength(250)]
    public string DescriptionSlider { get; set; }
    [Required]
    [MaxLength(200)]
    public string UrlSlider { get; set; }
    [Required]
    [MaxLength(200)]
    public string ImageSlider { get; set; }
}