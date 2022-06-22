using EcommerceApi.Models;
using EcommerceApi.ViewModel;
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
    public class loginController : ControllerBase
    {

        EcommerceContext ec;
        public loginController(EcommerceContext _ec)
        {
            ec = _ec;
        }

        [HttpPost]
        [Route("login")]
        public bool Login(loginViewModel loginViewModel)
        {
            if (ec.Tbllogins.Any(x => x.UserName == loginViewModel.UserName && x.Password == loginViewModel.Password))
            {
                return true;
            }
            return false;
        }
        [HttpPost]
        [Route("register")]
        public void Register(RegisterViewModel registerViewModel)
        {
            Tbllogin tblLogin = new Tbllogin();
            tblLogin.UserName = registerViewModel.UserName;
            tblLogin.Password = registerViewModel.Password;
            ec.Tbllogins.Add(tblLogin);
            ec.SaveChanges();
        }
    }
}
