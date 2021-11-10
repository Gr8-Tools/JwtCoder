using JwtAuthenticationTool.Configurations.Interfaces;
using JwtAuthenticationTool.Services.Interfaces;
using JwtAuthenticationTool.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationTool.Middlewares {
    public class JwtMiddleware {
        private readonly RequestDelegate _next;
        private readonly TokenProcessor tokenProcessor;

        public JwtMiddleware(RequestDelegate next, IOptions<IAppSettings> appSettings)
        {
            _next = next;
            tokenProcessor = new TokenProcessor(appSettings.Value.Secret);
        }

        public async Task Invoke(HttpContext context, IUserService userService) {
            tokenProcessor.AttachUserToContext(context, userService);

            await _next(context);
        }
    }
}