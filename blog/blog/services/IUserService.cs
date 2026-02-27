using blog.Models;

namespace blog.services
{
  public interface IUserService
  {
    Task<List<User>> GetAll();
  }
}
