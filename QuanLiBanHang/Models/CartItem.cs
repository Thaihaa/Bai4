using System.ComponentModel.DataAnnotations;

namespace QuanLiBanHang.Models
{
    public class CartItem
    {
        [Key]
        public int ProductId { get; set; }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
