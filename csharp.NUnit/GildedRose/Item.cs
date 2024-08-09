namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update()
    {
        if (IsAgedBrie())
        {
            if (Quality < 50)
            {
                Quality += 1;
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }
            }
        }
        else if (IsBackstagePasses())
        {
            if (Quality < 50)
            {
                Quality += 1;


                if (SellIn < 11)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }

                if (SellIn < 6)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }
            }

            SellIn -= 1;


            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
        else if (IsSulfuras())
        {
            if (Quality < 50)
            {
                Quality += 1;
            }
        }
        else
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

    private bool IsSulfuras()
    {
        return Name == "Sulfuras, Hand of Ragnaros";
    }

    private bool IsBackstagePasses()
    {
        return Name == "Backstage passes to a TAFKAL80ETC concert";
    }

    private bool IsAgedBrie()
    {
        return Name == "Aged Brie";
    }
}