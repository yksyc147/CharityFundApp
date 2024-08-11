namespace CharityFundConsoleApp.Models
{
  public class Expense
  {
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Purpose { get; set; }
  }
}