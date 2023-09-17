using System.Net.Mime;
using Lesson.Models;

namespace Lesson.ViewModels;

public class PhoneFormVm
{
    public long Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string? DisplayType { get; set; }
    public short? Ram { get; set; }
    public short? BatteryCapacity { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public long? BrandId { get; set; }
    public List<BrandVm> Brands { get; set; }
    public List<Currency> CurrencyRates { get; set; }
    
    public Phone ToModel()
    {
        return new Phone
        {
            Id = Id,
            Price = Price,
            BatteryCapacity = BatteryCapacity,
            Title = Title,
            DisplayType = DisplayType,
            Description = Description,
            BrandId = BrandId,
            Ram = Ram,
            Image = Image
        };
    }

    public static PhoneFormVm FromModel(Phone phone)
    {
        return new PhoneFormVm
        {
            Ram = phone.Ram,
            Description = phone.Description,
            DisplayType = phone.DisplayType,
            BatteryCapacity = phone.BatteryCapacity,
            Title = phone.Title,
            BrandId = phone.BrandId,
            Price = phone.Price,
            Id = phone.Id,
            Image = phone.Image
        };
    }
}