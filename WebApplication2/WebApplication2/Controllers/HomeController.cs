using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
       // public List<Sample1> Get()
       // {
       //     SampleDb1Context db = new SampleDb1Context();
        //   return db.Sample1s.ToList();
       // }
       public List<Employee> Get()
        {
            SampleDb1Context db = new SampleDb1Context();
            return db.Employees.ToList();

        }
    }
}
