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
    public class ProductExpenseController : ApiBaseController<ProductExpenseController>
    {
        [HttpPost]
        [Route("product-expeses/add")]
        public IActionResult Post([FromBody]  ProductExpenseModel record)
        {
            try
            {
                _dbActionManager.Insert<ProductExpenseModel>(record, "UserModel");
                return Ok(record);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("product-expeses/get/{farmid}/{cropid}")]
        public IActionResult Get(Int32 id)
        {
            try
            {
               var record = _dbActionManager.Get<ProductExpenseModel>(id, "UserModel");
                return Ok(record);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}