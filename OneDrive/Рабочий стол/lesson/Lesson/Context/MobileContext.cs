using Lesson.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson.Context;

public class MobileContext : DbContext
{
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Brand> Brands { get; set; }

    public MobileContext(DbContextOptions<MobileContext> options) 
        : base(options)
    {
        
    }
}