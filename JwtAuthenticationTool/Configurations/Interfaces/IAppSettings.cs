using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationTool.Configurations.Interfaces {
    /// <summary>
    /// Интерфейс конфигурации, обязхывающий реализовать Secret
    /// </summary>
    public interface IAppSettings {
        /// <summary>
        /// Секрет
        /// </summary>
        public string Secret { get; }
    }
}
