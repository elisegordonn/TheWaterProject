using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TheWaterProject.Models {

    public class Order {
        
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<Cart.CartLine> Lines { get; set; } 
            = new List<Cart.CartLine>();
        public string username { get; set; }
                        
        [Required(ErrorMessage = "Please enter a name")]
        public string? Name { get; set; }
                
        [Required(ErrorMessage = "Please enter the first address line")]
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
                
        [Required(ErrorMessage = "Please enter a city name")]
        public string? City { get; set; }
                
        [Required(ErrorMessage = "Please enter a state name")]
        public string? State { get; set; }
                
        public string? Zip { get; set; }
        
        [Required(ErrorMessage = "Please enter a country name")]
        public string? Country { get; set; }
        
        [Required(ErrorMessage = "Please enter an email")]
        public string? Email { get; set; }

        public bool? EmailUpdates { get; set; } = false;
    }
}