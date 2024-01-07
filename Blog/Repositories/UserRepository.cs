using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
  public class UserRepository : Repository<User>
  {
    private readonly SqlConnection _connection;
    public UserRepository(SqlConnection connection)
    : base(connection)
   => _connection = connection;

    public List<User> GetWithRoles()
    {
      var query = @"
      SELECT
        [User].*,
        [Role].*
      FROM
        [User]
        LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
        LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id];
      ";

      var users = new List<User>();
      var items = _connection.Query<User, Role, User>(
        query,
        (user, role) =>
        {
          var userId = users.FirstOrDefault(data => data.Id == user.Id);
          if (userId == null)
          {
            userId = user;
            if (role != null)
              userId.Roles.Add(role);
            users.Add(userId);
          }
          else
            userId.Roles.Add(role);

          return user;
        }, splitOn: "Id");
      return users;
    }
  }
}