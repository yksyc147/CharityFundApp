namespace CharityFundConsoleApp.Models
{
  public class Payment
  {
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string PaymentMethod { get; set; }
    public int DonationId { get; set; }
    public Donation Donation { get; set; }
  }
}