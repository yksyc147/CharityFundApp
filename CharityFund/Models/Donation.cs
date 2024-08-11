﻿namespace CharityFundConsoleApp.Models
{
  public class Donation
  {
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string DonorName { get; set; }
    public string Message { get; set; }
  }
}