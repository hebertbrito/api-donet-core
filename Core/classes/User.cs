using Infrastructure.models;
using Infrastructure.repository.firebase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User
    {
        readonly UserRepository _repository;
        public User(UserRepository repository)
        {
            this._repository = repository;
        }

        public async Task<LinkedList<UserModelRepository>> GetUsers()
        {
            var response = await _repository.GetUsers();

            return response;
        }
    }
}
