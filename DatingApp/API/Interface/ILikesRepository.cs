using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entites;
using API.Helpers;

namespace API.Interface
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}