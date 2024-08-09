using System.Collections.Generic;
using System.Diagnostics;

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
            var temp = GetUpdatable(item);
            temp.Update();
        }
    }

    private IUpdateItem GetUpdatable(Item item)
    {
        return item.Name switch
        {
            "Aged Brie" => new AgedBrieItem(item),
            "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItem(item),
            "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item),
            _ => new GeneralItem(item),
        };
    }

    //private static void Update(Item item)
    //{
    //    switch (item.Name)
    //    {
    //        case "Aged Brie":
    //            item.AgedBrieItemUpdate();
    //            break;
    //        case "Backstage passes to a TAFKAL80ETC concert":
    //            item.BackstagePassItemUpdate();
    //            break;
    //        case "Sulfuras, Hand of Ragnaros":
    //            item.SulfurasUpdate();
    //            break;
    //        default:
    //            item.GeneralItemUpdate();
    //            break;
    //    }
    //}

}