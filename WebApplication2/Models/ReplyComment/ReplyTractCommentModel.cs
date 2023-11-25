using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.User;

namespace WebApplication2.Models.ReplyComment;

public class ReplyTractCommentModel
{
    [Key]
    public int ReplyTractCommentId { get; set; }
    public string ReplyBodyComment { get; set; }
    
    public int CommentTractId { get; set; }
    public CommentTractModel CommentTractModel { get; set; }

    public int UserId { get; set; }
    public UserModel UserModel { get; set; }
    public ICollection<LikeReplyTractCommentModel> LikeReplyTractCommentModels { get; set; }
}