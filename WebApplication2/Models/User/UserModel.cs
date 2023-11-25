using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Models.Comment;
using WebApplication2.Models.Faqs;
using WebApplication2.Models.ReplyComment;
using WebApplication2.Models.Subscription;
using WebApplication2.Models.Tract;

namespace WebApplication2.Models.User;

public class UserModel
{
    [Key]
    public int UserId { get; set; }
    [Required]
    [MaxLength(150)]
    public string Username { get; set; }
    [Required]
    [MaxLength(150)]
    public string Password { get; set; }
    
    [MaxLength(150)]
    public string? ProfileImage { get; set; }
    
    public ICollection<TractModel> TractModels { get; set; }
    public ICollection<CommentTractModel> CommentTractModels { get; set; }
    public ICollection<ReplyTractCommentModel> ReplyTractCommentModels { get; set; }
    public ICollection<QuestionModel> QuestionModels { get; set; }
    public ICollection<CommentQsModel> CommentQsModels { get; set; }
    public ICollection<ReplyQsCommentModel> ReplyQsCommentModels { get; set; }
    public ICollection<CommentProductModel> CommentProductModels { get; set; }
    public ICollection<ReplyProductCommentModel> ReplyProductCommentModels { get; set; }
}