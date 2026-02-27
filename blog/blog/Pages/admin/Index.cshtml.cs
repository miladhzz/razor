using blog.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Pages.admin
{
  public class IndexModel : PageModel
  {
    private readonly IUserService _userService;
    public IndexModel(IUserService userService)
    {
      _userService = userService;
    }

    public async Task OnGetAsync()
    
    {
      //Users = await _userService.GetAll();
    }
  }
}
