using CharityFundConsoleApp.Models;
using CharityFundConsoleApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CharityFundConsoleApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DonationsController : ControllerBase
  {
    private readonly ICharityService _service;

    public DonationsController(ICharityService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Donation>> GetDonations()
    {
      return Ok(_service.GetDonations());
    }

    [HttpPost]
    public ActionResult<Payment> MakeDonation([FromBody] Payment payment)
    {
      var result = _service.ProcessPayment(payment);
      return CreatedAtAction(nameof(GetDonations), new { id = result.Id }, result);
    }
  }
}