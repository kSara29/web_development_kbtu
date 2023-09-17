using Lesson.Context;
using Lesson.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lesson.Controllers;

public class BrandController : Controller
{
    private readonly MobileContext _context;

    public BrandController(MobileContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var brands = _context.Brands.ToList();
        var brandVms = brands.Select(brand => brand.ToViewModel()).ToList();
        
        return View(brandVms);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(AddBrandVm? vm)
    {
        if (vm != null && ModelState.IsValid)
        {
            _context.Brands.Add(vm.ToModel());
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        return RedirectToAction("Add", vm);
    }
}