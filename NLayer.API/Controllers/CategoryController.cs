using CrudOperations.API.Service;
using Microsoft.AspNetCore.Mvc;
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

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categoryService.GetAll();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<Category> Get(int id)
        {
            return await _categoryService.GetById(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public Task Post([FromBody] Category Category)
        {
            return _categoryService.Add(Category);
        }

        // PUT api/<CategoryController>
        [HttpPut]
        public Task Put([FromBody] Category Category)
        {
            return _categoryService.Edit(Category);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            return _categoryService.Del(id);
        }
        #endregion
    }
}
