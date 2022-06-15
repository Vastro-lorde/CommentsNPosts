using CommentsNPosts.Models;

namespace CommentsNPosts.Repo
{
    public interface IUserRepo
    {
        Task<bool> CreateUser(User user);
        Task<User> GetById(Guid id);
        Task<IEnumerable<User>> GetUsers();
    }
}