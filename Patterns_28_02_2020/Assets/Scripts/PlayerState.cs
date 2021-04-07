using UnityEngine;

namespace DefaultNamespace
{
    internal abstract class PlayerState
    {
        public abstract void Move(PlayerShip _playerShip);
    }

    internal sealed class MoveLeftState : PlayerState
    {
        public override void Move(PlayerShip playerShip)
        {
            playerShip.Move(Vector2.left);
        }
    }
    internal sealed class MoveRightState : PlayerState
    {
        public override void Move(PlayerShip playerShip)
        {
            playerShip.Move(Vector2.right);
        }
    }
    
    internal sealed class IdleState : PlayerState
    {
        public override void Move(PlayerShip playerShip)
        {
            playerShip.Move(Vector2.zero);
        }
    }
}