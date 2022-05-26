using ASP_API_May_2022.ModelDto;
using ASP_API_May_2022.Models;
using System.Collections.Generic;

namespace ASP_API_May_2022.Data.Interfaces
{
    public interface IProductRepo
    {
        public List<ProductReadDto> GetAll();
        public ProductReadDto GetById(int id);
        public void Create(ProductCreateDto input);
        public void Update(int id, ProductCreateDto input);
        public void Delete(int id);
    }
}
