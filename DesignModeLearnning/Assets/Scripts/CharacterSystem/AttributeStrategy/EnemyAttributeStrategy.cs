//具体属性计算策略
public class EnemyAttributeStrategy : IAttributeStrategy
{
    public int GetCritDmg(int critRate)
    {
        if (critRate <= 0) return 0;
        return UnityEngine.Random.Range(0, 1) <= critRate ? (int)UnityEngine.Random.Range(0.5f, 1f) * 5 : 0;
    }

    public int GetDmgDescValue(int lv)
    {
        return 0;
    }

    public int GetExtralHPValue(int lv)
    {
        return 0;
    }
}

