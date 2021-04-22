using AutoMapper;
using CustomizedMappings.ExistingDestination;

namespace CustomizedMappings
{
	class SampleProfile : Profile
	{
		public override string ProfileName
		{
			get { return "VSM Samples"; }
		}

		protected override void Configure()
		{
			Mapper.CreateMap<Employee, EmployeeStats>()
				.ForMember(d => d.SickDaysUsed, o => o.Ignore());

			Mapper.CreateMap<Employee, EmployeeStats>()
				.ForMember(d => d.SickDaysUsed, o => o.Ignore());

			Mapper.CreateMap<Employee, EmployeeService>()
			.ForMember(d => d.Years, o => o.ResolveUsing<YearsOfServiceResolver>());

			Mapper.CreateMap<UserDTO, UserInfo>()
				.ForMember(d => d.HelpUri, o => o.Ignore());
		}
	}
}
