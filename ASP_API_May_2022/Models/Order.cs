using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_API_May_2022.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
