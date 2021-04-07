using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class MoveLeftState : PlayerState
    {
        public override void Move(PlayerShip playerShip)
        {
            playerShip.Move(Vector2.left);
        }
    }
}