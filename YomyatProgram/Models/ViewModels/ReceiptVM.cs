using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YomyatProgram.Models.ViewModels
{
    public class ReceiptVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public double Value { get; set; }
        public string ReceiptType { get; set; } = string.Empty;
        public string Related { get; set; } = string.Empty;
        public string AgencyName { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
