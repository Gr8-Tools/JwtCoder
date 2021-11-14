using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationTool.Configurations;
using JwtAuthenticationTool.Entities.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationTool.Utils {
    public class TokenEncoder {
        private readonly byte[] _byteSecret;
        
        public TokenEncoder(IOptions<AppSettings> appSettings) {
            _byteSecret = Encoding.ASCII.GetBytes(appSettings.Value.Secret);    
        }
        
        public string GetJwtToken(IUserEntity user) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(_byteSecret), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}