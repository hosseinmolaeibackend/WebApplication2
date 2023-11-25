using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Faqs;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.ReplyComment;
using WebApplication2.Models.Tract;
using WebApplication2.Models.User;

namespace WebApplication2.Models.Comment;

public class CommentQsModel
{
    [Key]
    public int CommentQsId { get; set; }
    [Required(ErrorMessage = "Write comment")]
    public string CommentBody { get; set; }
    public DateTime CreatTimeComment { get; set; }

    public int QuestionId { get; set; }
    public QuestionModel QuestionModel { get; set; }
    public int UserId { get; set; }
    public UserModel UserModel { get; set; }
    public ICollection<ReplyQsCommentModel> ReplyQsCommentModels { get; set; }
    public ICollection<LikeQsCommentModel> LikeQsCommentModels { get; set; }
}