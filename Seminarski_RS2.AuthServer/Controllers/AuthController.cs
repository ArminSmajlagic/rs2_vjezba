using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Seminarski_RS2.AuthServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using IdentityServer4;
using AuthServer.SecurityConfig;

namespace Seminarski_RS2.AuthServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IdentityServerTools _tools;

        public AuthController(SignInManager<ApplicationUser> manager1, UserManager<ApplicationUser> manager2,IdentityServerTools tools)
        {
            _signInManager = manager1;
            _userManager = manager2;
            _tools = tools;
        }
       public async Task<IActionResult> Login(AuthRequest req)
        {   
            var result = await _signInManager.PasswordSignInAsync(req.username, req.password, false, lockoutOnFailure: true);
            var res = new AuthRes() { 
                Result=result.Succeeded,
                IsLockedOut=result.IsLockedOut,
                IsNotAllowed= result.IsNotAllowed,
                RequiresTwoFactor= result.RequiresTwoFactor,
                Username= req.username,
            };

            if (result.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(req.username);
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,req.username)
                };

                res.Token = await _tools.IssueClientJwtAsync("desk_cli_1", 3600, scopes:new[] { "TheMainApi" },audiences:new[] {"TheMainApi" },additionalClaims:claims);

                return Ok(res);
            }
            return BadRequest("Log in failed");
        }
    }
}
