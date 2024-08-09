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
        else
        {
            if (!IsAgedBrie() && !IsBackstagePasses())
            {
                if (Quality > 0)
                {
                    if (Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Quality = Quality - 1;
                    }
                }
            }
            else
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;

                    if (Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (SellIn < 11)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }

                        if (SellIn < 6)
                        {
                            if (Quality < 50)
                            {
                                Quality = Quality + 1;
                            }
                        }
                    }
                }
            }

            if (Name != "Sulfuras, Hand of Ragnaros")
            {
                SellIn = SellIn - 1;
            }

            if (SellIn < 0)
            {
                if (!IsAgedBrie())
                {
                    if (Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Quality > 0)
                        {
                            if (Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Quality = Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        Quality = Quality - Quality;
                    }
                }
                else
                {
                    if (Quality < 50)
                    {
                        Quality = Quality + 1;
                    }
                }
            }
        }
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