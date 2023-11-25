using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Faqs;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeQsModel
{
    [Key]
    public int LikeQsId { get; set; }
    public int LikeCount  { get; set; }
    public int QuestionId { get; set; }
    public QuestionModel QuestionModel { get; set; }
}