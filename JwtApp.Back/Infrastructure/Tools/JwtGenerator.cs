using JwtApp.Back.Core.Application.Dto;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtApp.Back.Infrastructure.Tools
{
    public class JwtGenerator
    {
        public static TokenResponseDto GenerateToken(CheckUserResponseDto dto)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, dto.Role));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, dto.UserName));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtDefaults.Key));
            SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            var expireDate = DateTime.UtcNow.AddDays(JwtDefaults.Expire);
            JwtSecurityToken token = new(issuer:JwtDefaults.ValidIssuer, audience:JwtDefaults.ValidAudience,
                                         claims:claims, notBefore:DateTime.UtcNow, expires:expireDate,
                                         signingCredentials:credentials);
            JwtSecurityTokenHandler handler = new();

            return new TokenResponseDto(handler.WriteToken(token), expireDate);
        }
    }
}
