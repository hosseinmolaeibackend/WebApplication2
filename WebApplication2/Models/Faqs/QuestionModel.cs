using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.User;

namespace WebApplication2.Models.Faqs;

public class QuestionModel
{
    [Key]
    public int QuestionId { get; set; }
    public string TitleQs { get; set; }
    public string DesQs { get; set; }

    public ICollection<CommentQsModel> CommentQsModels { get; set; }
    
    public int UserId { get; set; }
    public UserModel UserModel { get; set; }
    public ICollection<LikeQsModel> LikeQsModels { get; set; }
}