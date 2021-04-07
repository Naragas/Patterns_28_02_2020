using UnityEngine;

namespace DefaultNamespace
{
    internal class MoveTransform : IMove
    {
        private readonly Rigidbody2D _rigidbody2D;
        
        public float Speed { get; protected set; }
        
        public MoveTransform(Rigidbody2D rigidbody2D, float speed)
        {
            _rigidbody2D = rigidbody2D;
            Speed = speed;
        }

        /*public void Move(float horizontal, float vertical)
        {
            _rigidbody2D.velocity = new Vector2(horizontal * Speed, vertical * Speed);
        }*/
        public void Move(Vector2 directon)
        {
            _rigidbody2D.velocity = directon * Speed;
        }
    }
}

