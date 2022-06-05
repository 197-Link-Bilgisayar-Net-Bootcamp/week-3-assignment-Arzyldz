using CrudOperations.API.Service;
using Microsoft.AspNetCore.Mvc;
using NLayer.DAL.Models;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Fields

        private readonly ICrudService<Product> _productService;

        #endregion

        #region Constructors

        public ProductController(ICrudService<Product> productService)
        {
            _productService = productService;
        }

        #endregion

        #region Methods

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _productService.GetById(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public Task Post([FromBody] Product product)
        {
            return _productService.Add(product);
        }

        // PUT api/<ProductController>
        [HttpPut]
        public Task Put([FromBody] Product product)
        {
            return _productService.Edit(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return _productService.Del(id);
        }
        #endregion
    }
}
