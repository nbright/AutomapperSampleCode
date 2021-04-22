using AutoMapper;

namespace CustomizedMappings.Ignore
{
	class IgnoreSample : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<Employee, EmployeeStats>()
				.ForMember(d => d.SickDaysUsed, o => o.Ignore());
		}

		public override void RunSample()
		{
			var employee = new Employee {Name = "Bob Smith"};
			var stats = Mapper.Map<Employee, EmployeeStats>(employee);
		}
	}
}
