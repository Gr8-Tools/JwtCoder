namespace JwtAuthenticationTool.Models.Interfaces{
    
    /// <summary>
    /// Ответ аутентификации
    /// </summary>
    public interface IAuthenticateResponse {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Токен
        /// </summary>
        string Token { get; }
    }
}