using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
