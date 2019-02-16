using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Accounts.Models;

namespace Accounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet("{iban}")]
        public async Task<ActionResult<IAccount>> GetByIBAN([FromRoute]string iban)
        {
            return Ok($"GetByIBAN: {iban}");
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IAccount>>> GetByIIN([FromQuery]string iin)
        {
            return Ok($"GetByIIN: {iin}");
            throw new NotImplementedException();
        }
    }
}