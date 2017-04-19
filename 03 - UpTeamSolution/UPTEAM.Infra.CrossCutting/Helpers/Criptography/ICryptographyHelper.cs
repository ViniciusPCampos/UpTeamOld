namespace UPTEAM.Infra.CrossCutting.Helpers.Criptography
{
    public interface ICryptographyHelper
    {
        string CreateHash(string password);
        bool ValidatePassword(string password, string correctHash);
    }
}
