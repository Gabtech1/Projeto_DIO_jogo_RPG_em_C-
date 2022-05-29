public class Ranger : Hero
{
    public Ranger(string Name, int Level, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
    }

    public override string Attack()
    {
        return this.Name + "Atacou com seu arco";
    }
}