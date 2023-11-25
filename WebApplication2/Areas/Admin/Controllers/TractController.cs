using Microsoft.AspNetCore.Mvc;
using WebApplication2.context;
using WebApplication2.Models.Tract;
using WebApplication2.ViewModels.Tract;

namespace WebApplication2.Areas.Admin.Controllers;

public class TractController : AdminBaseController
{
    #region Context
    private ApplicationDbContext _db;
    public TractController(ApplicationDbContext _context)
    {
        _db = _context;
    }
    #endregion

    // GET
    public IActionResult Tract()
    {
        return View();
    }

    #region Creat Tract
    [HttpGet]
    public IActionResult CreatTract()
    {
        return View();
    }
    [HttpPost,ValidateAntiForgeryToken]
    public IActionResult CreatTract(TractViewModel tractViewModel)
    {
        if (ModelState.IsValid)
        {
            var newTract = new TractModel()
            {
                Title = tractViewModel.Title,
                Description = tractViewModel.Description,
                TimeReadTract = tractViewModel.TimeReadTract,
                CreateTract = DateTime.Now
            };
            _db.TractModels.Add(newTract);
            _db.SaveChanges();
        }
        return View();
    }
    #endregion
    
    #region Edit Tract
    [HttpGet]
    public IActionResult EditTract(int id)
    {
        var Tract = _db.TractModels.SingleOrDefault(t => t.TractId == id);
        if (Tract != null) NotFound();
        var EditTract = new EditTractViewModel()
        {
            Title = Tract.Title,
            Description = Tract.Description,
            TimeReadTract = Tract.TimeReadTract
        };
        
        return View();
    }
    [HttpPost,ValidateAntiForgeryToken]
    public IActionResult EditTract(int id,EditTractViewModel editTractViewModel)
    {
        var TractVm = _db.TractModels.SingleOrDefault(T => T.TractId == id);
        if (TractVm == null) NotFound();
        if (ModelState.IsValid)
        {
            TractVm.Title = editTractViewModel.Title;
            TractVm.Description = editTractViewModel.Description;
            TractVm.TimeReadTract = editTractViewModel.TimeReadTract;
            TractVm.CreateTract=DateTime.Now;
        }

        _db.TractModels.Update(TractVm);
        _db.SaveChanges();
        return View();
    }
    #endregion

    #region Detail Tract

    public IActionResult DetailsTract(int id)
    {
        var DatailTract = _db.TractModels.SingleOrDefault(D => D.TractId == id);
        if (DatailTract == null) NotFound();
        return View(DatailTract);
    }
    #endregion

    #region Deleted Tract

    public IActionResult DeleteTract(int id)
    {
        var DeletedTract = _db.TractModels.SingleOrDefault(D => D.TractId == id);
        if (ModelState.IsValid) NotFound();
        _db.TractModels.Remove(DeletedTract);
        _db.SaveChanges();
        return View();
    }
    #endregion
}