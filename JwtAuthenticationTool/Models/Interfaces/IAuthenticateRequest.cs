namespace JwtAuthenticationTool.Models.Interfaces {
    /// <summary>
    /// Запрос аутентификации
    /// </summary>
    public interface IAuthenticateRequest {
        /// <summary>
        /// Код лицензии
        /// </summary>
        string LicenceCode { get; }

        /// <summary>
        /// Пароль
        /// </summary>
        string Password { get; }
    }
}