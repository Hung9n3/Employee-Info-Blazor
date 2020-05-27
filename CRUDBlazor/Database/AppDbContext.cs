using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDBlazor.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUDBlazor.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
        public DbSet<EmployeeInfo> Employees { get; set;}
    }
}
