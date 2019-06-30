using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planta.Models;

namespace Planta.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiBaseController<UserGroupApiController>
    {

        [HttpPost]
        [Route("users/add")]
        public IActionResult Post([FromBody]  UserModel record)
        {
            try
            {
                _dbActionManager.Insert<UserModel>(record, "UserModel");
                return Ok(record);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("users/get")]
        public IActionResult Get([FromBody]  UserModel record)
        {
            try
            {
                _dbActionManager.Insert<UserModel>(record, "UserModel");
                return Ok(record);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}