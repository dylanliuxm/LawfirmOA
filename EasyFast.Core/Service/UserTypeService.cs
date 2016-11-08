using Abp.Domain.Repositories;
using Abp.Domain.Services;
using EasyFast.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Core.Service
{
    public class UserTypeService: DomainService, IUserTypeService
    {
        private readonly object lockHelper = new object();
        public IRepository<UserType, long> UserTypeRepository { get; set; }

        public long Add(UserType model)
        {
            long _result = 0;
            lock (lockHelper)
            {
                if (!CheckName(model.Id,model.Name))
                {
                    _result = UserTypeRepository.InsertAndGetIdAsync(model).Id;
                }
            }
            return _result;
        }

        public long Update(UserType model)
        {
            long _result = 0;
            lock (lockHelper)
            {
                if (!CheckName(model.Id, model.Name))
                {
                    _result = UserTypeRepository.InsertOrUpdateAndGetIdAsync(model).Id;
                }
            }
            return _result;
        }

        public bool CheckName(long id, string name)
        {
            return UserTypeRepository.GetAll().Any(o => o.Name == name && o.Id != id);
        }
    }
}
