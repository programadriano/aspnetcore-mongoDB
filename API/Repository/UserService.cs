using API.Domain;
using API.Infra;
using API.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class UserService : IUserService
    {
        private readonly MongoRepository _repository = null;
        public UserService(IOptions<Settings> settings)
        {
            _repository = new MongoRepository(settings);
        }

        public Task<User> FindUser(User user)
        {
            return _repository.user.Find(x => x.UserName == user.UserName && x.PassWord == user.PassWord).FirstOrDefaultAsync();
        }
    }
}
