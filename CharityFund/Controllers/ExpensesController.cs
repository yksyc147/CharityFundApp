using CharityFundConsoleApp.Models;
using CharityFundConsoleApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CharityFundConsoleApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FundController : ControllerBase
  {
    private readonly ICharityService _service;

    public FundController(ICharityService service)
    {
      _service = service;
    }

    [HttpGet("{id}")]
    public ActionResult<FundInfo> GetFundInfo(int id)
    {
      var fundInfo = _service.GetFundInfo(id);
      if (fundInfo == null)
      {
        return NotFound();
      }

      return Ok(fundInfo);
    }
  }
}