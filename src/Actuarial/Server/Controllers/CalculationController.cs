using Actuarial.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Actuarial.Shared.Models;
using System.Threading;

namespace Actuarial.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ILogger<CalculationController> logger;

        public CalculationController(ILogger<CalculationController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public async Task<decimal> Post(CalculationRequest calculationRequest)
        {
            var token = new CancellationToken();
            return await new Task<decimal>(x => 0, token); // calculationService.Process(calculationRequest);
        }
    }
}
