using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entities.Concreate;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            //return new List<Product>
            //{
            //    new Product{ProductId=1,CategoryId=1, ProductName="Bag",UnitPrice=45,UnitsInStock=900},
            //    new Product{ProductId=2,CategoryId=2, ProductName="Camera",UnitPrice=1500,UnitsInStock=150},
            //    new Product{ProductId=3,CategoryId=1, ProductName="Macbook",UnitPrice=1450,UnitsInStock=250},
            //    new Product{ProductId=4,CategoryId=1, ProductName="Pencil",UnitPrice=10,UnitsInStock=200},
            //    new Product{ProductId=5,CategoryId=1, ProductName="Book",UnitPrice=15,UnitsInStock=400},
            //};

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpGet("getbyid") ]
        public IActionResult Get(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else { return BadRequest(result); }
        }


        [HttpPost]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success) { return Ok(result); }
            else { return BadRequest(result); }
        }



    }
}

