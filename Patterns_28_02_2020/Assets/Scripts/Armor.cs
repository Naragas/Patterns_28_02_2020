namespace DefaultNamespace
{
    public sealed class Armor
    {
        public float Max { get; }
        public  float Current { get; private set; }

        public Armor(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }
    }
}