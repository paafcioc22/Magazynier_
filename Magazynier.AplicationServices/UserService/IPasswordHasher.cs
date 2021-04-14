using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices
{
    public interface IPasswordHasher<TUser> where TUser : class
    {
        string HashPassword(TUser user, string password);
        PasswordVerificationResult VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword);
    }
}
