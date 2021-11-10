using JwtAuthenticationTool.Entities.Intrefaces;
using JwtAuthenticationTool.Models;
using JwtAuthenticationTool.Models.Interfaces;
using System.Threading.Tasks;

namespace JwtAuthenticationTool.Services.Interfaces
{
    public interface IUserService {
        /// <summary>
        /// Returns Authenticate result
        /// </summary>
        Task<IAuthenticateResponse> Authenticate(IAuthenticateRequest model);
        
        /// <summary>
        /// Returns user by it's ID
        /// </summary>
        Task<IUserEntity> GetById(int id);
    }
}
