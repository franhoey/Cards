using System.Collections.Generic;
using System.Linq;

namespace Cards.Cards.CardSets.Random
{
	public class RandomCardSet : ICardSet
	{
		public RandomCardSet(IEnumerable<FeatureDefinition> features)
		{
			Features = features;
		}

		public IEnumerable<FeatureDefinition> Features { get; private set; }
		
		public Card GetCard()
		{
			return new Card(Features.Select(FeatureFactory.BuildFeature));
		}
	}
}