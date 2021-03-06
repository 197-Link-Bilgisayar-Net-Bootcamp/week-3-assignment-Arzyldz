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
        public async Task<IActionResult> Get()
        {
            var response =await _productService.GetAll();
            return new ObjectResult(response){ StatusCode=response.Status};
        }

        /// <summary>
        /// En ucuz 5 ürünü listeleyen metot
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCheapProductTop5()
        {
            return (IActionResult)((ProductService)_productService).GetCheapProductTop5();
            
        }
        /// <summary>
        /// Ürünü id ye göre getiren metot
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _productService.GetById(id);
            return new ObjectResult(response) { StatusCode = response.Status };
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
