namespace JwtAuthenticationTool.Configurations {
    /// <summary>
    /// Интерфейс конфигурации, обязхывающий реализовать Secret
    /// </summary>
    public class AppSettings {
        /// <summary>
        /// Секрет
        /// </summary>
        public string Secret { get; set; }
    }
}
