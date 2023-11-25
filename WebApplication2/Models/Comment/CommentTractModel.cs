using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.ReplyComment;
using WebApplication2.Models.Tract;
using WebApplication2.Models.User;

namespace WebApplication2.Models.Comment;

public class CommentTractModel
{
    [Key] 
    public int CommentTractId { get; set; }

    [Required(ErrorMessage = "Write comment")]
    public string CommentBody { get; set; }

    public DateTime CreatTimeComment { get; set; }

    public int TractId { get; set; }
    public TractModel TractModel { get; set; }
    public int UserId { get; set; }
    public UserModel UserModel { get; set; }
    public ICollection<ReplyTractCommentModel> ReplyTractCommentModels { get; set; }
    public ICollection<LikeTractCommentModel> LikeTractCommentModels { get; set; }
}
