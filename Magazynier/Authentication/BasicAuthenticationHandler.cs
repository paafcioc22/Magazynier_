 
 
using Magazynier.DataAccess;
using Magazynier.DataAccess.CQRS.Queries; 
using Magazynier.DataAccess.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Magazynier.Authentication
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly IQueryExecutor queryExecutor;

        public BasicAuthenticationHandler(
            IPasswordHasher<User> passwordHasher,
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IQueryExecutor queryExecutor)
            : base(options, logger, encoder, clock)
        {
            this.passwordHasher = passwordHasher;
            this.queryExecutor = queryExecutor;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            // skip authentication if endpoint has [AllowAnonymous] attribute
            var endpoint = Context.GetEndpoint();
            if (endpoint?.Metadata?.GetMetadata<IAllowAnonymous>() != null)
            {
                return AuthenticateResult.NoResult();
            }

            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing Authorization Header");
            }

            User user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                var username = credentials[0];
                var password = credentials[1];
                var query = new GetUserQuery()
                {
                    Username = username
                };
                user = await this.queryExecutor.Execute(query);



                var isCorr = passwordHasher.VerifyHashedPassword(user, user.Password, password);

                // TODO: HASH!
                if (user == null || isCorr == PasswordVerificationResult.Failed)
                {
                    return AuthenticateResult.Fail("Invalid Authorization Header");
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
            };
            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return AuthenticateResult.Success(ticket);
        }


        //string HashPass(string password)
        //{


        //    //string password = Console.ReadLine();

        //    // generate a 128-bit salt using a secure PRNG
        //    byte[] salt = new byte[128 / 8];
        //    using (var rng = RandomNumberGenerator.Create())
        //    {
        //        rng.GetBytes(salt);
        //    }


        //    // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
        //    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
        //        password: password,
        //        salt: salt,
        //        prf: KeyDerivationPrf.HMACSHA1,
        //        iterationCount: 10000,
        //        numBytesRequested: 256 / 8));


             

        //    return hashed;
        //}

    }
}
