namespace GildedRoseKata;

public class AgedBrieItem : GeneralItem
{
    public AgedBrieItem(Item theItem) : base(theItem) { }

    public override void Update()
    {
        IncreaseQuality();

        TheItem.SellIn -= 1;

        if (TheItem.SellIn < 0)
        {
            IncreaseQuality();
        }
    }

    private void IncreaseQuality()
    {
        if (TheItem.Quality < 50)
        {
            TheItem.Quality += 1;
        }
    }
}