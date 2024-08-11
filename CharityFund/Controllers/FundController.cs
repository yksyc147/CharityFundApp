using CharityFundConsoleApp.Models;
using CharityFundConsoleApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CharityFundConsoleApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExpensesController : ControllerBase
  {
    private readonly ICharityService _service;

    public ExpensesController(ICharityService service)
    {
      _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Expense>> GetExpenses()
    {
      return Ok(_service.GetExpenses());
    }
  }
}