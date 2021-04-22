using AutoMapper;
using SimpleAutomapper.MethodBasedMapping;
using System.Collections.ObjectModel;

namespace SimpleAutomapper
{
	public class MainWindowViewModel
	{
		CustomerRepository repo;
		public MainWindowViewModel()
		{
			repo = new CustomerRepository();
			LoadCustomer();
			EngineMapping();
			CarMapping();
		}

		private void CarMapping()
		{
			var ec = new EngineConfiguration { ModelNumber = "1A", ModelYear = 2013 };
			var cs = new CarSetup {Configuration = ec, VIN = "123"};

			var info = Mapper.Map<CarSetup, CarInfo>(cs);
		}

		private void EngineMapping()
		{
			var ec = new EngineConfiguration {ModelNumber = "1A", ModelYear = 2013};
			var info = Mapper.Map<EngineConfiguration, EngineInfo>(ec);
		}

		public ObservableCollection<CustomerInfo> CustomerInfos { get; set; }		

		public void LoadCustomer()
		{
			//CustomerDTO customerDto = new CustomerDTO()
			//                          	{
			//                          		Name = "SRT Solutions",
			//                          		Address1 = "206 S. Fifth Avenue",
			//                          		Address2 = "Suite 200",
			//                          		City = "Ann Arbor",
			//                          		State = "MI",
			//                          		Zip = "48104"
			//                          	};
			
			this.CustomerInfos = repo.GetAllCustomer();
		}
	}
}
