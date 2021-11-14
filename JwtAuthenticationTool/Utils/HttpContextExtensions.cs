using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JwtAuthenticationTool.Entities.Interfaces;

namespace JwtAuthenticationTool.Utils {
    public static class HttpContextExtensions {
        /// <summary>
        /// Получает пользователя из заголовка
        /// </summary>
        public static IUserEntity? GetUser(this HttpContext context) {
            if (context.Items.TryGetValue("User", out var user)) {
                return user as IUserEntity;
            }
            return null;
        }

        /// <summary>
        /// Сохраняет пользователя в заголовок
        /// </summary>
        public static void SaveUser(this HttpContext context, IUserEntity user) {
            context.Items["User"] = user;
        }

        /// <summary>
        /// Возвращает токен из заголовка
        /// </summary>
        public static string? GetToken(this HttpContext context) {
            return context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
        }
    }
}
