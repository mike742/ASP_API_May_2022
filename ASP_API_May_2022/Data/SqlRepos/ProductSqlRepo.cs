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

        public void Create(ProductCreateDto input)
        {
            _context.Products.Add( _mapper.Map(input) );
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var res = _context.Products
                    .FirstOrDefault(p => p.Id == id);

            if (res != null)
            {
                _context.Remove(res);
                _context.SaveChanges();
            }
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

        public void Update(int id, ProductCreateDto input)
        {
            var res = _context.Products
                .FirstOrDefault(p => p.Id == id);

            if (res != null)
            {
                res.Name = input.Name;
                res.Price = input.Price;

                _context.SaveChanges();
            }
        }
    }
}
