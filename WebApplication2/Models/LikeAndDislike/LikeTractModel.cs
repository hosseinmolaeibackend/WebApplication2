using System.ComponentModel.DataAnnotations;
using WebApplication2.Models.Tract;

namespace WebApplication2.Models.LikeAndDislike;

public class LikeTractModel
{
    [Key]
    public int LikeTractId { get; set; }
    public int LikeCount { get; set; }
    
    public int TractId { get; set; }
    public TractModel TractModel { get; set; }
}