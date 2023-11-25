using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.ViewModels.Tract;

public class TractViewModel
{
    [Required(ErrorMessage = "Completed {0} and max charketer {1}")]
    [DisplayName("Title")]
    [MaxLength(250)]
    public string Title { get; set; }
    [Required(ErrorMessage = "Completed {0}")]
    [DisplayName("Image")]
    public IFormFile TitleImage { get; set; }
    [Required(ErrorMessage = "Completed {0} and max charketer {1}")]
    [DisplayName("Description")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Date Time")]
    [DisplayName("DateTime")]
    public DateTime CreateTract { get; set; }
    public string? TimeReadTract { get; set; }
}