using System;
using System.Collections.Generic;

public class GameData {
	private List<AbstractCard> table;
	private List<Card> deck;

	protected List<Player> players;

	public bool isTableEmpty () {
		return (table.Count == 0);
	}
	public List<AbstractCard> getTable () {
		return table;
	}
	public void trailCard (Card c) {
		table.Add (new AbstractCard(c));
	}
	public List<AbstractCard> captureWithCard (Card c) {
		List<AbstractCard> rv = new List<AbstractCard>();
		foreach (AbstractCard card in table) {
			if (card.Value == c.face)
				rv.Add(card);
		}
		if (rv.Count == 0)
			throw new Exception("No cards captured");
		rv.Add (new AbstractCard(c));
		return rv;
	}
}
