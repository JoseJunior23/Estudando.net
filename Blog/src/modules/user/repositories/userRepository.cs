using Blog.src.modules.role;
using Blog.src.modules.user.entities;
using Blog.src.shared;
using Blog.src.shared.repositories;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.src.modules.user.repositories
{
  public class UserRepository : Repository<User>
  {
    public UserRepository(SqlConnection connection)
    : base(connection)
   => Database.connection = connection;

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
      var items = Database.connection.Query<User, Role, User>(
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