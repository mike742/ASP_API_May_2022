using ASP_API_May_2022.ModelDto;
using System.Collections.Generic;

namespace ASP_API_May_2022.Data.Interfaces
{
    public interface IOrdersRepo
    {
        public List<OrderReadDto> GetAll();
    }
}
