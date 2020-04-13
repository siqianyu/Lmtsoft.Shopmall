using Lmtsoft.Shopmall.Common;
using Lmtsoft.Shopmall.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lmtsoft.Shopmall.Web.Controllers
{

    /// <summary>
    /// 用户验证登录
    /// </summary>
    [Route("auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        public AuthenticateController(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        public IConfiguration Configuration { get; }


        //BaseManager loginUser
        [HttpPost("token", Name = nameof(GenrateToken))]
        public IActionResult GenrateToken(BaseManager loginUser)
        {
            if (loginUser.UserName != "demo" || loginUser.Password != "password")
            {
                return Unauthorized();
            }

            //验证成功 登录系统

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, loginUser.UserName)
            };
            var tokenConfigSection = Configuration.GetSection("Security:Token");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenConfigSection["Key"]));
            var signCredential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken(
                issuer: tokenConfigSection["Issuer"],
                audience: tokenConfigSection["Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Utils.ObjToInt(tokenConfigSection["Expires"], 3)),
                signingCredentials: signCredential
                );
            return Ok(
                new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    expiration = TimeZoneInfo.ConvertTimeFromUtc(jwtToken.ValidTo, TimeZoneInfo.Local)
                }
                );
        }
    }
}
