namespace GildedRoseKata;

public class SulfurasItem : Item
{
    public override void Update()
    {
        if (Quality < 50)
        {
            Quality += 1;
        }
    }
}