using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassDemo1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Category is required")]
        public string Category { set; get; }
        public decimal AmountDue
        {
            get
            {
                return Quantity * Price;
            }
        }


    }
}
