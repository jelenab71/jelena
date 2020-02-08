using LolaSoft.WebShop.DataAccess.Models;
using LolaSoft.WebShop.Services.Dto;

namespace LolaSoft.WebShop.Services.Mappers
{
    public class UserMapper
    {
        public static User ToModel(UserDto userDto)
        {
            if (userDto == null)
                return null; 

            return new User()
            {
                Id = userDto.Id,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email

            };
        }

        public static UserDto ToDto(User user)
        {
            if (user == null)
                return null;

            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}
