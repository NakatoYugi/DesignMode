
public class ICharacterAttribute
{
    protected string mName;
    protected int mMaxHP;
    protected float mMoveSpeed;

    protected int mCurrentHP;

    protected string mIconSprite;

    protected int mLv;
    protected float mCritRate; //0-1暴击率

    protected IAttributeStrategy mStrategy;
}

