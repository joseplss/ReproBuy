using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reproBuy.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "You want to sell something, right? The price of your product is required!")]
        public double Price { get; set; }
        [Required(ErrorMessage = "How are people going to find it? The name of your product is required!")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "They need to know what kind of item they are buying! The category of your product is required!")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "You have atleast one thing to sell, The amount you are going to sell is required!")]
        public int StockAmount { get; set; }
        public string AccountUser { get; set; }
        public string ProductDesc { get; set; }
        public string ImageTitle { get; set; }
        [DisplayName("Upload File")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public Product()
        {
        }
    }
}
