namespace JwtAuthenticationTool.Models.Interfaces{
    
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