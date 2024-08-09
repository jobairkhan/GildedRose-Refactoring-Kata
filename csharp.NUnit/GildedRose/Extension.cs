using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public static class Extension
    {
        public static void GeneralItemUpdate(this Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }

            item.SellIn -= 1;


            if (item.SellIn < 0 && item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }


        public static void AgedBrieItemUpdate(this Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }

            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                {
                    if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }
            }
        }
        public static void BackstagePassItemUpdate(this Item item)
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
                item.Quality = 0;
            }
        }
        public static void SulfurasUpdate(this Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }
    }
}
