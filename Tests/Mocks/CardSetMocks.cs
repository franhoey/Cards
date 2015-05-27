using Cards;
using Cards.Cards;
using Cards.Features;
using Moq;
using System.Collections.Generic;


namespace Tests.Mocks
{
	public static class CardSetMocks
	{
		public static Mock<ICardSet> DefaultCardSetMock { get; private set; }
		public static ICardSet DefaultCardSet {
			get
			{
				if (DefaultCardSetMock == null)
				{
					DefaultCardSetMock = new Mock<ICardSet>();
					DefaultCardSetMock.Setup(m => m.Features)
						.Returns(new List<IFeatureDefinition>
						{
							CreateDefinition("a", 1, 5),
							CreateDefinition("b", 1, 100),
							CreateDefinition("c", 1, 20),
							CreateDefinition("d", 1000, 50000),
							CreateDefinition("e", 1, 10)
						});
				}

				return DefaultCardSetMock.Object;
			}
		}

		private static IFeatureDefinition CreateDefinition(string name, int min, int max)
		{
			var mock = new Mock<IFeatureDefinition>();
			mock.Setup(m => m.Name).Returns(name);
			mock.Setup(m => m.MinimumValue).Returns(min);
			mock.Setup(m => m.MaximumValue).Returns(max);
			return mock.Object;
		}
	}
}