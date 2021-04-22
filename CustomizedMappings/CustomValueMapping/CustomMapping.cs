using System;
using AutoMapper;

namespace CustomizedMappings.CustomValueMapping
{
	class CustomMapping : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<Employee, EmployeeService>()
				.ForMember(d => d.Years, o => o.MapFrom(s => (DateTime.Now - s.HireDate).TotalDays / 365));
		}

		public override void RunSample()
		{
			var employee = GetEmployee();
			var stats = Mapper.Map<Employee, EmployeeStats>(employee);
			stats.SickDaysUsed = GetSickDays(employee);
		}

		private Employee GetEmployee()
		{
			return new Employee {Name = "Bob Smith"};
		}

		private int GetSickDays(Employee employee)
		{
			return 5;
		}
	}
}
