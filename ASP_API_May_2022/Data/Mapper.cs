using ASP_API_May_2022.ModelDto;
using ASP_API_May_2022.Models;

namespace ASP_API_May_2022.Data
{
    public class Mapper
    {
        public ProductReadDto Map(Product value)
        {
            return new ProductReadDto 
            {
                Id = value.Id,
                Name = value.Name,
                Price = value.Price
            };
        }

        public OrderReadDto Map(Order value)
        {
            return new OrderReadDto { 
                Date = value.Date,
                Id = value.Id,
                Name = value.Name
            };
        }
        public Product Map(ProductCreateDto value)
        {
            return new Product
            {
                Name = value.Name,
                Price = value.Price
            };
        }

    }
}
