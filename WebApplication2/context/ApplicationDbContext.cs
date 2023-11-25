using Microsoft.EntityFrameworkCore;
using WebApplication2.Models.Catalog;
using WebApplication2.Models.Comment;
using WebApplication2.Models.Faqs;
using WebApplication2.Models.LikeAndDislike;
using WebApplication2.Models.Product;
using WebApplication2.Models.ReplyComment;
using WebApplication2.Models.TagsAndHashtage;
using WebApplication2.Models.Tract;
using WebApplication2.Models.User;

namespace WebApplication2.context;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    #region Users DB
    public DbSet<UserModel> UserModels { get; set; }
    #endregion
    
    #region Product DB
    public DbSet<SliderModel> SliderModels { get; set; }
    public DbSet<ProductModel> ProductModels { get; set; }
    public DbSet<ProductGalleriesModel> ProductGalleriesModels { get; set; }
    #endregion

    #region Tract DB
    public DbSet<TractModel> TractModels { get; set; }
    #endregion

    #region Tag DB
    public DbSet<TageModel> TageModels { get; set; }
    public DbSet<TageInterfaceModel> TageInterfaceModels { get; set; }
    #endregion

    #region Comment DB
    public DbSet<CommentProductModel> CommentProductModels { get; set; }
    public DbSet<CommentQsModel> CommentQsModels { get; set; }
    public DbSet<CommentTractModel> CommentTractModels { get; set; }
    #endregion

    #region Reply Comment DB
    public DbSet<ReplyProductCommentModel> ReplyProductCommentModels { get; set; }
    public DbSet<ReplyQsCommentModel> ReplyQsCommentModels { get; set; }
    public DbSet<ReplyTractCommentModel> ReplyTractCommentModels { get; set; }
    #endregion
    
    #region Like DB
    public DbSet<LikeProductModel> LikeProductModels { get; set; }
    public DbSet<LikeTractModel> LikeTractModels { get; set; }
    public DbSet<LikeQsModel> LikeQsModels { get; set; }
    
    public DbSet<LikeProductCommentModel> LikeProductCommentModels { get; set; }
    public DbSet<LikeTractCommentModel> LikeTractCommentModels { get; set; }
    public DbSet<LikeQsCommentModel> LikeQsCommentModels { get; set; }

    public DbSet<LikeProductReplyCommentModel> LikeProductReplyCommentModels { get; set; }
    public DbSet<LikeQsReplyCommentModel> LikeQsReplyCommentModels { get; set; }
    public DbSet<LikeReplyTractCommentModel> LikeReplyTractCommentModels { get; set; }
    #endregion
    

    #region Question
    public DbSet<QuestionModel> QuestionModels { get; set; }
    #endregion
}