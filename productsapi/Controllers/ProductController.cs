using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsapi.DTO;
using productsapi.Models;
using productsapi.Repositories;

namespace productsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;
        private readonly ICategoryRepo _catrepo;
        private readonly IMapper _mapper;
        public ProductController(IProductRepo repo, ICategoryRepo catrepo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
            _catrepo = catrepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Product> products = _repo.GetAll();
            IEnumerable<ProductReadDTO> productDto = _mapper.Map<IEnumerable<ProductReadDTO>>(products);

            return Ok(productDto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public IActionResult AddNew(ProductWriteDTO product)
        {
            if (product != null)
            {
                if (product.category_id != null)
                {
                    product.category = _catrepo.GetOneById(product.category_id);
                    Product productNew = _mapper.Map<Product>(product);
                    _repo.Add(productNew);
                    if (_repo.SaveChanges() > 0)
                        return Ok("created");
                    
                }
            }
            return BadRequest();

        }
    }
}
