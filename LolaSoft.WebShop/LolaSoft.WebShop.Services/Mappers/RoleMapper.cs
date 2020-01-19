using LolaSoft.WebShop.DataAccess.Models;
using LolaSoft.WebShop.Services.Dto;

namespace LolaSoft.WebShop.Services.Mappers
{
    public class RoleMapper
    {
        public static Role ToModel(RoleDto roleDto)
        {
            return new Role()
            {
                Id = roleDto.Id,
                Name = roleDto.Name,
                Description = roleDto.Description
            };
        }

        public static RoleDto ToDto(Role role)
        {
            return new RoleDto()
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description
            };
        }
    }
}
