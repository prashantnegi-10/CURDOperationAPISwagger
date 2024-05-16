using Microsoft.EntityFrameworkCore;

namespace CURDOperationAPISwagger.Model
{
    public class BrandContext : DbContext
    {
        public BrandContext(DbContextOptions<BrandContext> options) : base(options)
            { 

        
        }

     public   DbSet<Brand> Brands { get; set; }




    }
}
