using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.TagsAndHashtage;
using WebApplication2.Models.User;

namespace WebApplication2.Models.Tract;

public class TractModel
{
    [Key]
    public int TractId { get; set; }
    [Required(ErrorMessage = "Completed {0} and max charketer {1}")]
    [DisplayName("Title")]
    [MaxLength(250)]
    public string Title { get; set; }
    [Required(ErrorMessage = "Completed {0}")]
    [DisplayName("Image")]
    public string TitleImage { get; set; }
    [Required(ErrorMessage = "Completed {0} and max charketer {1}")]
    [DisplayName("Description")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Date Time")]
    [DisplayName("DateTime")]
    public DateTime CreateTract { get; set; }
    
    public string? TimeReadTract { get; set; }

    public int UserId { get; set; }
    public UserModel UserModels { get; set; }

    public ICollection<CommentTractModel> CommentTractModels { get; set; }
    public ICollection<LikeTractModel> LikeTractModels { get; set; }
    public ICollection<TageInterfaceModel> TageInterfaces { get; set; }
}