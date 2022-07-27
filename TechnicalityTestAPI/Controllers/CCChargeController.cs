using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalityTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CCChargeController : ControllerBase
    {
        private readonly ICCChargeService _CChargeService;

        public CCChargeController(ICCChargeService cChargeService)
        {
            _CChargeService = cChargeService;
        }

        [HttpGet]
        public List<CCChargeViewModel> Get(int id)
        {
            // id is CustomerId
            return _CChargeService.GetCharges(id);
        }

        [HttpPost]
        public int CreateCCCharge(CCChargeViewModel model)
        {
            return _CChargeService.CreateCCCharge(model.CustomerId, model.Amount);
        }
    }
}
