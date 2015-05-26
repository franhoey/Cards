using System.Linq;
using Cards;
using NUnit.Framework;
using Tests.Mocks;


namespace Tests
{
	[TestFixture]
	public class CardServiceTests
	{
		[Test]
		public void CanGetCard()
		{
			//Given nothing
			var cardService = new CardService(CardSetMocks.DefaultCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard);
		}

		[Test]
		public void CardContainsFiveFeatures()
		{
			//Given nothing
			var cardService = new CardService(CardSetMocks.DefaultCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard.Features);
			Assert.AreEqual(5, newCard.Features.Count());
		}

		[Test]
		public void AllFeaturesContainUniqueNames()
		{
			//Given nothing
			var cardService = new CardService(CardSetMocks.DefaultCardSet);

			//When
			var newCard = cardService.GetCard();

			Assert.AreEqual(5, newCard.Features.Select(f => f.Name).Distinct().Count());
		}

		[Test]
		public void CardFeaturesShouldMatchTheCardSetProvided()
		{
			//Given nothing
			var cardSet = CardSetMocks.DefaultCardSet;
			var cardService = new CardService(CardSetMocks.DefaultCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard.Features);

			var cardSetFeatures = cardSet.FeatureName.ToArray();
			var newCardFeatures = newCard.Features.ToArray();
			for (int i = 0; i < newCardFeatures.Length; i++)
				Assert.AreEqual(cardSetFeatures[i], newCardFeatures[i].Name);
		}
	}
}