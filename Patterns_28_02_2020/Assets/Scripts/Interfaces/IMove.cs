using UnityEngine;

namespace DefaultNamespace
{
    public interface IMove
    {
        float Speed { get; }
        //void Move(float horizontal, float vertical);
        void Move(Vector2 dir);
    }
}