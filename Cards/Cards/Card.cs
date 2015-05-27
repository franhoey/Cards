using System.Collections.Generic;
using Cards.Features;

namespace Cards.Cards
{
	public class Card
	{
		public Card(IEnumerable<Feature> features)
		{
			Features = features;
		}

		public IEnumerable<Feature> Features { get; private set; }
	}
}