using System;

namespace Cards.Features
{
	public static class FeatureFactory
	{
		public static Feature BuildFeature(IFeatureDefinition definition)
		{
			return new Feature(
				definition.Name, 
				(new Random()).Next(definition.MinimumValue, definition.MaximumValue),
				definition.LowestWins);
		}
	}
}