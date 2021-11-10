using JwtAuthenticationTool.Entities.Intrefaces;

namespace JwtAuthenticationTool.Models{
    
    /// <summary>
    /// ����� ��������������
    /// </summary>
    public interface IAuthenticateResponse {
        /// <summary>
        /// ������������� ������������
        /// </summary>
        int Id { get; }

        /// <summary>
        /// �����
        /// </summary>
        string Token { get; }
    }
}