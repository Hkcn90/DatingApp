using API.Entites;

namespace API.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}