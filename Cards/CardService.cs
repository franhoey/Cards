using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class CardService
    {
		private readonly ICardSet _cardSet;

	    public CardService(ICardSet cardSet)
	    {
			if(cardSet == null)
				throw new ArgumentNullException("cardSet");

			_cardSet = cardSet;
	    }

	    public Card GetCard()
	    {
			return new Card()
				{
					Features = _cardSet.FeatureName.Select(f => new Feature() { Name = f })
				};
	    }
    }
}
