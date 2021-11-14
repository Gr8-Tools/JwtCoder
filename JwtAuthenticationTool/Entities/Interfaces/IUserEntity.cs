namespace JwtAuthenticationTool.Entities.Interfaces {
    /// <summary>
    /// Сущность пользователя
    /// </summary>
    public interface IUserEntity {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int Id { get; }

        /// <summary>
        /// Код лицензии
        /// </summary>
        string LicenceCode { get; }

        /// <summary>
        /// пароль пользователя
        /// </summary>
        string Password { get;  }
    }
}
