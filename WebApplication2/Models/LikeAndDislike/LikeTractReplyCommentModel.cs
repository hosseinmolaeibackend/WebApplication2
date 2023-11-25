using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.ReplyComment;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeReplyTractCommentModel
{
    [Key]
    public int LikeReplyTractCommentId { get; set; }
    public int LikeReplyCommentCount { get; set; }

    public int ReplyTractCommentId { get; set; }
    public ReplyTractCommentModel ReplyTractCommentModel { get; set; }
}