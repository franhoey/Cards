using Cards;
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
					DefaultCardSetMock.Setup(m => m.FeatureName)
						.Returns(new List<string>
						{
							"a",
							"b",
							"c",
							"d",
							"e"
						});
				}

				return DefaultCardSetMock.Object;
			}
		}
	}
}