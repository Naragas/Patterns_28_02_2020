using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Spaceship : MonoBehaviour
    {
        [SerializeField] private SpaceshipData _spaceshipData;
        public Transform _leftGun;
        public Transform _rightGun;
        public float _speed;
        public float _acceleration;
        public float _hp;
        public float _fireForce;
        private Rigidbody2D _rigidbody2D;

        public void Awake()
        {
            _speed = _spaceshipData.Speed;
            _acceleration = _spaceshipData.Acceleration;
            _hp = _spaceshipData.Hp;
            _fireForce = _spaceshipData.Force;
        }

        public Rigidbody2D GetRigidbody()
        {
            if (_rigidbody2D == null)
            {
                gameObject.AddComponent<Rigidbody2D>();
                _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
            }

            return _rigidbody2D;
        }
    }
}
