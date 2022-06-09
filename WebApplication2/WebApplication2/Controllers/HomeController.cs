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
        [HttpGet]
        public List<Sample1> Get()
        {
            SampleDb1Context db = new SampleDb1Context();
            return db.Sample1s.ToList();
        }
        [HttpPost]


        public string post([FromBody] string sample)

        {
            SampleDb1Context db = new SampleDb1Context();
            Sample1 ss = new Sample1();
            ss.Text = sample;
            db.Sample1s.Add(ss);
            db.SaveChanges();
            return "Success";
        }
        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            SampleDb1Context db = new SampleDb1Context();
            var sample1Obj = db.Sample1s.Where(x => x.Id == Id).FirstOrDefault();
            if (sample1Obj!=null)
            {
                db.Sample1s.Remove(sample1Obj);
                db.SaveChanges();
                return "Success";
            }
            return "fail";
        

        }
        [HttpPut]
        public string Put([FromBody] Sample1 sampletable )
        {
            SampleDb1Context db = new SampleDb1Context();
            var sample1Obj = db.Sample1s.Where(x => x.Id == sampletable.Id);
            if (sample1Obj != null)
            {
                db.Sample1s.Update(sampletable);
                db.SaveChanges();
                return "Success";
            }
            return "fail";


        }








    }
}
