using System;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class Projectile : MonoBehaviour
    {
        public float _speed = 3f;
        public float _damage = 2f;

        private void Update()
        {
            Move(_speed);
        }
        protected abstract void Move(float speed);
    }
}