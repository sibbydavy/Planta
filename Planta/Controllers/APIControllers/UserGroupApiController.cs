using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planta.DBActions;
using Planta.DTOObjects.DTOObjectAction;
using Planta.Models;

namespace Planta.Api.Controller
{
    //[Route("UserGroup")]
    [ApiController]
    public class UserGroupApiController :  ApiBaseController<UserGroupApiController>
    {      
        public UserGroupApiController(IDbAdaptor dbActionManager)
        {
           _dbActionManager = dbActionManager;
        }
        // GET: api/UserGroupApi
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserGroupApi/5
        //[HttpGet("{id}", Name = "Get")]
        [HttpGet]
        [Route("user-groups/get/{id}")]
        public IActionResult Get(Int32 id)
        {
            try
            {
               var record = _dbActionManager.Get<UserGroupModel>(id, "UserGroup");
                return Ok(record);
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        [HttpPost]
        [Route("user-groups/add")]
        public  IActionResult Post([FromBody]  UserGroupModel record)
        {
            try
            {
            //    UserModel userModel = new UserModel();
            //    userModel.Name = "john";
            //    userModel.UserGroup = new List<UserGroupModel>();
            //    userModel.UserGroup.Add(new UserGroupModel() { Description = "xyz" });

                _dbActionManager.Insert<UserGroupModel>(record, "User");
                // _dbActionManager.Insert<UserGroupModel>(record, "UserGroup");
                return Ok(record);
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        // PUT: api/UserGroupApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
