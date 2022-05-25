using ASP_API_May_2022.Data.Interfaces;
using ASP_API_May_2022.ModelDto;
using ASP_API_May_2022.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_API_May_2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducsController : ControllerBase
    {
        private readonly IProductRepo _productRepo;

        public ProducsController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        // GET: api/<ProducsController>
        [HttpGet]
        public IEnumerable<ProductReadDto> Get()
        {
            return _productRepo.GetAll();
        }

        // GET api/<ProducsController>/5
        [HttpGet("{id}")]
        public ActionResult<ProductReadDto> Get(int id)
        {
            var res = _productRepo.GetById(id);

            if (res != null)
            {
                return res;
            }

            return NotFound();
        }

        // POST api/<ProducsController>
        [HttpPost]
        public void Post([FromBody] ProductCreateDto value)
        {
        }

        // PUT api/<ProducsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProducsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
