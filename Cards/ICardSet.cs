using System.Collections;
using System.Collections.Generic;

namespace Cards
{
	public interface ICardSet
	{
		IEnumerable<string> FeatureName { get; } 
	}
}