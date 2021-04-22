using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAutomapper.MethodBasedMapping
{
	public class CarSetup
	{
		public string VIN { get; set; }
		public string Maker { get; set; }
		public Guid ExportCode { get; set; }
		public EngineConfiguration Configuration { get; set; }
		public int DefectRate { get; set; }
	}

	public class CarInfo
	{
		public string VIN { get; set; }
		public string ConfigurationModelNumber { get; set; }
	}
}
