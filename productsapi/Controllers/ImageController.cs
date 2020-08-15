using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsapi.Repositories;

namespace productsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IImageRepo _repo;
        private readonly IMapper _mapper;
        public ImageController(IImageRepo repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
            

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }




    }
}
