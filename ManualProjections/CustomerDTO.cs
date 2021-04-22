using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManualProjections
{
	public class CustomerDTO
	{
		public string Name { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }

		public decimal Balance { get; set; }
	}
}
