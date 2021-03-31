using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace
{
    internal interface IPlayerShipAbility
    {
        IAbility this[int index] { get; }
        string this[AbilityType index] { get; }
        int MaxDamage { get; }
        IEnumerable<IAbility> GetAbility();
        IEnumerator GetEnumerator();
        

    }
}