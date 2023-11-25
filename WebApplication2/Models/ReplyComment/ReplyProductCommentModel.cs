using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.User;

namespace WebApplication2.Models.ReplyComment;

public class ReplyProductCommentModel
{
    [Key]
    public int ReplyProductCommentId { get; set; }
    public string ReplyCommentBody { get; set; }
    
    public int UserId { get; set; }
    public int CommentProductId { get; set; }
    public CommentProductModel CommentProductModel { get; set; }
    public UserModel UserModel { get; set; }
    public ICollection<LikeProductReplyCommentModel> LikeProductReplyCommentModels { get; set; }
}