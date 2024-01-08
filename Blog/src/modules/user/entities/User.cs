using Blog.src.modules.role;
using Dapper.Contrib.Extensions;

namespace Blog.src.modules.user.entities
{
  [Table("[User]")]
  public class User
  {
    public User() => Roles = [];
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public string Slug { get; set; }

    [Write(false)]
    public List<Role> Roles { get; set; }

  }
}
