using System;
using System.Collections.Generic;

namespace ASP_API_May_2022.ModelDto
{
    public class OrderReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<ProductReadDto> Products { get; set; }
    }
}
