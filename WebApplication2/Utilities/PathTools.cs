﻿namespace WebApplication2.Utilities;

public class PathTools
{
    #region slider

    public static string SliderImage = "/content/images/sliders/";
    public static string SliderImageServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/images/sliders/");
    public static string SliderImageThumbnail = "/content/images/sliders/thumbs/";
    public static string SliderImageThumbnailServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/images/sliders/thumbs/");

    #endregion

    #region product
    
    public static string ProductImage = "/content/images/products/";
    public static string ProductImageServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/images/products/");
    public static string ProductImageThumbnail = "/content/images/products/thumbs/";
    public static string ProductImageThumbnailServerPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/images/products/thumbs/");

    #endregion
}