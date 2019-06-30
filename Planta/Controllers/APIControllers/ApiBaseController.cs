using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Planta.DBActions;

namespace Planta.Api.Controller
{
    [Route("planta/api/v1.1")]
    [ApiController]
    public class ApiBaseController<TChildApiController> : ControllerBase
    {
       protected IDbAdaptor _dbActionManager;


    }
}