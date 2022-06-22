using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class Tbllogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Isadmin { get; set; }
    }
}
