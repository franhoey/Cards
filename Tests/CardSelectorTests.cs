using System.Linq;
using Cards;
using Cards.Cards;
using NUnit.Framework;
using Tests.Builders;


namespace Tests
{
	[TestFixture]
	public class CardSelectorTests
	{
		[Test]
		public void CanGetCard()
		{
			//Given default card set
			var cardService = new CardSelector(CardSetBuilder.RandomCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard);
		}

		[Test]
		public void CardContainsFiveFeatures()
		{
			//Given default card set
			var cardService = new CardSelector(CardSetBuilder.RandomCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard.Features);
			Assert.AreEqual(5, newCard.Features.Count());
		}

		[Test]
		public void AllFeaturesContainUniqueNames()
		{
			//Given default card set
			var cardService = new CardSelector(CardSetBuilder.RandomCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.AreEqual(5, newCard.Features.Select(f => f.Name).Distinct().Count());
		}

		[Test]
		public void CardFeaturesShouldMatchTheCardSetProvided()
		{
			//Given default card set
			var cardSet = CardSetBuilder.RandomCardSet;
			var cardService = new CardSelector(cardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard.Features);

			var cardSetFeatures = cardSet.Features.Select(f => f.Name).ToArray();
			var newCardFeatures = newCard.Features.ToArray();
			for (int i = 0; i < newCardFeatures.Length; i++)
				Assert.AreEqual(cardSetFeatures[i], newCardFeatures[i].Name);
		}

		[Test]
		public void CardFeaturesShouldContainAValue()
		{
			//Given default card set
			var cardService = new CardSelector(CardSetBuilder.RandomCardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard.Features);

			var newCardFeatures = newCard.Features.ToArray();
			for (int i = 0; i < newCardFeatures.Length; i++)
				Assert.Greater(newCardFeatures[i].Value, 0);
		}

		[Test]
		public void CardFeaturesShouldBeInTheFeatureDefinitionRange()
		{
			//Given default card set
			var cardSet = CardSetBuilder.RandomCardSet;
			var cardService = new CardSelector(cardSet);

			//When
			var newCard = cardService.GetCard();

			//Then
			Assert.NotNull(newCard.Features);

			var cardSetFeatures = cardSet.Features.ToArray();
			var newCardFeatures = newCard.Features.ToArray();
			for (int i = 0; i < newCardFeatures.Length; i++)
			{
				Assert.GreaterOrEqual(newCardFeatures[i].Value, cardSetFeatures[i].MinimumValue);
				Assert.LessOrEqual(newCardFeatures[i].Value, cardSetFeatures[i].MaximumValue);
			}
		}

	}
}