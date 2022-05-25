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


    }
}
