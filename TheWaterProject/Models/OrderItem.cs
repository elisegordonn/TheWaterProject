using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheWaterProject.Models;

public class OrderItem
{
    [Key]
    public int OrderItemID { get; set; }
    [ForeignKey("OrderID")]
    public int OrderID { get; set; }
    [ForeignKey("ProjectID")]
    public int ProjectID { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}