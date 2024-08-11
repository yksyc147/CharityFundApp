using CharityFundConsoleApp.Models;
namespace CharityFundConsoleApp.Services
{
  public interface ICharityService
  {
    IEnumerable<Donation> GetDonations();
    IEnumerable<Expense> GetExpenses();
    FundInfo GetFundInfo(int id);
    Payment ProcessPayment(Payment payment);
  }
}