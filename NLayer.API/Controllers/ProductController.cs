using Microsoft.AspNetCore.Mvc;
using NLayer.BLL.Service;
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

        /// <summary>
        /// Tüm ürünleri listeleyen metot
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAll();
        }

        /// <summary>
        /// Ürünü id ye göre getiren metot
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _productService.GetById(id);
        }

        /// <summary>
        /// Ürün ekleyen metot
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public Task Post([FromBody] Product product)
        {
            return _productService.Add(product);
        }

       /// <summary>
       /// Ürün güncelleyen metot
       /// </summary>
       /// <param name="product"></param>
       /// <returns></returns>
        [HttpPut]
        public Task Put([FromBody] Product product)
        {
            return _productService.Edit(product);
        }

       /// <summary>
       /// Ürün silen metot
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return _productService.Del(id);
        }
        #endregion
    }
}
