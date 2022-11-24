
public class SoldierAttributeStrategy : IAttributeStrategy
{
    public int GetCritDmg(int critRate)
    {
        return 0;
    }

    public int GetDmgDescValue(int lv)
    {
        return (lv - 1) * 5;
    }

    public int GetExtralHPValue(int lv)
    {
        return (lv - 1) * 10;
    }
}

