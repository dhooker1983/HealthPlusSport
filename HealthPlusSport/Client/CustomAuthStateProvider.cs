using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace HealthPlusSport.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anon = new ClaimsIdentity(new List<Claim>
                { new Claim(ClaimTypes.Name, "David Hooker"),
                  new Claim(ClaimTypes.Email, "dhooker@sky.com"),
                  new Claim(ClaimTypes.DateOfBirth, DateTime.Now.ToShortDateString())
                }, "JwtBearer");

            var principal = new ClaimsPrincipal(anon);

            return await Task.FromResult(new AuthenticationState(principal));
        }
    }
}
