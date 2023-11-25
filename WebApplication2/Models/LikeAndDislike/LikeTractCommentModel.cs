using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeTractCommentModel
{
    [Key]
    public int LikeTractCommentId { get; set; }
    public int CommentLikeCount { get; set; }
    public int CommentTractId { get; set; }
    public CommentTractModel CommentTractModel { get; set; }
}