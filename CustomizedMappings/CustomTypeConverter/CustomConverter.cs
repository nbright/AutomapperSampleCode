using System;
using AutoMapper;

namespace CustomizedMappings.CustomTypeConverter
{
	class CustomConverter : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<double, DateTime>().ConvertUsing<UnixDateConverter>();
			Mapper.CreateMap<JobSpecs, JobInfo>();
		}

		public override void RunSample()
		{
			var jobSpecs = new JobSpecs { Description = "Job 1", StartDate = 86400 };
			var info = Mapper.Map<JobSpecs, JobInfo>(jobSpecs);
		}
	}
}
