using LolaSoft.WebShop.DataAccess;
using LolaSoft.WebShop.DataAccess.Repositories;
using LolaSoft.WebShop.Services.Dto;
using LolaSoft.WebShop.Services.Mappers;
using System;

namespace LolaSoft.WebShop.Services.Services
{
    public interface IRoleService 
    {
        RoleDto GetById(int id);
        void Add(RoleDto entity);
    }

    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        private readonly WebShopDbContext context;

        public RoleService(IRoleRepository roleRepository, 
                           WebShopDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.roleRepository = roleRepository ?? throw new ArgumentNullException(nameof(roleRepository));
        }
        public void Add(RoleDto entity)
        {
            roleRepository.Add(RoleMapper.ToModel(entity));
            context.SaveChanges();
        }

        public RoleDto GetById(int id)
        {
            return RoleMapper.ToDto(roleRepository.Get(id));
        }
    }
}
