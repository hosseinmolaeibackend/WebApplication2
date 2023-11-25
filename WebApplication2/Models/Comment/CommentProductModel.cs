using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.Product;
using WebApplication2.Models.ReplyComment;
using WebApplication2.Models.User;

namespace WebApplication2.Models.Comment;

public  class CommentProductModel
{
    [Key]
    public int CommentProductId { get; set; }
    [Required(ErrorMessage = "write comment")]
    public string CommentBody { get; set; }

    public int UserId { get; set; }
    public int ProductId { get; set; }
    public ProductModel ProductModel { get; set; }
    public UserModel UserModel { get; set; }

    public ICollection<ReplyProductCommentModel> ReplyProductCommentModels { get; set; }
    public ICollection<LikeProductCommentModel> LikeCommentProductModels { get; set; }
}