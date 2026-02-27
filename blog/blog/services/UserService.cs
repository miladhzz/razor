using blog.Data;
using Microsoft.EntityFrameworkCore;

namespace blog.services
{
  public class UserService : IUserService
  {
    private readonly AppDbContext _context;
    public UserService(AppDbContext context)
    {
      _context = context;
    }
    //public async Task<List<User>> GetAll()
    //{
    //  return await _context.Users.ToListAsync();
    //}
  }
}
