using System.Net.Mime;
using Lesson.Context;
using Lesson.Models;
using Lesson.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Lesson.Controllers;

public class PhoneController : Controller
{
    private readonly MobileContext _context;
    private readonly CurrencyService _currencyService;

    public PhoneController(MobileContext context)
    {
        _context = context;
        _currencyService = new CurrencyService();
    }

    [HttpGet]
    public IActionResult Index()
    {
        var phones = _context.Phones
            .Include(p => p.Brand)
            .ToList();
        return View(phones);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var vm = new PhoneFormVm
        {
            Brands = _context.Brands.Select(brand => brand.ToViewModel()).ToList()
        };
        return View(vm);
    }

    [HttpPost]
    public IActionResult Add(PhoneFormVm? vm)
    {
        if (vm != null)
        {
            _context.Phones.Add(vm.ToModel());
            _context.SaveChanges();
        }
        
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Details(long phoneId)
    {
        string jsonText = System.IO.File.ReadAllText("wwwroot/currency.json");
        List<Currency>? currency = JsonConvert.DeserializeObject<List<Currency>>(jsonText);
        
        var phone = _context.Phones
            .Include(p => p.Brand)
            .FirstOrDefault(phone => phone.Id == phoneId);
        
        if (phone == null)
            return NotFound();
        
        var phoneDetailsVm = PhoneDetailsVm.FromModel(phone, currency);
        return View(phoneDetailsVm);
    }

    [HttpGet]
    public IActionResult Delete(long phoneId)
    {
        var phone = _context.Phones.Find(phoneId);
        _context.Phones.Remove(phone!);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(long id)
    {
        var phone = _context.Phones.Find(id);
        if (phone != null)
        {
            var editPhoneVm = PhoneFormVm.FromModel(phone);
            editPhoneVm.Brands = _context.Brands
                .Select(b => b.ToViewModel())
                .ToList();

            return View(editPhoneVm);
        }

        return View();
    }

    [HttpPost]
    public IActionResult Edit(PhoneFormVm formVm)
    {
        var phone = formVm.ToModel();
        _context.Phones.Update(phone);

        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}