using System.Collections.Generic;
using Cards.Features;

namespace Cards.Cards
{
	public interface ICardSet
	{
		IEnumerable<IFeatureDefinition> Features { get; } 
	}
}