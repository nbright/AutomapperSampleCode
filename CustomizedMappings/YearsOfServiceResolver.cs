using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using CustomizedMappings.Ignore;

namespace CustomizedMappings
{
	class YearsOfServiceResolver : ValueResolver<Employee, int>
	{
		protected override int ResolveCore(Employee source)
		{
			var age = DateTime.Now - source.DateOfBirth;
			if (age.TotalDays / 365 >= 50)
			{
				return (int) ((DateTime.Now - source.HireDate).TotalDays/365);
			}

			return (int) ((DateTime.Now - source.HireDate).TotalDays/365) - 3;
		}
	}
}
