using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_DATA_TABLE_AJAX.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_DATA_TABLE_AJAX.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}