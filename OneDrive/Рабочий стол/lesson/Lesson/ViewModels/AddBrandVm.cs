using System.ComponentModel.DataAnnotations;
using Lesson.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson.ViewModels;

public class AddBrandVm
{
    [Remote(action: "CheckName", controller: "Validation", ErrorMessage ="Бренд уже существует!")]
    public string Name { get; set; }
    public string Link { get; set; }
    
    [EmailAddress(ErrorMessage ="Введите корректный формат почты!")]
    public string Email { get; set; }
    
    public string CreatedAt { get; set; }

    public Brand ToModel()
    {
        return new Brand
        {
            Link = Link,
            Name = Name,
            Email = Email,
            CreatedAt = CreatedAt
        };
    }
}