using System;
using System.Collections.Generic;

public abstract class Player {

	private List<Card> hand;

	protected CardCounter counter = new CardCounter();

	public int getPlayerScore ()
	{
		throw new System.Exception ("Not implemented yet!");
	}
	public bool hasCard (Card.Face face) {
		foreach(Card c in hand) {
			if (c.face == face)
				return true;
		}
		return false;
	}
	public abstract void makeMove (GameData game);

}
