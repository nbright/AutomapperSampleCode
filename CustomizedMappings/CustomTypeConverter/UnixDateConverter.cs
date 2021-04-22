using System;
using AutoMapper;

namespace CustomizedMappings.CustomTypeConverter
{
	class UnixDateConverter : ITypeConverter<double, DateTime>
	{
		public DateTime Convert(ResolutionContext context)
		{
			var source = (double) context.SourceValue;
			var unixEpoch = new DateTime(1970, 1, 1);
			var localDate = unixEpoch.AddSeconds(source).ToLocalTime();
			return localDate;
		}
	}
}