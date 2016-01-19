using System;

public interface IVisitor
{
    void VisitLight(ILightUnit unit);
    void VisitArmored(IArmoredUnit unit);
}

public interface ILightUnit
{
    int Health { get; set; }

    void Accept(IVisitor visitor);
}

public interface IArmoredUnit
{
    int Health { get; set; }

    void Accept(IVisitor visitor);
}

public class Marine : ILightUnit
{
    public int Health { get; set; }

    public Marine()
    {
        Health = 100;
    }

    public void Accept(IVisitor visitor)
    {
        Health -= 21;
    }
}

public class Marauder : IArmoredUnit
{
    public int Health { get; set; }

    public Marauder()
    {
        Health = 125;
    }

    public void Accept(IVisitor visitor)
    {
        Health -= 32;
    }
}

public class TankBullet : IVisitor
{
    public void VisitLight(ILightUnit unit)
    {
        unit.Accept(this);
    }

    public void VisitArmored(IArmoredUnit unit)
    {
        unit.Accept(this);
    }
}
