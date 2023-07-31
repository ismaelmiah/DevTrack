﻿using Microsoft.AspNetCore.Identity;
using System;

namespace DevTrack.Membership.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole():base()
        {

        }

        public ApplicationRole(string roleName):base(roleName)
        {

        }
    }
}
