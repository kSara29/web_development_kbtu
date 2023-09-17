using Lesson.Models.Common;

namespace Lesson.Models;

public class Order : Entity
{
    public required string Name { get; set; }
    public required string Address { get; set; }
    public required string ContactPhone { get; set; }
    
    public long PhoneId { get; set; }
    public Phone Phone { get; set; }
}