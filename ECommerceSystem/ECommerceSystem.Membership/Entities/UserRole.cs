using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ECommerceSystem.Membership.Entities
{
    public class UserRole
        : IdentityUserRole<Guid>
    {
       
    }
}
