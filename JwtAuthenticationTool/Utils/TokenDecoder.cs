using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using JwtAuthenticationTool.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationTool.Utils {
    internal class TokenDecoder {
        private readonly byte[] _byteSecret;

        internal TokenDecoder(string secret) {
            _byteSecret = Encoding.ASCII.GetBytes(secret);
        }

        internal void AttachUserToContext(HttpContext context, IUserService userService) {
            try
            {
                var token = context.GetToken();
                if (string.IsNullOrEmpty(token)) {
                    return;
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(_byteSecret),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

                // attach user to context on successful jwt validation
                context.SaveUser(userService.GetById(userId).GetAwaiter().GetResult());
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }
        }
    }
}
