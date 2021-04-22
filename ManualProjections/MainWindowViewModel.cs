using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManualProjections
{
	public class MainWindowViewModel
	{
		public string Name { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		
		public void LoadCustomer()
		{
			CustomerDTO customerDto = new CustomerDTO();
			// load customer DTO from ORM (code elided)
			this.Name = customerDto.Name;
			this.Address1 = customerDto.Address1;
			this.Address2 = customerDto.Address2;
			this.City = customerDto.City;
			this.State = customerDto.State;
			this.Zip = customerDto.Zip;
		}
	}
}
