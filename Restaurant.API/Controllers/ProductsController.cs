using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Business.Abstract;
using Restaurant.DataAccess.Concrete;
using Restaurant.DTO.DTOs.ProductDTOs;
using Restaurant.Entity.Entities;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDTO>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new RestaurantContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageURL = y.ImageURL,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.Name,
                ProductStatus = y.Status,
                CategoryName = y.Category.Name
            });
            return Ok(values.ToList());
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDTO createProductDTO)
        {
            var newProduct = _mapper.Map<Product>(createProductDTO);
            _productService.TAdd(newProduct);
            return Ok("Ürün Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            var product = _mapper.Map<Product>(updateProductDTO);
            _productService.TUpdate(product);
            return Ok("Ürün Bilgisi Güncellendi");
        }
    }
}