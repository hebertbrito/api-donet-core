using Infrastructure.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IGetUsers
    {
        Task<LinkedList<UserModelRepository>> GetUsers();
    }
}
