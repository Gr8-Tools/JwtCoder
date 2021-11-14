namespace JwtAuthenticationTool.Models.Interfaces {
    /// <summary>
    /// ������ ��������������
    /// </summary>
    public interface IAuthenticateRequest {
        /// <summary>
        /// ��� ��������
        /// </summary>
        string LicenceCode { get; }

        /// <summary>
        /// ������
        /// </summary>
        string Password { get; }
    }
}