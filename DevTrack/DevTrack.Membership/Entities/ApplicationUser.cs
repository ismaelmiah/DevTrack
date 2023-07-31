﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTrack.Membership.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string ImageUrl { get; set; }
        public string FullName { get; set; }

        public ApplicationUser() : base()
        {

        }

        public ApplicationUser(string userName) : base(userName)
        {

        }
    }
}
