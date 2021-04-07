using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class MoveRightState : PlayerState
    {
        public override void Move(PlayerShip playerShip)
        {
            playerShip.Move(Vector2.right);
        }
    }
}