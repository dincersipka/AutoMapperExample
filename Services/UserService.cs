using AutoMapperExample.Models;

namespace AutoMapperExample.Services;

public class UserService
{
    private List<User> Users; 

    public UserService()
    {
        Users = new List<User>();

        Users.Add(
            new User()
            {
                Id=1,
                Name="Dinçer",
                Status=1,
                BirthDate=(DateTime.Parse("08/16/1999"))
            }
        );
    }

    public List<User> GetAll() => Users;
}