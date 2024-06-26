﻿using ApiBasic.ApplicationServices.UserModule.Dtos;
using ApiBasic.Shared.Shared;

namespace ApiBasic.ApplicationServices.UserModule.Abstract
{
    public interface IUserServices
    {
        void Create(CreateUserDto input);
        void Update(UpdateUserDto input);
        void Delete(int UserId);

        PageResultDto<List<FindUserDto>> GetAll(FilterDto input);
    }
}
