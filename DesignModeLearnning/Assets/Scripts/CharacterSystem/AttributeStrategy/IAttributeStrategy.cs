//策略模式
//计算最大血量、伤害减免、暴击加伤的策略接口 
public interface IAttributeStrategy
{
    int GetExtralHPValue(int lv);
    int GetDmgDescValue(int lv);
    int GetCritDmg(int critRate);
}

