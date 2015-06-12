using System.Collections.Generic;
using Cards.Cards.CardSets;
using Cards.Cards.CardSets.Random;

namespace Tests.Builders
{
	static class CardSetBuilder
	{
		public static readonly RandomCardSet RandomCardSet = new RandomCardSet(
			new List<FeatureDefinition>
			{
				CreateDefinition("a", 1, 5),
				CreateDefinition("b", 1, 100),
				CreateDefinition("c", 1, 20),
				CreateDefinition("d", 1000, 50000),
				CreateDefinition("e", 1, 10)
			});

		//public static DefinedCardSet DefinedCardSet { get; private set; }

		private static FeatureDefinition CreateDefinition(string name, int min, int max)
		{
			return new FeatureDefinition()
			{
				Name = name,
				MinimumValue = min,
				MaximumValue = max
			};
		}
	}
}