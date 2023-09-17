using Lesson.Models;

namespace Lesson.ViewModels;

public class PhoneDetailsVm
{
    public long Id { get; set; }
    public required string Title { get; set; }
    public required string? Brand { get; set; }
    public required decimal Price { get; set; }
    public string? DisplayType { get; set; }
    public short? Ram { get; set; }
    public short? BatteryCapacity { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public List<Currency> Currency { get; set; }
    
    public static PhoneDetailsVm FromModel(Phone phone, List<Currency> currency)
    {
        return new PhoneDetailsVm
        {
            Id = phone.Id,
            Brand = phone.Brand?.Name,
            Price = phone.Price,
            Title = phone.Title,
            Description = phone.Description,
            BatteryCapacity = phone.BatteryCapacity,
            Ram = phone.Ram,
            DisplayType = phone.DisplayType,
            Image = phone.Image, 
            Currency = currency
        };
    }
}