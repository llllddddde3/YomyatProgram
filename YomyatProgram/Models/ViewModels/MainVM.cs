using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YomyatProgram.Models.ViewModels
{
    public class MainVM
    {
        public int? Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
