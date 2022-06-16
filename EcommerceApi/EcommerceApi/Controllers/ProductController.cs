using EcommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceContext ec;
        public ProductController(EcommerceContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ec.Products;
        }
        [HttpPost]
        public string Post([FromBody] Product user)
        {
            ec.Products.Add(user);
            ec.SaveChanges();
            return "success";
        }
    }
}
