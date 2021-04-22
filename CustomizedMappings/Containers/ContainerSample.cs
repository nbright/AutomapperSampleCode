using System;
using AutoMapper;

namespace CustomizedMappings.Containers
{
	class ContainerSample : SampleBase
	{
		protected override void InitializeMappings()
		{
			var factory = new FighterFactory();

			Mapper.CreateMap<Ninja, Fighter>()
				.ConstructUsing(s => factory.GetFighter())
				.ForMember(d => d.Id, o => o.Ignore())
				.ForMember(d => d.Type, o => o.MapFrom(s => "NINJA"));
		}

		public override void RunSample()
		{
			var ninja = new Ninja {Name = "Ra's Al Ghul"};
			var fighter = Mapper.Map<Ninja, Fighter>(ninja);
		}
	}

	interface IFighterFactory
	{
		Fighter GetFighter();
	}

	public class FighterFactory : IFighterFactory
	{
		public Fighter GetFighter()
		{
			return new Fighter {Id = Guid.NewGuid()};
		}
	}

	class Ninja
	{
		public string Name { get; set; }
	}

	public class Fighter
	{
		public Guid Id { get; set; }
		public string Type { get; set; }
		public string Name { get; set; }
	}
}
