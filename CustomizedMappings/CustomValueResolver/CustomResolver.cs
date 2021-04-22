using System;
using AutoMapper;

namespace CustomizedMappings.CustomValueResolver
{
	class CustomResolver : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<Employee, EmployeeService>()
				.ForMember(d => d.Years, o => o.ResolveUsing<YearsOfServiceResolver>());
		}

		public override void RunSample()
		{
			var employee = new Employee
			               	{
			               		Name = "Bob Smith",
			               		HireDate = new DateTime(2001, 1, 4),
			               		DateOfBirth = new DateTime(1955, 1, 1),
			               	};
			var service = Mapper.Map<Employee, EmployeeService>(employee);
		}
	}
}
