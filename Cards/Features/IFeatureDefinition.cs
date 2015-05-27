namespace Cards.Features
{
	public interface IFeatureDefinition
	{
		string Name { get; set; }
		int MinimumValue { get; set; }
		int MaximumValue { get; set; }
		bool LowestWins { get; set; }
	}
}