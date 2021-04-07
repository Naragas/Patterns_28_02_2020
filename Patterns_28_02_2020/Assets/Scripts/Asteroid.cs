using System;

namespace DefaultNamespace
{
    public sealed class Asteroid : Enemy, IDeath
    {
        public event Action OnDeathChange;
        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }

        public void AsteroidDestory()
        {
            OnDeathChange?.Invoke();
        }
    }
}