using System;
using System.Collections.Generic;
using AutoMapper;

namespace CustomizedMappings.ListsAndArrays
{
	class ListSample : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<Employee, EmployeeService>()
				.ForMember(d => d.Years, o => o.ResolveUsing<YearsOfServiceResolver>());
		}

		public override void RunSample()
		{
			var partTimers = GetParttimeEmployees();
			var serviceInfo = Mapper.Map<IEnumerable<Employee>,
				IEnumerable<EmployeeService>>(partTimers);
		}

		private static IEnumerable<Employee> GetParttimeEmployees()
		{
			yield return new Employee
			{
				Name = "Bob Smith",
				DateOfBirth = new DateTime(1997, 1, 1),
				HireDate = new DateTime(1997, 1, 1)
			};
			yield return new Employee
			{
				Name = "Mary Sue",
				DateOfBirth = new DateTime(1967, 1, 1),
				HireDate = new DateTime(1967, 1, 1)
			};
			yield return new Employee
			{
				Name = "Cave Johnson",
				DateOfBirth= new DateTime(1937, 1, 1),
				HireDate = new DateTime(1937, 1, 1)
			};
		}
	}
}
