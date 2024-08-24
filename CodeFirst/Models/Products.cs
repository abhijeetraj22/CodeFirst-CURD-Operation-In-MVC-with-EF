using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name Required")]
        [DisplayName("Product Name")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Qty is Required")]
        public int Qty { get; set; }

        public string Remarks { get; set; }
    }

    public class EFCodeFirstEntities : DbContext
    {
        public EFCodeFirstEntities(DbContextOptions<EFCodeFirstEntities> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }
    }
}
