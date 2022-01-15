using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YomyatProgram.Models
{
    class Package
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PostsCount { get; set; }
        public double Price { get; set; }
    }
}
