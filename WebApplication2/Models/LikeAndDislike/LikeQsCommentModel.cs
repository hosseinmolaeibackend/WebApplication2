using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Comment;

namespace WebApplication2.Models.LikeAndDislike;

public  class LikeQsCommentModel
{
    [Key]
    public int LikeQsCommentId { get; set; }
    public int LikeCount  { get; set; }
    
    public int CommentQsId { get; set; }
    public CommentQsModel CommentQsModel { get; set; }
}