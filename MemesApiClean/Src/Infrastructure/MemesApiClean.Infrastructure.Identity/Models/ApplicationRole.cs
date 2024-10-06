using Microsoft.AspNetCore.Identity;
using System;

namespace MemesApiClean.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
