using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAutomapper.MethodBasedMapping
{
	public class EngineConfiguration
	{
		public string ModelNumber { get; set; }
		public int ModelYear { get; set; }


		//GetCylinder, GetCylinderCount 를 찾기도 한다.
		public int CylinderCount()
		{
			return 8;
		}

		// dozens of other properties
		// removed for brevity
	}

	public class EngineInfo
	{
		public string ModelNumber { get; set; }
		public int ModelYear { get; set; }
		public int CylinderCount { get; set; }
	}
}
