using Dapper.Application.Interfaces;
using Dapper.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Dapper.Webapi.Controllers
{
    /// <summary>
    /// Product Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _unitOfWork.Products.GetAllAsync();
            return Ok(data);
        }
        /// <summary>
        /// Get product by Id
        /// </summary>
        /// <param name="id">product id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _unitOfWork.Products.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }
        /// <summary>
        /// Add new product
        /// </summary>
        /// <param name="product">new product</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(ProductRequest product)
        {
            var data = await _unitOfWork.Products.AddAsync(product);
            return Ok(data);
        }
        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id">product Id</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _unitOfWork.Products.DeleteAsync(id);
            return Ok(data);
        }
        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">product</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(ProductRequest product)
        {
            var data = await _unitOfWork.Products.UpdateAsync(product);
            return Ok(data);
        }
    }
}
