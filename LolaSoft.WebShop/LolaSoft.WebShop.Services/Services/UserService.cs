using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LolaSoft.WebShop.Services.Services
{
    public interface IUserService
    {
        UserDto GetById(int id);
        void Add(UserDto entity);
        List<UserDto> GetAll(); 
    }
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly WebShopDbContext context;

        public UserService(IUserRepository userRepository, 
                           WebShopDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.userRepository = userRepository ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(UserDto entity)
        {
            userRepository.Add(UserMapper.ToModel(entity));
            context.SaveChanges();
        }

        public List<UserDto> GetAll()
        {
            var allUsers = userRepository.GetAll();
            return allUsers.Select(u => UserMapper.ToDto(u)).ToList();
        }

        public UserDto GetById(int id)
        {
            return UserMapper.ToDto(userRepository.Get(id));
        }
    }
}
