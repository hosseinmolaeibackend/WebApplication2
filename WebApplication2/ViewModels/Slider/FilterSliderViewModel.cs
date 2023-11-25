using WebApplication2.Models;
using WebApplication2.Models.Catalog;
using WebApplication2.ViewModels.Pagination;

namespace WebApplication2.ViewModels.Slider;

public class FilterSliderViewModel:Paging<SliderModel>
{
    public string? TitleSlider { get; set; }
    public string? UrlSlider { get; set; }
}