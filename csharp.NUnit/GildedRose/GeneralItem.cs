namespace GildedRoseKata;

public class GeneralItem : Item
{
    public override void Update()
    {
        if (Quality > 0)
        {
            Quality -= 1;
        }

        SellIn -= 1;


        if (SellIn < 0 && Quality > 0)
        {
            Quality -= 1;
        }
    }
}