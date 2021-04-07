using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class IdleState : PlayerState
    {
        public override void Move(PlayerShip playerShip)
        {
            playerShip.Move(Vector2.zero);
        }
    }
}