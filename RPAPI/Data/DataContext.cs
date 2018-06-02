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
}
