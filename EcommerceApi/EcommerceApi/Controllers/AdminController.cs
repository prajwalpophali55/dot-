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
    public class AdminController : ControllerBase
    {
        EcommerceContext ec;
        public AdminController(EcommerceContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return ec.Admins;
        }
        [HttpPost]
        public string Post([FromBody] Admin user)
        {
            ec.Admins.Add(user);
            ec.SaveChanges();
            return "success";
        }
    }
}
