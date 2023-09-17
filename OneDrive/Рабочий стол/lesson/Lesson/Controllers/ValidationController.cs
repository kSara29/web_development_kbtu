using Lesson.Context;
using Microsoft.AspNetCore.Mvc;

namespace Lesson.Controllers;

public class ValidationController
{
    private  MobileContext _context;
    
    public ValidationController(MobileContext context)
    {
        _context = context;
    }
    
    [AcceptVerbs("GET", "POST")]
    public bool CheckName(string name)
    {
        var check = _context.Brands.Any(b => b.Name == name);
        return !check;
    }
}