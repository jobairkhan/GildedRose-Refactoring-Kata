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
        foreach (var item in Items)
        {
            Update(item);
        }
    }

    private static void Update(Item item)
    {
        switch (item.Name)
        {
            case "Aged Brie":
                item.AgedBrieItemUpdate();
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                item.BackstagePassItemUpdate();
                break;
            case "Sulfuras, Hand of Ragnaros":
                item.SulfurasUpdate();
                break;
            default:
                item.GeneralItemUpdate();
                break;
        }
    }
}