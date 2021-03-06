using Microsoft.AspNetCore.Mvc;
using NLayer.BLL.Service;
using NLayer.DAL.Models;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        #region Fields

        private readonly ICrudService<Category> _categoryService;

        #endregion

        #region Constructors

        public CategoryController(ICrudService<Category> categoryService)
        {
            _categoryService = categoryService;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Tüm kategorileri getiren metot
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _categoryService.GetAll();
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        /// <summary>
        /// Ürünü id ye göre getiren metot
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _categoryService.GetById(id);
            return new ObjectResult(response) { StatusCode = response.Status };
        }

        /// <summary>
        /// Kategori ekleyen metot
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        [HttpPost]
        public Task Post([FromBody] Category Category)
        {
            return _categoryService.Add(Category);
        }

        /// <summary>
        /// Kategori güncelleyen metot
        /// </summary>
        /// <param name="Category"></param>
        /// <returns></returns>
        [HttpPut]
        public Task Put([FromBody] Category Category)
        {
            return _categoryService.Edit(Category);
        }

       /// <summary>
       /// Kategori silen metot
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return _categoryService.Del(id);
        }
        #endregion
    }
}
