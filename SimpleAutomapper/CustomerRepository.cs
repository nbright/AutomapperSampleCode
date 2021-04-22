using AutoMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SimpleAutomapper
{
    public class CustomerRepository
    {
        public ObservableCollection<CustomerInfo> GetAllCustomer()
        {
			//Dummy 
			CustomerDTO customerDto1 = new CustomerDTO()
			{
				Name = "SRT1 Solutions",
				Address1 = "Fifth Avenue",
				Address2 = "Suite 200",
				City = "Ann Arbor",
				State = "MI",
				Zip = "32445"
			};
			CustomerDTO customerDto2 = new CustomerDTO()
			{
				Name = "SRT2 Solutions",
				Address1 = "dfsgse Avenue",
				Address2 = "Suite 200",
				City = "Ann Arbor",
				State = "MI",
				Zip = "346"
			};
			CustomerDTO customerDto3 = new CustomerDTO()
			{
				Name = "SRT3 Solutions",
				Address1 = "34e4bger Avenue",
				Address2 = "Suite 200",
				City = "Ann Arbor",
				State = "MI",
				Zip = "578"
			};
			CustomerDTO customerDto4 = new CustomerDTO()
			{
				Name = "SRT4 Solutions",
				Address1 = "dsfweerew",
				Address2 = "Suite 200",
				City = "Ann Arbor",
				State = "MI",
				Zip = "48104"
			};

			ObservableCollection<CustomerDTO> customerDTOs = new ObservableCollection<CustomerDTO>();
			customerDTOs.Add(customerDto1);
			customerDTOs.Add(customerDto2);
			customerDTOs.Add(customerDto3);
			customerDTOs.Add(customerDto4);

			ObservableCollection<CustomerInfo> customerInfos = new ObservableCollection<CustomerInfo>();
			foreach (var customerDto in customerDTOs)
			{
				customerInfos.Add(Mapper.Map<CustomerDTO, CustomerInfo>(customerDto));
			}

			return customerInfos;
		}

    }
}
