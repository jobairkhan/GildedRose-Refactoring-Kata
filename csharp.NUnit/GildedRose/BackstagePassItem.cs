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


            if (TheItem.SellIn < 11)
            {
                if (TheItem.Quality < 50)
                {
                    TheItem.Quality += 1;
                }
            }

            if (TheItem.SellIn < 6)
            {
                if (TheItem.Quality < 50)
                {
                    TheItem.Quality += 1;
                }
            }
        }

        TheItem.SellIn -= 1;


        if (TheItem.SellIn < 0)
        {
            TheItem.Quality = 0;
        }
    }
}