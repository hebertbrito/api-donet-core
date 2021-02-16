using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.repository.firebase;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.repository.helper;
using System.IO;
using System.Collections;
using Infrastructure.models;

namespace API.Main.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<LinkedList<UserModelRepository>> GetUsers()
        { 
            Firebase firebase = new Firebase("PROJECT-ID");
            UserRepository teste = new UserRepository(firebase);
            User user = new User(teste);
            var response = await user.GetUsers();
            return response;
        }
    }

}
