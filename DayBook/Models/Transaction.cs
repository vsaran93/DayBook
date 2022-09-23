using System;
namespace DayBook.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        public DateTime CreatedAt { get; set; }
    }

    public class TransactionDto
    {
        public string Description { get; set; } = string.Empty;

        public DateTime TransactionDate { get; set; }

        public double Amount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

