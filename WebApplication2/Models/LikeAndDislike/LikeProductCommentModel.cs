using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeProductCommentModel
{
    [Key]
    public int LikeCommentProductId { get; set; }
    public int LikeCount { get; set; }

    public int CommentProductId { get; set; }
    public CommentProductModel CommentProductModel { get; set; }
}