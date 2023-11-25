using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Tract;

namespace WebApplication2.Models.TagsAndHashtage;

public class TageModel
{
    [Key]
    public int TageId { get; set; }
    [Required(ErrorMessage = "Write Tage")]
    public string TageBody { get; set; }

    public ICollection<TageInterfaceModel> TageInterfaces { get; set; }
}