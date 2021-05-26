using System.Threading.Tasks;
using API.Entites;

namespace API.Interface
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}