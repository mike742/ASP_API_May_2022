using ASP_API_May_2022.Data.Interfaces;
using ASP_API_May_2022.ModelDto;
using ASP_API_May_2022.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASP_API_May_2022.Data.SqlRepos
{
    public class ProductSqlRepo : IProductRepo
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public ProductSqlRepo(AppDbContext context)
        {
            _context = context;
        }
        public List<ProductReadDto> GetAll()
        {
            return _context.Products
                .Select(p => _mapper.Map(p))
                .ToList();
        }

        public ProductReadDto GetById(int id)
        {
            var res = _context.Products
                .FirstOrDefault(p => p.Id == id);

            if (res != null)
            {
                return _mapper.Map(res);
            }
            return null;
        }
    }
}
