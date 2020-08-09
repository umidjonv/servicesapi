using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsapi.Data;
using productsapi.DTO;
using productsapi.Helpers;
using productsapi.Models;
using productsapi.Repositories;

namespace productsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repo;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;

        }

        [HttpGet]

        public IActionResult GetAll()
        {
            IEnumerable<Category> categories = _repo.GetAll();

            IEnumerable<CategoryReadDTO> readCat = _mapper.Map<IEnumerable<CategoryReadDTO>>(categories);

            return Ok(readCat);

        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        
        public IActionResult AddNew(CategoryWriteDTO category)
        {
            
            if (category != null)
            {
                Category parent;
                if (category.parent_id != null)
                    category.parent = _repo.GetOneById(category.parent_id);
                Category cat = _mapper.Map<Category>(category);
                _repo.Add(cat);
                _repo.SaveChanges();
                return CreatedAtRoute("{id}", cat.id);
            }
            else { return BadRequest(); }

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOnById(Guid id)
        {
            Category category = _repo.GetOneById(id);

            if (category != null)
            {
                CategoryReadDTO readCat = _mapper.Map<CategoryReadDTO>(category);
                return Ok(readCat);
            }
            return NotFound();


        }

    }
}
