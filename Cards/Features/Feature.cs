namespace Cards.Features
{
	public class Feature
	{
		public Feature(string name, int value, bool lowestWins)
		{
			Name = name;
			Value = value;
			LowestWins = lowestWins;
		}

		public string Name { get; private set; }
		public int Value { get; private set; }
		public bool LowestWins { get; private set; }
	}
}