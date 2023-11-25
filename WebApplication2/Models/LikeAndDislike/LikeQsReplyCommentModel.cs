using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.ReplyComment;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeQsReplyCommentModel
{
    [Key]
    public int LikeQsCommentId { get; set; }
    public int LikeCount  { get; set; }
    
    public int ReplyQsCommentId { get; set; }
    public ReplyQsCommentModel ReplyQsCommentModel { get; set; }
}