using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.ReplyComment;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeProductReplyCommentModel
{
    [Key]
    public int LikeProductReplyCommentId { get; set; }
    public int LikeCount { get; set; }

    public int ReplyProductCommentId { get; set; }
    public ReplyProductCommentModel ReplyProductCommentModel { get; set; }
}