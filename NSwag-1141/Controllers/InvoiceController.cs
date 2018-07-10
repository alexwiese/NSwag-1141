using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSwag_1141.Models;

namespace NSwag_1141.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class InvoiceController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<Invoice>> Get()
        {
            return Enumerable.Empty<Invoice>();
        }

        [HttpGet("{id}")]
        public async Task<Invoice> Get(string id)
        {
            return null;
        }
    }
}