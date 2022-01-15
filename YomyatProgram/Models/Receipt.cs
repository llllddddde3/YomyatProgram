using System;
using YomyatProgram.Models.Enums;

namespace YomyatProgram.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public ReceiptType ReceiptType { get; set; }
        public int RelatedId { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public bool IsDebt { get; set; }
        public int? AgencyId { get; set; }
        public Agency Agency { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
