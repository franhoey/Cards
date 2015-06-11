namespace Cards.Cards.CardSets.Random
{
	public static class FeatureFactory
	{
		public static Feature BuildFeature(FeatureDefinition definition)
		{
			return new Feature(
				definition.Name, 
				(new System.Random()).Next(definition.MinimumValue, definition.MaximumValue),
				definition.LowestWins);
		}
	}
}