using System;

namespace YomyatProgram.Models
{
    public class Payment
    {
        public int Id{ get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public string Title { get; set; } = string.Empty;
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public bool IsSalaries { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
