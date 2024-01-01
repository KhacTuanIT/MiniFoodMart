﻿using Microsoft.AspNetCore.Identity;

namespace CommonLibrary.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
