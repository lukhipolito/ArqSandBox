using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArqSandBox.Core.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ArqSandBox.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Orders")]
        public IList<OrderDTO> Orders()
        {
            return new List<OrderDTO>();
        }
    }
}