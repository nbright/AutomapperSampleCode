using System.Windows;
using AutoMapper;
using SimpleAutomapper.MethodBasedMapping;

namespace SimpleAutomapper
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			InitializeAutomapper();
			base.OnStartup(e);
		}

		private void InitializeAutomapper()
		{
			Mapper.CreateMap<CustomerDTO, CustomerInfo>();
			//Mapper.CreateMap<CustomerInfo,CustomerDTO>();
			Mapper.CreateMap<EngineConfiguration, EngineInfo>();
			Mapper.CreateMap<CarSetup, CarInfo>();

			Mapper.AssertConfigurationIsValid();
		}
	}
}
