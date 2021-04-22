using System;

namespace CustomizedMappings
{
	class Employee
	{
		public string Name { get; set; }
		public DateTime DateOfBirth { get; set; }
		public DateTime HireDate { get; set; }
		public Employee Supervisor { get; set; }
	}
}