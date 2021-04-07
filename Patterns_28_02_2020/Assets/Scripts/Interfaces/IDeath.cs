using System;

namespace DefaultNamespace
{
    public interface IDeath
    {
        event Action OnDeathChange;
    }
}