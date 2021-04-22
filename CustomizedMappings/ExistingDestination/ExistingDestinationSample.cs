using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace CustomizedMappings.ExistingDestination
{
	class ExistingDestinationSample : SampleBase
	{
		protected override void InitializeMappings()
		{
			Mapper.CreateMap<UserDTO, UserInfo>()
				.ForMember(d => d.HelpUri, o => o.Ignore());
		}

		public override void RunSample()
		{
			var info = GetUserInfo();
			var dto = new UserDTO
			          	{
			          		Age = 33,
			          		Name = "Bob Smith",
			          	};
			Mapper.Map(dto, info);
		}

		private UserInfo GetUserInfo()
		{
			return new UserInfo
			       	{
			       		HelpUri = new Uri("http://www.contoso.com/help")
			       	};
		}
	}

	class UserDTO
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}

	class UserInfo
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Uri HelpUri { get; set; }		
	}
}
