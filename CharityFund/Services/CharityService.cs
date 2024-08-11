using CharityFundConsoleApp.Models;
namespace CharityFundConsoleApp.Services
{
  public class CharityService : ICharityService
  {
    // Временные заглушки вместо работы с базой данных
    private readonly List<Donation> _donations = new List<Donation>();
    private readonly List<Expense> _expenses = new List<Expense>();
    private readonly List<FundInfo> _fundInfos = new List<FundInfo>();
    private readonly List<Payment> _payments = new List<Payment>();

    public IEnumerable<Donation> GetDonations()
    {
      return _donations;
    }

    public IEnumerable<Expense> GetExpenses()
    {
      return _expenses;
    }

    public FundInfo GetFundInfo(int id)
    {
      return _fundInfos.FirstOrDefault(f => f.Id == id);
    }

    public Payment ProcessPayment(Payment payment)
    {
      payment.Id = _payments.Count + 1;
      _payments.Add(payment);
      return payment;
    }
  }
}