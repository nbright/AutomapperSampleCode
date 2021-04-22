using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CustomizedMappings.BeforeMap;
using CustomizedMappings.Containers;
using CustomizedMappings.CustomTypeConverter;
using CustomizedMappings.CustomValueMapping;
using CustomizedMappings.CustomValueResolver;
using CustomizedMappings.ExistingDestination;
using CustomizedMappings.Ignore;
using CustomizedMappings.ListsAndArrays;

namespace CustomizedMappings
{
	class Program
	{
		static void Main(string[] args)
		{
			//Mapper.Initialize(c => c.AddProfile<SampleProfile>());
			//Mapper.AssertConfigurationIsValid();

			Run<IgnoreSample>();
			Run<CustomMapping>();
			Run<CustomResolver>();
			Run<CustomConverter>();
			Run<ListSample>();
			Run<BeforeMapAfterMapSample>();
			Run<ContainerSample>();
			Run<ExistingDestinationSample>();
		}

		private static void Run<T>() where T:SampleBase, new()
		{
			var sample = new T();
			sample.RunSample();
		}
	}
}
