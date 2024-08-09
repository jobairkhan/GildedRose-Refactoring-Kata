namespace GildedRoseKata;

public class GeneralItem : IUpdateItem
{
    protected readonly Item TheItem;

    public GeneralItem(Item theItem)
    {
        this.TheItem = theItem;
    }

    public virtual void Update()
    {
        if (TheItem.Quality > 0)
        {
            TheItem.Quality -= 1;
        }

        TheItem.SellIn -= 1;


        if (TheItem.SellIn < 0 && TheItem.Quality > 0)
        {
            TheItem.Quality -= 1;
        }
    }
}