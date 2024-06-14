using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        const string agedBrie = "Aged Brie";
        const string concert = "Backstage passes to a TAFKAL80ETC concert";
        const string sulfuras = "Sulfuras, Hand of Ragnaros";

        foreach (var item in Items)
        {
            switch (item.Name)
            {
                case agedBrie:
                    UpdateAgedBrieQuality(item);
                    break;
                case concert:
                    UpdateConcertQuality(item);
                    break;
                case sulfuras:
                    UpdateSulfurasQuality(item);
                    break;
                default:
                    UpdateCommonQuality(item);
                    break;
            }
        }
    }

    private void UpdateCommonQuality(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 1;
        }
        item.SellIn -= 1;
        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }
    }

    private void UpdateSulfurasQuality(Item item)
    {
        //No changes for sulfuras
    }

    private void UpdateAgedBrieQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality += 1;
        }
        item.SellIn -= 1;
        if (item.SellIn < 0)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }
    }

    private static void UpdateConcertQuality(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality += 1;

            if (item.SellIn < 11)
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;
                }
            }
        }
        item.SellIn -= 1;
        if (item.SellIn < 0)
        {
            item.Quality -= item.Quality;
        }
    }
}