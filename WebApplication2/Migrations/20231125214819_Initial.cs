using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductModels",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCreat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModels", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "SliderModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleSlider = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    DescriptionSlider = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UrlSlider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImageSlider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TageModels",
                columns: table => new
                {
                    TageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TageBody = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TageModels", x => x.TageId);
                });

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "LikeProductModels",
                columns: table => new
                {
                    LikeProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductModelProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeProductModels", x => x.LikeProductId);
                    table.ForeignKey(
                        name: "FK_LikeProductModels_ProductModels_ProductModelProductId",
                        column: x => x.ProductModelProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductGalleriesModels",
                columns: table => new
                {
                    ProductGalleriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductModelProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGalleriesModels", x => x.ProductGalleriesId);
                    table.ForeignKey(
                        name: "FK_ProductGalleriesModels_ProductModels_ProductModelProductId",
                        column: x => x.ProductModelProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentProductModels",
                columns: table => new
                {
                    CommentProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductModelProductId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentProductModels", x => x.CommentProductId);
                    table.ForeignKey(
                        name: "FK_CommentProductModels_ProductModels_ProductModelProductId",
                        column: x => x.ProductModelProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentProductModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModels",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleQs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesQs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModels", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_QuestionModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TractModels",
                columns: table => new
                {
                    TractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TitleImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTract = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeReadTract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelsUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TractModels", x => x.TractId);
                    table.ForeignKey(
                        name: "FK_TractModels_UserModels_UserModelsUserId",
                        column: x => x.UserModelsUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeProductCommentModels",
                columns: table => new
                {
                    LikeCommentProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    CommentProductId = table.Column<int>(type: "int", nullable: false),
                    CommentProductModelCommentProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeProductCommentModels", x => x.LikeCommentProductId);
                    table.ForeignKey(
                        name: "FK_LikeProductCommentModels_CommentProductModels_CommentProductModelCommentProductId",
                        column: x => x.CommentProductModelCommentProductId,
                        principalTable: "CommentProductModels",
                        principalColumn: "CommentProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReplyProductCommentModels",
                columns: table => new
                {
                    ReplyProductCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyCommentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CommentProductId = table.Column<int>(type: "int", nullable: false),
                    CommentProductModelCommentProductId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyProductCommentModels", x => x.ReplyProductCommentId);
                    table.ForeignKey(
                        name: "FK_ReplyProductCommentModels_CommentProductModels_CommentProductModelCommentProductId",
                        column: x => x.CommentProductModelCommentProductId,
                        principalTable: "CommentProductModels",
                        principalColumn: "CommentProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReplyProductCommentModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentQsModels",
                columns: table => new
                {
                    CommentQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatTimeComment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentQsModels", x => x.CommentQsId);
                    table.ForeignKey(
                        name: "FK_CommentQsModels_QuestionModels_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "QuestionModels",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentQsModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeQsModels",
                columns: table => new
                {
                    LikeQsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionModelQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeQsModels", x => x.LikeQsId);
                    table.ForeignKey(
                        name: "FK_LikeQsModels_QuestionModels_QuestionModelQuestionId",
                        column: x => x.QuestionModelQuestionId,
                        principalTable: "QuestionModels",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentTractModels",
                columns: table => new
                {
                    CommentTractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatTimeComment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TractId = table.Column<int>(type: "int", nullable: false),
                    TractModelTractId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentTractModels", x => x.CommentTractId);
                    table.ForeignKey(
                        name: "FK_CommentTractModels_TractModels_TractModelTractId",
                        column: x => x.TractModelTractId,
                        principalTable: "TractModels",
                        principalColumn: "TractId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentTractModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeTractModels",
                columns: table => new
                {
                    LikeTractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    TractId = table.Column<int>(type: "int", nullable: false),
                    TractModelTractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeTractModels", x => x.LikeTractId);
                    table.ForeignKey(
                        name: "FK_LikeTractModels_TractModels_TractModelTractId",
                        column: x => x.TractModelTractId,
                        principalTable: "TractModels",
                        principalColumn: "TractId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TageInterfaceModels",
                columns: table => new
                {
                    TageInterfaceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TageId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TractId = table.Column<int>(type: "int", nullable: false),
                    TageModelTageId = table.Column<int>(type: "int", nullable: false),
                    ProductModelProductId = table.Column<int>(type: "int", nullable: false),
                    TractModelTractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TageInterfaceModels", x => x.TageInterfaceId);
                    table.ForeignKey(
                        name: "FK_TageInterfaceModels_ProductModels_ProductModelProductId",
                        column: x => x.ProductModelProductId,
                        principalTable: "ProductModels",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TageInterfaceModels_TageModels_TageModelTageId",
                        column: x => x.TageModelTageId,
                        principalTable: "TageModels",
                        principalColumn: "TageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TageInterfaceModels_TractModels_TractModelTractId",
                        column: x => x.TractModelTractId,
                        principalTable: "TractModels",
                        principalColumn: "TractId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeProductReplyCommentModels",
                columns: table => new
                {
                    LikeProductReplyCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    ReplyProductCommentId = table.Column<int>(type: "int", nullable: false),
                    ReplyProductCommentModelReplyProductCommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeProductReplyCommentModels", x => x.LikeProductReplyCommentId);
                    table.ForeignKey(
                        name: "FK_LikeProductReplyCommentModels_ReplyProductCommentModels_ReplyProductCommentModelReplyProductCommentId",
                        column: x => x.ReplyProductCommentModelReplyProductCommentId,
                        principalTable: "ReplyProductCommentModels",
                        principalColumn: "ReplyProductCommentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeQsCommentModels",
                columns: table => new
                {
                    LikeQsCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    CommentQsId = table.Column<int>(type: "int", nullable: false),
                    CommentQsModelCommentQsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeQsCommentModels", x => x.LikeQsCommentId);
                    table.ForeignKey(
                        name: "FK_LikeQsCommentModels_CommentQsModels_CommentQsModelCommentQsId",
                        column: x => x.CommentQsModelCommentQsId,
                        principalTable: "CommentQsModels",
                        principalColumn: "CommentQsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReplyQsCommentModels",
                columns: table => new
                {
                    ReplyQsCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyBodyComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentQsId = table.Column<int>(type: "int", nullable: false),
                    CommentQsModelCommentQsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyQsCommentModels", x => x.ReplyQsCommentId);
                    table.ForeignKey(
                        name: "FK_ReplyQsCommentModels_CommentQsModels_CommentQsModelCommentQsId",
                        column: x => x.CommentQsModelCommentQsId,
                        principalTable: "CommentQsModels",
                        principalColumn: "CommentQsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReplyQsCommentModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeTractCommentModels",
                columns: table => new
                {
                    LikeTractCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentLikeCount = table.Column<int>(type: "int", nullable: false),
                    CommentTractId = table.Column<int>(type: "int", nullable: false),
                    CommentTractModelCommentTractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeTractCommentModels", x => x.LikeTractCommentId);
                    table.ForeignKey(
                        name: "FK_LikeTractCommentModels_CommentTractModels_CommentTractModelCommentTractId",
                        column: x => x.CommentTractModelCommentTractId,
                        principalTable: "CommentTractModels",
                        principalColumn: "CommentTractId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReplyTractCommentModels",
                columns: table => new
                {
                    ReplyTractCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReplyBodyComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentTractId = table.Column<int>(type: "int", nullable: false),
                    CommentTractModelCommentTractId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserModelUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReplyTractCommentModels", x => x.ReplyTractCommentId);
                    table.ForeignKey(
                        name: "FK_ReplyTractCommentModels_CommentTractModels_CommentTractModelCommentTractId",
                        column: x => x.CommentTractModelCommentTractId,
                        principalTable: "CommentTractModels",
                        principalColumn: "CommentTractId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReplyTractCommentModels_UserModels_UserModelUserId",
                        column: x => x.UserModelUserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeQsReplyCommentModels",
                columns: table => new
                {
                    LikeQsCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeCount = table.Column<int>(type: "int", nullable: false),
                    ReplyQsCommentId = table.Column<int>(type: "int", nullable: false),
                    ReplyQsCommentModelReplyQsCommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeQsReplyCommentModels", x => x.LikeQsCommentId);
                    table.ForeignKey(
                        name: "FK_LikeQsReplyCommentModels_ReplyQsCommentModels_ReplyQsCommentModelReplyQsCommentId",
                        column: x => x.ReplyQsCommentModelReplyQsCommentId,
                        principalTable: "ReplyQsCommentModels",
                        principalColumn: "ReplyQsCommentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikeReplyTractCommentModels",
                columns: table => new
                {
                    LikeReplyTractCommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LikeReplyCommentCount = table.Column<int>(type: "int", nullable: false),
                    ReplyTractCommentId = table.Column<int>(type: "int", nullable: false),
                    ReplyTractCommentModelReplyTractCommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikeReplyTractCommentModels", x => x.LikeReplyTractCommentId);
                    table.ForeignKey(
                        name: "FK_LikeReplyTractCommentModels_ReplyTractCommentModels_ReplyTractCommentModelReplyTractCommentId",
                        column: x => x.ReplyTractCommentModelReplyTractCommentId,
                        principalTable: "ReplyTractCommentModels",
                        principalColumn: "ReplyTractCommentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentProductModels_ProductModelProductId",
                table: "CommentProductModels",
                column: "ProductModelProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentProductModels_UserModelUserId",
                table: "CommentProductModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentQsModels_QuestionModelQuestionId",
                table: "CommentQsModels",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentQsModels_UserModelUserId",
                table: "CommentQsModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentTractModels_TractModelTractId",
                table: "CommentTractModels",
                column: "TractModelTractId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentTractModels_UserModelUserId",
                table: "CommentTractModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeProductCommentModels_CommentProductModelCommentProductId",
                table: "LikeProductCommentModels",
                column: "CommentProductModelCommentProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeProductModels_ProductModelProductId",
                table: "LikeProductModels",
                column: "ProductModelProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeProductReplyCommentModels_ReplyProductCommentModelReplyProductCommentId",
                table: "LikeProductReplyCommentModels",
                column: "ReplyProductCommentModelReplyProductCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsCommentModels_CommentQsModelCommentQsId",
                table: "LikeQsCommentModels",
                column: "CommentQsModelCommentQsId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsModels_QuestionModelQuestionId",
                table: "LikeQsModels",
                column: "QuestionModelQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeQsReplyCommentModels_ReplyQsCommentModelReplyQsCommentId",
                table: "LikeQsReplyCommentModels",
                column: "ReplyQsCommentModelReplyQsCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeReplyTractCommentModels_ReplyTractCommentModelReplyTractCommentId",
                table: "LikeReplyTractCommentModels",
                column: "ReplyTractCommentModelReplyTractCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeTractCommentModels_CommentTractModelCommentTractId",
                table: "LikeTractCommentModels",
                column: "CommentTractModelCommentTractId");

            migrationBuilder.CreateIndex(
                name: "IX_LikeTractModels_TractModelTractId",
                table: "LikeTractModels",
                column: "TractModelTractId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGalleriesModels_ProductModelProductId",
                table: "ProductGalleriesModels",
                column: "ProductModelProductId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModels_UserModelUserId",
                table: "QuestionModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyProductCommentModels_CommentProductModelCommentProductId",
                table: "ReplyProductCommentModels",
                column: "CommentProductModelCommentProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyProductCommentModels_UserModelUserId",
                table: "ReplyProductCommentModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyQsCommentModels_CommentQsModelCommentQsId",
                table: "ReplyQsCommentModels",
                column: "CommentQsModelCommentQsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyQsCommentModels_UserModelUserId",
                table: "ReplyQsCommentModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyTractCommentModels_CommentTractModelCommentTractId",
                table: "ReplyTractCommentModels",
                column: "CommentTractModelCommentTractId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyTractCommentModels_UserModelUserId",
                table: "ReplyTractCommentModels",
                column: "UserModelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TageInterfaceModels_ProductModelProductId",
                table: "TageInterfaceModels",
                column: "ProductModelProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TageInterfaceModels_TageModelTageId",
                table: "TageInterfaceModels",
                column: "TageModelTageId");

            migrationBuilder.CreateIndex(
                name: "IX_TageInterfaceModels_TractModelTractId",
                table: "TageInterfaceModels",
                column: "TractModelTractId");

            migrationBuilder.CreateIndex(
                name: "IX_TractModels_UserModelsUserId",
                table: "TractModels",
                column: "UserModelsUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikeProductCommentModels");

            migrationBuilder.DropTable(
                name: "LikeProductModels");

            migrationBuilder.DropTable(
                name: "LikeProductReplyCommentModels");

            migrationBuilder.DropTable(
                name: "LikeQsCommentModels");

            migrationBuilder.DropTable(
                name: "LikeQsModels");

            migrationBuilder.DropTable(
                name: "LikeQsReplyCommentModels");

            migrationBuilder.DropTable(
                name: "LikeReplyTractCommentModels");

            migrationBuilder.DropTable(
                name: "LikeTractCommentModels");

            migrationBuilder.DropTable(
                name: "LikeTractModels");

            migrationBuilder.DropTable(
                name: "ProductGalleriesModels");

            migrationBuilder.DropTable(
                name: "SliderModels");

            migrationBuilder.DropTable(
                name: "TageInterfaceModels");

            migrationBuilder.DropTable(
                name: "ReplyProductCommentModels");

            migrationBuilder.DropTable(
                name: "ReplyQsCommentModels");

            migrationBuilder.DropTable(
                name: "ReplyTractCommentModels");

            migrationBuilder.DropTable(
                name: "TageModels");

            migrationBuilder.DropTable(
                name: "CommentProductModels");

            migrationBuilder.DropTable(
                name: "CommentQsModels");

            migrationBuilder.DropTable(
                name: "CommentTractModels");

            migrationBuilder.DropTable(
                name: "ProductModels");

            migrationBuilder.DropTable(
                name: "QuestionModels");

            migrationBuilder.DropTable(
                name: "TractModels");

            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
