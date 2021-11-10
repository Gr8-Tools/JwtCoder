using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationTool.Entities.Intrefaces {
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
