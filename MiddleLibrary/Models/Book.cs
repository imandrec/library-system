using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLibrary.Models
{
	public class Book
	{
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Country_of_publication { get; set; }
        public string Publisher { get; set; }
        public string Date_of_publication { get; set; }
        public string Genre { get; set; }
        public string Languages { get; set; }
    }
}
