using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewModels.Slider;

public class SliderViewModel
{
    [Display(Name = "Title")]
    [Required(ErrorMessage = "please type {0} for slide ")]
    [MaxLength(150, ErrorMessage = "{0} Can't charekter most {1}")]
    public string TitleSlider { get; set; }
    [Display(Name = "Description")]
    [Required(ErrorMessage = "please type {0} for slide ")]
    [MaxLength(250, ErrorMessage = "{0} Can't charekter most {1}")]
    public string DescriptionSlider { get; set; }
    [Display(Name = "Url")]
    [Required(ErrorMessage = "please type {0} for slide ")]
    [MaxLength(100, ErrorMessage = "{0} Can't charekter most {1}")]
    public string UrlSlider { get; set; }
    [Display(Name = "image")]
    [Required(ErrorMessage = "please Uploading {0} for slide ")]
    public IFormFile ImageSlider { get; set; }
}