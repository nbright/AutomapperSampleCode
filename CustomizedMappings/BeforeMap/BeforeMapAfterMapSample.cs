using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace CustomizedMappings.BeforeMap
{
	internal class BeforeMapAfterMapSample : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<SelectedJob, Job>()
				.BeforeMap((s, d) => s.Job = new JobDTO {Description = "D: " + s.Id})
				.AfterMap((s, d) => d.JobName = "JOB: " + s.Id);
		}

		public override void RunSample()
		{
			var jobs = new[]
			           	{
			           		new SelectedJob {Id = 2},
			           		new SelectedJob {Id = 4},
			           		new SelectedJob {Id = 9},
			           	};

			var mapped = Mapper.Map<IEnumerable<SelectedJob>, IEnumerable<Job>>(jobs);
		}
	}

	internal class SelectedJob
	{
		public int Id { get; set; }
		public JobDTO Job { get; set; }
	}

	internal class JobDTO
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}

	class Job
	{
		public string JobName { get; set; }
		public string JobDescription { get; set; }
	}
}