using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebQuery.Models;

namespace WebQuery.Models
{
    public class dbContext : DbContext
    {

     
        public dbContext (DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WebQuery.Models.Animal> animal { get; set; }
        
        public virtual DbSet<WebQuery.Models.Animal_class> animal_class { get; set; }
    }
}
