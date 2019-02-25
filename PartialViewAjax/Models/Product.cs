using System.ComponentModel.DataAnnotations;

namespace PartialViewAjax.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int OHQuantity { get; set; }



    }
}