using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.User;

namespace WebApplication2.Models.ReplyComment;

public class ReplyQsCommentModel
{
    [Key]
    public int ReplyQsCommentId { get; set; }
    public string ReplyBodyComment { get; set; }
    
    public int CommentQsId { get; set; }
    public CommentQsModel CommentQsModel { get; set; }

    public int UserId { get; set; }
    public UserModel UserModel { get; set; }

    public ICollection<LikeQsReplyCommentModel> LikeQsReplyCommentModels { get; set; }
}