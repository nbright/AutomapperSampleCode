using AutoMapper;

namespace CustomizedMappings
{
	abstract class SampleBase
	{
		protected SampleBase()
		{
			InitializeMappings();
			Mapper.AssertConfigurationIsValid();
		}

		protected abstract void InitializeMappings();
		public abstract void RunSample();
	}
}
