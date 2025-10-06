using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public bool IsIncome { get; set; }
    }
}