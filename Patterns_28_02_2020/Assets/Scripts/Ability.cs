namespace DefaultNamespace
{
    internal class Ability : IAbility
    {
        public string Name { get; }
        public int Damage { get; }
        public AbilityType AbilityType { get; }

        public Ability(string name, int damage, AbilityType abilityType)
        {
            Name = name;
            Damage = damage;
            AbilityType = abilityType;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}