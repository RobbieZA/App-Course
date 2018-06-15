using Microsoft.EntityFrameworkCore;
using RPAPI.Models;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Value> Values { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<photo> Photos {get; set;}
    //public DbSet<GeoCoordinate> GeoCoordinates { get; set; }
    //public DbSet<Store> Stores {get; set;}
    //public DbSet<Task> Tasks { get; set; }
    //public DbSet<RetailBrand> RetailBrands { get; set; }

}
