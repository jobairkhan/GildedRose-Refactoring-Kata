namespace GildedRoseKata;

public class BackstagePassItem : GeneralItem
{
    public BackstagePassItem(Item item) : base(item)
    {

    }

    public override void Update()
    {
        if (TheItem.Quality < 50)
        {
            TheItem.Quality += 1;
            if(TheItem.Quality < 50)
            {
                DoubleQuality();
            }
        }
        
        TheItem.SellIn -= 1;
        
        if (TheItem.SellIn < 0)
        {
            TheItem.Quality = 0;
        }
    }

    private void DoubleQuality()
    {
        if (TheItem.SellIn < 11)
        {
            TheItem.Quality += 1;
        }
        
        if (TheItem.SellIn < 6)
        {
            TheItem.Quality += 1;
        }
    }
}