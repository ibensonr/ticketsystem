﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities;
using DataModel;
using DataModel.UnitOfWork;

namespace BusinessServices
{
    public class UserServices : IUserServices
    {
        private readonly UnitOfWork _unitOfWork;

        public UserServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        public int CreateUser(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUserById(int userId)
        {
            var user = _unitOfWork.UserRepository.GetByID(userId);
            if (user != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<tbluser, UserEntity>();
                    //cfg.AddProfile()... etc...
                });
                var mapper = config.CreateMapper();
                var userModel = mapper.Map<tbluser, UserEntity>(user);
                return userModel;
            }
            return null;
        }

        public bool UpdateUser(int userId, UserEntity userEntity)
        {
            throw new NotImplementedException();
        }
    }
}
