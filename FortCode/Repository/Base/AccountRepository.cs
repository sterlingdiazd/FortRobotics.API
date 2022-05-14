using FortCode.Data;
using FortCode.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FortCode.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountRepository(UserManager<UserModel> userManager,
            SignInManager<UserModel> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel signUpModel)
        {
            var user = new UserModel()
            {
                Name = signUpModel.Name,
                Email = signUpModel.Email,
                UserName = signUpModel.Email
            };

            return await _userManager.CreateAsync(user, signUpModel.Password);
        }

        public async Task<string> LoginAsync(SignInModel signInModel)
        {
            var result = await _signInManager.PasswordSignInAsync(signInModel.Email, signInModel.Password, false, false);

            if (!result.Succeeded)
            {
                return null;
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, signInModel.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var authSigninKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //public async string GetLoggedUserByToken(string token)
        //{
        //    var claimsIdentity = this._signInManager.GetExternalLoginInfoAsync();
        //        .Identity as ClaimsIdentity;
        //    var userId = claimsIdentity.FindFirst(ClaimTypes.Name)?.Value;

        //}


        //public async Task<int> AddFavoriteCityAsync(CityModel cityModel, int idUser) //
        //{
        //    var city = new Cities()
        //    {
        //        Name = cityModel.Name,
        //        Country = cityModel.Country
        //    };

        //    _context.Cities.Add(city);
        //    await _context.SaveChangesAsync();

        //    return city.IdCity;
        //}
    }
}
