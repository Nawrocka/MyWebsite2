using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyWebsite.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Web.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            :base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
