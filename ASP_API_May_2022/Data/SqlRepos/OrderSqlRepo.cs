using ASP_API_May_2022.Data.Interfaces;
using ASP_API_May_2022.ModelDto;
using System.Collections.Generic;
using System.Linq;

namespace ASP_API_May_2022.Data.SqlRepos
{
    public class OrderSqlRepo : IOrdersRepo
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public OrderSqlRepo(AppDbContext context)
        {
            _context = context;
        }
        public List<OrderReadDto> GetAll()
        {
            var orders = _context.Orders
                .Select(o => _mapper.Map(o))
                .ToList();
            var orderProducts = _context.OrderProducts.ToList();
            var products = _context.Products.ToList();

            foreach (var order in orders)
            {
                List<ProductReadDto> productToAdd = 
                    new List<ProductReadDto>();

                foreach (var op in orderProducts)
                {
                    if (op.OrderId == order.Id)
                    {
                        ProductReadDto prod =
                            _mapper.Map( products.FirstOrDefault(p => p.Id == op.Id));
                        productToAdd.Add(prod);
                    }
                }
                order.Products = productToAdd;
            }

            return orders;
        }
    }
}
