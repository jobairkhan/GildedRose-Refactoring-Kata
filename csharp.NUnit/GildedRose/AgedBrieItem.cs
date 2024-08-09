namespace GildedRoseKata;

public class AgedBrieItem : GeneralItem
{
    public AgedBrieItem(Item theItem) : base(theItem) { }

    public override void Update()
    {
        if (TheItem.Quality < 50)
        {
            TheItem.Quality += 1;
        }

        TheItem.SellIn -= 1;

        if (TheItem.SellIn < 0)
        {
            {
                if (TheItem.Quality < 50)
                {
                    TheItem.Quality += 1;
                }
            }
        }
    }
}