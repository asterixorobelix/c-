using Practice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common.Types;

namespace API.Controllers
{
    public class SectionsController : ApiController
    {
        DataModel db = new DataModel();

        public IEnumerable<HelpText> Get()
        {
            return null;
        }
    }

}
