using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Areas.Identity
{
    public class MyIdentityuser : IdentityUser
    {
        public DateTime DateOfReg { get; set; }
        public DateTime DateOfLastLogin { get; set; }
        public bool isBaned { get; set; }
    }
}
