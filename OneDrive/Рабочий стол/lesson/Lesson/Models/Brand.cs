using Lesson.Models.Common;
using Lesson.ViewModels;

namespace Lesson.Models;

public class Brand : Entity
{
    public string Name { get; set; }
    public string Link { get; set; }
    public string Email { get; set; }
    public string CreatedAt { get; set; }

    public BrandVm ToViewModel()
    {
        return new BrandVm
        {
            Name = Name,
            Link = Link,
            Id = Id,
            Email = Email,
            CreatedAt = CreatedAt
        };
    }
}