using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models;
using WebApplication2.Models.Catalog;
using WebApplication2.Utilities;
using WebApplication2.Utilities.ImageHelper;
using WebApplication2.ViewModels.Pagination;
using WebApplication2.ViewModels.Slider;

namespace WebApplication2.Areas.Admin.Controllers;

public class SliderController : AdminBaseController
{
    #region constructor
    private readonly ApplicationDbContext _db;
    public SliderController(ApplicationDbContext context)
    {
        _db = context;
    }

    #endregion

    #region Filter slider
    public IActionResult ShowSlider(FilterSliderViewModel filter )
    {
        var query = _db.SliderModels.AsQueryable();
        var AllSlidersCount = query.Count();
        if (!string.IsNullOrEmpty(filter.TitleSlider))
            query = query.Where(q => q.TitleSlider.Contains(filter.TitleSlider));
        if (!string.IsNullOrEmpty(filter.UrlSlider))
            query = query.Where(q => q.UrlSlider.Contains(filter.UrlSlider));
        filter.SetPaging(query);
        return View(filter);
    }

        #endregion

    #region creat slider
    [HttpGet]
    public IActionResult creatSlider()
    {
        return View();
    }
    [HttpPost,ValidateAntiForgeryToken]
    public IActionResult creatSlider(SliderViewModel sliderViewModel)
    {
        if (ModelState.IsValid)
        {
            var newSlider = new SliderModel()
            {
                TitleSlider = sliderViewModel.TitleSlider,
                UrlSlider = sliderViewModel.UrlSlider,
                DescriptionSlider = sliderViewModel.DescriptionSlider
            };
            string ImageName = Guid.NewGuid().ToString("N") + Path.GetExtension(sliderViewModel.ImageSlider.FileName);
            sliderViewModel.ImageSlider.AddImageToServer(ImageName,PathTools.SliderImageServerPath,75,75,PathTools.SliderImageThumbnailServerPath);
            newSlider.ImageSlider = ImageName;
            _db.SliderModels.Add(newSlider);
            _db.SaveChanges();
        }

        return RedirectToAction("ShowSlider", "Slider", new { area = "Admin" });
    }

    #endregion

    #region Edit slider
    [HttpGet]
    public IActionResult EditSlide(int id)
    {
        ViewBag.id = id;
        var slide = _db.SliderModels.SingleOrDefault(s=>s.Id == id);
        if (slide == null) return NotFound();
        var sliderInput = new EditSliderViewModel()
        {
            Id = slide.Id,
            TitleSlider = slide.TitleSlider,
            DescriptionSlider = slide.DescriptionSlider,
            UrlSlider = slide.UrlSlider,
            ImageName = slide.ImageSlider
        };
        return View(sliderInput);
    }

    [HttpPost,ValidateAntiForgeryToken]
    public IActionResult EditSlide(int id,EditSliderViewModel editSliderViewModel)
    {
        var slideVm = _db.SliderModels.SingleOrDefault(s => s.Id == id);
        if (slideVm == null) return NotFound();
        if (ModelState.IsValid)
        {
            slideVm.TitleSlider = editSliderViewModel.TitleSlider;
            slideVm.UrlSlider=editSliderViewModel.UrlSlider;
            slideVm.DescriptionSlider = editSliderViewModel.DescriptionSlider;
            if (editSliderViewModel.ImageSlider!=null)
            {
                string Imagename = Guid.NewGuid().ToString("N")
                                   + Path.GetExtension(editSliderViewModel.ImageSlider.FileName);
                editSliderViewModel.ImageSlider.AddImageToServer(Imagename,
                    PathTools.SliderImageServerPath,75,75,
                    PathTools.SliderImageThumbnailServerPath,slideVm.ImageSlider);
                slideVm.ImageSlider = Imagename;
            }

            _db.SliderModels.Update(slideVm);
            _db.SaveChanges();
            return RedirectToAction("ShowSlider", "Slider", new { area = "Admin" });
        }
        return View();
    }

    #endregion

    #region Details

    public IActionResult Detail(int id)
    {
        return View(_db.SliderModels.SingleOrDefault(s => s.Id == id));
    }
    

    #endregion
}